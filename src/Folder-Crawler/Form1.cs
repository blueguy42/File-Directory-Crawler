using Folder_Crawler_Algo;
using Krypton.Toolkit;
using TreeNodes;

namespace Folder_Crawler
{
    public partial class Form1 : KryptonForm
    {
        //create a viewer object 
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        //create a graph object 
        Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        int graphcounter = 0;   // check to renew graph if graph not new

        // add delay of milliseconds
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled) { Application.DoEvents(); }
        }
        // method to build graph
        public void updateGraph(Microsoft.Msagl.GraphViewerGdi.GViewer viewer, Microsoft.Msagl.Drawing.Graph graph, Krypton.Toolkit.KryptonPanel graphPanel)
        {
            viewer.Graph = graph;
            graphPanel.SuspendLayout();
            graphPanel.Controls.Add(viewer);
            graphPanel.ResumeLayout();
        }

        // KOMPONEN GUI //
        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e) { }

        // Jika tombol browse folder diklik
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog1 = new FolderBrowserDialog();
            FolderBrowserDialog1.ShowDialog();
            FolderLabel.Text = FolderBrowserDialog1.SelectedPath;
        }

        private void FolderLabel_Paint(object sender, PaintEventArgs e) { }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e) { }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e) { }

        private void kryptonWrapLabel1_Click(object sender, EventArgs e) { }

        // Semaphore agar algoritma dan penggambaran hanya dijalankan
        // bila algoritma/penggambaran tree sebelumnya sudah selesai
        Boolean algoRunning = false;

        // Jika tombol "Mulai Pencarian" diklik
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            // cek algoritma atau penggambaran tree sebelumnya sudah selesai
            if (!algoRunning)
            {
                // Inisialisasi variabel sesuai masukan user
                string fileName = kryptonTextBox1.Text;
                string rootPath = FolderLabel.Text;
                Boolean findAllOccurrence = SemuaFileCheck.Checked;
                treeNode[] parentAndChildren = new treeNode[] { };
                long totalTime = 0;
                int algorithm = -1; //0 for BFS, 1 for DFS
                int waitTime = trackBar1.Value;

                // cek apakah algoritma yang dipakai BFS atau DFS
                if (BFS.Checked) { algorithm = 0; }
                else if (DFS.Checked) { algorithm = 1; }

                // Cek apakah isian user sudah terisi semua
                if (fileName == "" || rootPath == "" || rootPath == "Belum ada folder yang dipilih" || algorithm == -1)
                {
                    WarningLabel.Text = "! Silakan lengkapi masukan terlebih dahulu";
                    WarningLabel.Visible = true;
                }
                else
                {
                    // Menyalakan semaphore agar klik tombol tidak
                    // memulai algoritma/penggambaran tre yang baru
                    algoRunning = true;

                    // Mengubah tampilan GUI saaat memulai algoritma
                    Status.Text = "Menggambar pohon...";
                    Status.Visible = true;
                    WelcomeLabel.Visible = false;
                    WarningLabel.Visible = false;
                    PohonLabel.Visible = true;
                    graphPanel.Visible = true;
                    DitemukanLabel.Visible = false;
                    TimeLabel.Text = "Waktu yang dibutuhkan algoritma: - ms";
                    TimeLabel.Visible = true;
                    Hasils.Visible = true;
                    Hasils.Controls.Clear();

                    // Inisialisasi array string kumpulan path untuk algoritma
                    String[] targetPath = new string[] { };

                    // Jalankan algoritma DFS/BFS
                    Main.RunAlgorithm(fileName, rootPath, findAllOccurrence, algorithm, ref targetPath, ref parentAndChildren, ref totalTime);

                    // Jika ditemukan subfolder/file
                    if (targetPath.Length > 0)
                    {
                        DitemukanLabel.Text = "Ketemu!";
                    }
                    else
                    {
                        DitemukanLabel.Text = "File tidak ditemukan :(";
                    }

                    // Dealokasi dan buat graf baru bila graf sudah ada sebelumnya
                    if (!(graphcounter == 0))
                    {
                        graph = null;
                        graph = new Microsoft.Msagl.Drawing.Graph("graph");
                    }

                    // Munculkan graf
                    viewer.Visible = true;
                    viewer.Width = graphPanel.Width;
                    viewer.Height = graphPanel.Height;

                    // gambar graf untuk rootpath
                    graph.AddNode(rootPath);
                    graph.FindNode(rootPath).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                    graph.FindNode(rootPath).LabelText = Path.GetFileName(rootPath);
                    graph.FindNode(rootPath).Label.FontColor = Microsoft.Msagl.Drawing.Color.Black;
                    updateGraph(viewer, graph, graphPanel);
                    wait(waitTime);
                    graph.FindNode(rootPath).Label.FontColor = Microsoft.Msagl.Drawing.Color.Red;
                    updateGraph(viewer, graph, graphPanel);
                    wait(waitTime);

                    // Loop gambar graf untuk anak-anak rootpath
                    bool isChanged = true;
                    foreach (treeNode parentAndChild in parentAndChildren) {
                        // Boolean untuk menambah delay untuk penambahan childPath ke queue algoritma
                        bool firstChild = true;
                        for (int i = 0; i < parentAndChild.getChildPath().Length; i++) { // loop setiap child dari parent
                            // Menambahkan delay bila pohon berubah
                            if (isChanged && firstChild) {
                                wait(waitTime);
                            }
                            isChanged = false;

                            // Penambahan node child untuk antrian algoritma (warna hitam)
                            if (parentAndChild.getCheck() == 0)
                            {
                                firstChild = false;
                                // Bila edge dan node anak sudah ada tidak perlu menambah edge lagi
                                bool foundSameEdge = false;
                                foreach (var edge in graph.FindNode(parentAndChild.getParentPath()).Edges)
                                {
                                    if (edge.Target.ToString() == parentAndChild.getChildPath()[i])
                                    {
                                        foundSameEdge = true;
                                    }
                                }
                                // Bila edge dan node anak belum ada tambah
                                if (!foundSameEdge)
                                {
                                    graph.AddEdge(parentAndChild.getParentPath(), parentAndChild.getChildPath()[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                                    graph.FindNode(parentAndChild.getChildPath()[i]).Label.FontColor = Microsoft.Msagl.Drawing.Color.Black;
                                    isChanged = true;
                                }
                            }
                            // Pewarnaan edge dan node anak
                            else if (parentAndChild.getCheck() == 1 || parentAndChild.getCheck() == 2) {
                                // Iterasi semua edge suatu parentPath
                                foreach (var edge in graph.FindNode(parentAndChild.getParentPath()).Edges)
                                {
                                    if (edge.Target.ToString() == parentAndChild.getChildPath()[i]) {
                                        // Pewarnaan edge dan node bila anak salah menjadi merah
                                        if (parentAndChild.getCheck() == 1) {
                                            edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                            graph.FindNode(parentAndChild.getChildPath()[i]).Label.FontColor = Microsoft.Msagl.Drawing.Color.Red;
                                            isChanged = true;
                                        }
                                        // Pewarnaan edge dan node bila anak benar dan
                                        // semua parent hingga rootPath menjadi biru
                                        else if (parentAndChild.getCheck() == 2)
                                        {
                                            Microsoft.Msagl.Drawing.Edge currentEdge = edge;
                                            Microsoft.Msagl.Drawing.Node currentNode = edge.TargetNode;
                                            currentEdge.TargetNode.Label.FontColor = Microsoft.Msagl.Drawing.Color.DodgerBlue;
                                            // iterasi edge dan node sampai ke rootPath
                                            while (currentNode.Id != rootPath)
                                            {
                                                currentEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.DodgerBlue;
                                                currentEdge.SourceNode.Label.FontColor = Microsoft.Msagl.Drawing.Color.DodgerBlue;
                                                currentNode = currentEdge.SourceNode;
                                                foreach (Microsoft.Msagl.Drawing.Edge inedges in currentNode.InEdges)
                                                {
                                                    currentEdge = inedges;
                                                }
                                            }
                                            isChanged = true;
                                        }
                                    }
                                }
                            }

                            // Mengubah label setiap node ke nama folder/file saja
                            graph.FindNode(parentAndChild.getParentPath()).LabelText = parentAndChild.getParentName();
                            graph.FindNode(parentAndChild.getParentPath()).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(parentAndChild.getChildPath()[i]).LabelText = parentAndChild.getChildName()[i];
                            graph.FindNode(parentAndChild.getChildPath()[i]).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            // Ubah graf dengan perubahan pada saat iterasi
                            updateGraph(viewer, graph, graphPanel);
                        }
                    }
                    graphcounter++;

                    // Tambah hyperlink untuk setiap file yang ditemukan
                    foreach (string path in targetPath)
                    {
                        Krypton.Toolkit.KryptonLinkLabel Hasil = new Krypton.Toolkit.KryptonLinkLabel();
                        Hasils.Controls.Add(Hasil);
                        Hasil.Text = path;
                        Hasil.AutoSize = true;
                        Hasil.Click += new EventHandler(Hasil_Click);
                    }
                    // mematikan sempahore
                    algoRunning = false;
                    
                    Status.Text = "Penggambaran pohon selesai!";
                    DitemukanLabel.Visible = true;
                    // Time Spent
                    TimeLabel.Text = "Waktu yang dibutuhkan algoritma: " + totalTime.ToString() + " ms";
                }
            }
            else {
                // Bila semaphore nyala masuk ke sini, artinya algoritma atau pembentukan tree
                // sebelumnya belum selesai dan butuh ditunggu
                WarningLabel.Text = "! Tunggu hingga penggambaran pohon selesai";
                WarningLabel.Visible = true;
            }
        }

        private void BFS_CheckedChanged(object sender, EventArgs e) { }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e) { }

        private void DFS_CheckedChanged(object sender, EventArgs e) { }

        private void SemuaFileCheck_CheckedChanged(object sender, EventArgs e) { }

        void Hasil_Click(object sender, EventArgs e)
        {
            Krypton.Toolkit.KryptonLinkLabel Hasil = (Krypton.Toolkit.KryptonLinkLabel)sender;
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(Hasil.Text));
        }

        private void WelcomeLabel_Paint(object sender, PaintEventArgs e) { }

        private void PohonLabel_Paint(object sender, PaintEventArgs e) { }

        private void graphPanel_Paint(object sender, PaintEventArgs e) { }

        private void kryptonLabel1_Paint_1(object sender, PaintEventArgs e) { }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DelayTime.Text = trackBar1.Value.ToString() + " ms";
        }

        private void Status_Paint(object sender, PaintEventArgs e)
        {
            if (algoRunning)
            {
                Status.Text = "Menggambar pohon...";
            }
            else
            {
                Status.Text = "Selesai!";
            }
        }
    }
}