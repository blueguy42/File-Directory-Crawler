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

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            // Inisialisasi variabel
            string fileName = kryptonTextBox1.Text;
            string rootPath = FolderLabel.Text;
            Boolean findAllOccurrence = SemuaFileCheck.Checked;
            parentAndChild[] parentAndChildren = new parentAndChild[] { }; //perlu dibenerin
            int algorithm = -1; //0 for BFS, 1 for DFS
            if (BFS.Checked) {
                algorithm = 0;
            } else if (DFS.Checked) {
                algorithm = 1;
            }

            // Cek apakah sudah terisi semua
            if (fileName == "" || rootPath == "" || algorithm == -1)
            {
                WarningLabel.Visible = true;
            } 
            else
            {
                WarningLabel.Visible = false;
                PohonLabel.Visible = true;
                String[] dirPath = new string[] { };
                
                //Run Algorithm
                Algorithm.RunAlgorithm(fileName, rootPath, findAllOccurrence, algorithm, ref dirPath, ref parentAndChildren);
                
                // Debugging dirPath
                string data1 = "";

                foreach (string path in dirPath)
                {
                    data1 += path + "\n";
                }

                // Debugging parent and child node
                string data2 = "";

                foreach (parentAndChild parentAndChild in parentAndChildren)
                {
                    data2 += parentAndChild.getParentPath() + " <-> " + parentAndChild.getParentName() + "\n";
                    
                    for(int i = 0; i < parentAndChild.getChildPath().Length; i++)
                    {
                        data2 +=    "        " + 
                                    parentAndChild.getChildPath()[i] +
                                    " <-> " + 
                                    parentAndChild.getChildName()[i] +  "\n";
                    }
                }

                
                kryptonLinkLabel1.Text = dirPath[0];
                kryptonLabel4.Text = data2;
                kryptonLabel4.AutoSize = true;
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
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(kryptonLinkLabel1.Text));
        }
    }
}