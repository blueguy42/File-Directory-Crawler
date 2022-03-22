using Krypton.Toolkit;
using Folder_Crawler_Algo;

namespace Folder_Crawler
{
    public partial class Form1 : KryptonForm
    {
        // This code is taken from https://jailbreakvideo.ru/shadow-and-mouse-move-for-borderless-windows-forms-application
        // Usage: form shadow and drag
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );



        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }
        // end of taken code

        //create a viewer object 
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();   
        //create a graph object 
        Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        int graphcounter = 0;

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) => {
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

        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void FolderSelectedLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonGroup1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            FolderLabel.Text = openFileDialog1.FileName;
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog1 = new FolderBrowserDialog();
            FolderBrowserDialog1.ShowDialog();
            FolderLabel.Text = FolderBrowserDialog1.SelectedPath;
        }

        private void FolderLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonWrapLabel1_Click(object sender, EventArgs e)
        {

        }

        Boolean algoRunning = false;
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (!algoRunning) {
                // Inisialisasi variabel
                string fileName = kryptonTextBox1.Text;
                string rootPath = FolderLabel.Text;
                Boolean findAllOccurrence = SemuaFileCheck.Checked;
                treeNode[] parentAndChildren = new treeNode[] { };
                long totalTime = 0;
                int algorithm = -1; //0 for BFS, 1 for DFS
                if (BFS.Checked) {
                    algorithm = 0;
                } else if (DFS.Checked) {
                    algorithm = 1;
                }
                int waitTime = trackBar1.Value;

                // Cek apakah sudah terisi semua
                if (fileName == "" || rootPath == "" || rootPath == "Belum ada folder yang dipilih" || algorithm == -1)
                {
                    WarningLabel.Text = "! Silakan lengkapi masukan terlebih dahulu";
                    WarningLabel.Visible = true;
                }
                else
                {
                    algoRunning = true;

                    WelcomeLabel.Visible = false;
                    WarningLabel.Visible = false;
                    PohonLabel.Visible = true;
                    graphPanel.Visible = true;

                    String[] dirPath = new string[] { };
                    String[] targetPath = new string[] { };

                    //Run Algorithm
                    Algorithm.RunAlgorithm(fileName, rootPath, findAllOccurrence, algorithm, ref targetPath, ref parentAndChildren, ref totalTime);

                    // Ketemu
                    if (targetPath.Length > 0)
                    {
                        DitemukanLabel.Text = "Ketemu!";
                        DitemukanLabel.Visible = true;

                        int Y = 477;

                        foreach (string path in targetPath)
                        {
                            Krypton.Toolkit.KryptonLinkLabel Hasil = new Krypton.Toolkit.KryptonLinkLabel();
                            Hasils.Controls.Add(Hasil);
                            Hasil.Text = path;
                            Hasil.AutoSize = true;
                            Hasil.Click += new EventHandler(Hasil_Click);
                            //Hasil.Location = new Point(452, Y);
                            Y += 25;
                        }
                    }
                    else // Ga ketemu
                    {
                        DitemukanLabel.Text = "File tidak ditemukan :(";
                        DitemukanLabel.Visible = true;
                    }

                    // Time Spent
                    TimeLabel.Text = totalTime.ToString() + "ms";
                    TimeLabel.Visible = true;
                    TimeTitleLable.Visible = true;

                    string data1 = "";
                    foreach (string path in dirPath)
                    {
                        data1 += path + "\n";
                    }

                    // Debugging parent and child node
                    string data2 = "";

                    foreach (treeNode parentAndChild in parentAndChildren)
                    {
                        data2 += parentAndChild.getParentPath() + " <-> " + parentAndChild.getParentName() + "\n";

                        for (int i = 0; i < parentAndChild.getChildPath().Length; i++)
                        {
                            data2 += "        " +
                                        parentAndChild.getChildPath()[i] +
                                        " <-> " +
                                        parentAndChild.getChildName()[i] + "\n";
                        }
                    }

                    if (!(graphcounter == 0))
                    {
                        graph = null;
                        graph = new Microsoft.Msagl.Drawing.Graph("graph");
                    }

                    viewer.Visible = true;
                    viewer.Width = graphPanel.Width;
                    viewer.Height = graphPanel.Height;

                    // add rootPath node
                    graph.AddNode(rootPath);
                    graph.FindNode(rootPath).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                    graph.FindNode(rootPath).LabelText = Path.GetFileName(rootPath);
                    graph.FindNode(rootPath).Label.FontColor = Microsoft.Msagl.Drawing.Color.Black;
                    updateGraph(viewer, graph, graphPanel);
                    wait(waitTime);
                    graph.FindNode(rootPath).Label.FontColor = Microsoft.Msagl.Drawing.Color.Red;
                    updateGraph(viewer, graph, graphPanel);
                    wait(waitTime);

                    bool isChanged = true;
                    foreach (treeNode parentAndChild in parentAndChildren)
                    {
                        bool firstChild = true;
                        for (int i = 0; i < parentAndChild.getChildPath().Length; i++)
                        {
                            if (isChanged && firstChild)
                            {
                                wait(waitTime);
                            }
                            isChanged = false;

                            if (parentAndChild.getCheck() == 0)
                            {
                                firstChild = false;
                                int j = 0;
                                //Menambahkan node baru
                                if (graph.FindNode(parentAndChild.getParentPath()) == null)
                                {
                                    graph.AddEdge(parentAndChild.getParentPath(), parentAndChild.getChildPath()[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                                    graph.FindNode(parentAndChild.getParentPath()).Label.FontColor = Microsoft.Msagl.Drawing.Color.Black;
                                    graph.FindNode(parentAndChild.getChildPath()[i]).Label.FontColor = Microsoft.Msagl.Drawing.Color.Black;
                                    isChanged = true;
                                }
                                else
                                {
                                    //Menambahkan edge baru ke node yang sudah ada
                                    bool foundSameEdge = false;
                                    foreach (var edge in graph.FindNode(parentAndChild.getParentPath()).Edges)
                                    {
                                        if (edge.Target.ToString() == parentAndChild.getChildPath()[i])
                                        {
                                            foundSameEdge = true;
                                        };
                                    }

                                    if (!foundSameEdge)
                                    {
                                        graph.AddEdge(parentAndChild.getParentPath(), parentAndChild.getChildPath()[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                                        graph.FindNode(parentAndChild.getChildPath()[i]).Label.FontColor = Microsoft.Msagl.Drawing.Color.Black;
                                        isChanged = true;
                                    }
                                }
                            }
                            else if (parentAndChild.getCheck() == 1 || parentAndChild.getCheck() == 2)
                            {
                                //Mewarnai edge dengan mencari edge yang sama
                                foreach (var edge in graph.FindNode(parentAndChild.getParentPath()).Edges)
                                {
                                    if (edge.Target.ToString() == parentAndChild.getChildPath()[i])
                                    {
                                        if (parentAndChild.getCheck() == 1)
                                        {
                                            edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                                            graph.FindNode(parentAndChild.getChildPath()[i]).Label.FontColor = Microsoft.Msagl.Drawing.Color.Red;
                                            isChanged = true;
                                        }
                                        else if (parentAndChild.getCheck() == 2)
                                        {
                                            Microsoft.Msagl.Drawing.Edge currentEdge = edge;
                                            Microsoft.Msagl.Drawing.Node currentNode = edge.TargetNode;
                                            currentEdge.TargetNode.Label.FontColor = Microsoft.Msagl.Drawing.Color.DodgerBlue;
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
                                    };
                                }
                            }
                            graph.FindNode(parentAndChild.getParentPath()).LabelText = parentAndChild.getParentName();
                            graph.FindNode(parentAndChild.getParentPath()).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            graph.FindNode(parentAndChild.getChildPath()[i]).LabelText = parentAndChild.getChildName()[i];
                            graph.FindNode(parentAndChild.getChildPath()[i]).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Plaintext;
                            updateGraph(viewer, graph, graphPanel);
                        }
                    }
                    graphcounter++;

                    algoRunning = false;
                }
            } else {
                WarningLabel.Text = "! Tunggu hingga penggambaran tree selesai";
                WarningLabel.Visible = true;
            }
        }

        private void BFS_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void kryptonLabel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void DFS_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SemuaFileCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
        }

        void Hasil_Click(object sender, EventArgs e)
        {
            Krypton.Toolkit.KryptonLinkLabel Hasil = (Krypton.Toolkit.KryptonLinkLabel)sender;
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(Hasil.Text));
        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WelcomeLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PohonLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BatalButton_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DelayTime.Text = trackBar1.Value.ToString() + " ms";
        }

        private void kryptonLabel4_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}