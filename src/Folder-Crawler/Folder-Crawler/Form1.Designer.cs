namespace Folder_Crawler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.BrowseFolderButton = new Krypton.Toolkit.KryptonButton();
            this.FolderLabel = new Krypton.Toolkit.KryptonLabel();
            this.StartingTitle = new Krypton.Toolkit.KryptonLabel();
            this.InputTitle = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.SemuaFileCheck = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.BFS = new Krypton.Toolkit.KryptonRadioButton();
            this.DFS = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonWrapLabel1 = new Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.StartButton = new Krypton.Toolkit.KryptonButton();
            this.DitemukanTitle = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLinkLabel1 = new Krypton.Toolkit.KryptonLinkLabel();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 25F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 5;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Back.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Rounding = 25F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Border.Width = 5;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Back.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Rounding = 25F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Border.Width = 5;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Back.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.ColorAngle = 60F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Rounding = 25F;
            this.kryptonPalette1.ButtonStyles.ButtonCustom1.StateTracking.Border.Width = 5;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Rounding = 10F;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Rounding = 10F;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Rounding = 10F;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Rounding = 12F;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Width = 0;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateNormal.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonPalette1.PalettePaint += new System.EventHandler<Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette1_PalettePaint);
            // 
            // BrowseFolderButton
            // 
            this.BrowseFolderButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.BrowseFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseFolderButton.Location = new System.Drawing.Point(25, 235);
            this.BrowseFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseFolderButton.Name = "BrowseFolderButton";
            this.BrowseFolderButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.BrowseFolderButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.BrowseFolderButton.OverrideDefault.Back.ColorAngle = 60F;
            this.BrowseFolderButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.BrowseFolderButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.BrowseFolderButton.OverrideDefault.Border.ColorAngle = 60F;
            this.BrowseFolderButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BrowseFolderButton.OverrideDefault.Border.Rounding = 25F;
            this.BrowseFolderButton.OverrideDefault.Border.Width = 5;
            this.BrowseFolderButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.BrowseFolderButton.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.BrowseFolderButton.OverrideFocus.Back.ColorAngle = 60F;
            this.BrowseFolderButton.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.BrowseFolderButton.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.BrowseFolderButton.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.BrowseFolderButton.OverrideFocus.Border.ColorAngle = 60F;
            this.BrowseFolderButton.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BrowseFolderButton.OverrideFocus.Border.Rounding = 25F;
            this.BrowseFolderButton.OverrideFocus.Border.Width = 5;
            this.BrowseFolderButton.Palette = this.kryptonPalette1;
            this.BrowseFolderButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.BrowseFolderButton.Size = new System.Drawing.Size(188, 62);
            this.BrowseFolderButton.TabIndex = 4;
            this.BrowseFolderButton.Values.Text = "Pilih Folder...";
            this.BrowseFolderButton.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // FolderLabel
            // 
            this.FolderLabel.AutoSize = false;
            this.FolderLabel.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.FolderLabel.Location = new System.Drawing.Point(220, 251);
            this.FolderLabel.Margin = new System.Windows.Forms.Padding(4);
            this.FolderLabel.Name = "FolderLabel";
            this.FolderLabel.Palette = this.kryptonPalette1;
            this.FolderLabel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.FolderLabel.Size = new System.Drawing.Size(338, 30);
            this.FolderLabel.TabIndex = 5;
            this.FolderLabel.Values.Text = "Belum ada folder yang dipilih";
            this.FolderLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.FolderLabel_Paint);
            // 
            // StartingTitle
            // 
            this.StartingTitle.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.StartingTitle.Location = new System.Drawing.Point(25, 186);
            this.StartingTitle.Margin = new System.Windows.Forms.Padding(4);
            this.StartingTitle.Name = "StartingTitle";
            this.StartingTitle.Palette = this.kryptonPalette1;
            this.StartingTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartingTitle.Size = new System.Drawing.Size(322, 33);
            this.StartingTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartingTitle.TabIndex = 7;
            this.StartingTitle.Values.Text = "1. Pilih Direktori Mula-Mula";
            this.StartingTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // InputTitle
            // 
            this.InputTitle.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.InputTitle.Location = new System.Drawing.Point(25, 334);
            this.InputTitle.Margin = new System.Windows.Forms.Padding(4);
            this.InputTitle.Name = "InputTitle";
            this.InputTitle.Palette = this.kryptonPalette1;
            this.InputTitle.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.InputTitle.Size = new System.Drawing.Size(282, 33);
            this.InputTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputTitle.TabIndex = 9;
            this.InputTitle.Values.Text = "2. Masukkan Nama File";
            this.InputTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel2_Paint);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.CueHint.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(127)))), ((int)(((byte)(141)))));
            this.kryptonTextBox1.CueHint.CueHintText = "Tugas_Besar_Stima.pdf";
            this.kryptonTextBox1.CueHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonTextBox1.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonTextBox1.Location = new System.Drawing.Point(26, 382);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(500, 33);
            this.kryptonTextBox1.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateActive.Border.Rounding = 5F;
            this.kryptonTextBox1.StateActive.Border.Width = 0;
            this.kryptonTextBox1.TabIndex = 10;
            this.kryptonTextBox1.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // SemuaFileCheck
            // 
            this.SemuaFileCheck.Location = new System.Drawing.Point(26, 426);
            this.SemuaFileCheck.Margin = new System.Windows.Forms.Padding(4);
            this.SemuaFileCheck.Name = "SemuaFileCheck";
            this.SemuaFileCheck.Size = new System.Drawing.Size(336, 29);
            this.SemuaFileCheck.TabIndex = 12;
            this.SemuaFileCheck.Values.Text = "Cari semua file dengan nama tersebut";
            this.SemuaFileCheck.CheckedChanged += new System.EventHandler(this.SemuaFileCheck_CheckedChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.Custom1;
            this.kryptonLabel2.Location = new System.Drawing.Point(25, 495);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Palette = this.kryptonPalette1;
            this.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel2.Size = new System.Drawing.Size(307, 33);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 13;
            this.kryptonLabel2.Values.Text = "3. Pilih Metode Pencarian";
            // 
            // BFS
            // 
            this.BFS.Location = new System.Drawing.Point(25, 544);
            this.BFS.Margin = new System.Windows.Forms.Padding(4);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(238, 29);
            this.BFS.TabIndex = 14;
            this.BFS.Values.Text = "BFS (Breadth-First-Search)";
            this.BFS.CheckedChanged += new System.EventHandler(this.BFS_CheckedChanged);
            // 
            // DFS
            // 
            this.DFS.Location = new System.Drawing.Point(25, 581);
            this.DFS.Margin = new System.Windows.Forms.Padding(4);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(226, 29);
            this.DFS.TabIndex = 15;
            this.DFS.Values.Text = "DFS (Depth-First-Search)";
            this.DFS.CheckedChanged += new System.EventHandler(this.DFS_CheckedChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(1001, 64);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(467, 33);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.CornflowerBlue;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Yuk tonton pohon folder-mu bertumbuh!";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(584, 31);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(4, 775);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 25F;
            this.kryptonButton2.StateCommon.Border.Width = 0;
            this.kryptonButton2.TabIndex = 19;
            this.kryptonButton2.Values.Text = "kryptonButton2";
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(25, 115);
            this.kryptonWrapLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(508, 25);
            this.kryptonWrapLabel1.Text = "Selamat datang di Folder Crawler dari Pencari Pasangan Hidup!";
            this.kryptonWrapLabel1.Click += new System.EventHandler(this.kryptonWrapLabel1_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(18, 52);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(298, 52);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 20;
            this.kryptonLabel1.Values.Text = "Folder Crawler";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton3.Location = new System.Drawing.Point(1264, 694);
            this.kryptonButton3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonButton3.OverrideDefault.Back.ColorAngle = 60F;
            this.kryptonButton3.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonButton3.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonButton3.OverrideDefault.Border.ColorAngle = 60F;
            this.kryptonButton3.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideDefault.Border.Rounding = 25F;
            this.kryptonButton3.OverrideDefault.Border.Width = 5;
            this.kryptonButton3.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.kryptonButton3.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.kryptonButton3.OverrideFocus.Back.ColorAngle = 60F;
            this.kryptonButton3.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton3.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.kryptonButton3.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.kryptonButton3.OverrideFocus.Border.ColorAngle = 60F;
            this.kryptonButton3.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideFocus.Border.Rounding = 25F;
            this.kryptonButton3.OverrideFocus.Border.Width = 5;
            this.kryptonButton3.Palette = this.kryptonPalette1;
            this.kryptonButton3.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonButton3.Size = new System.Drawing.Size(285, 62);
            this.kryptonButton3.TabIndex = 21;
            this.kryptonButton3.Values.Text = "Batalkan Pencarian";
            // 
            // StartButton
            // 
            this.StartButton.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Location = new System.Drawing.Point(26, 694);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.OverrideDefault.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.StartButton.OverrideDefault.Back.ColorAngle = 60F;
            this.StartButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.StartButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.StartButton.OverrideDefault.Border.ColorAngle = 60F;
            this.StartButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StartButton.OverrideDefault.Border.Rounding = 25F;
            this.StartButton.OverrideDefault.Border.Width = 5;
            this.StartButton.OverrideFocus.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.StartButton.OverrideFocus.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.OverrideFocus.Back.ColorAngle = 60F;
            this.StartButton.OverrideFocus.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StartButton.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.StartButton.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(2)))));
            this.StartButton.OverrideFocus.Border.ColorAngle = 60F;
            this.StartButton.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StartButton.OverrideFocus.Border.Rounding = 25F;
            this.StartButton.OverrideFocus.Border.Width = 5;
            this.StartButton.Palette = this.kryptonPalette1;
            this.StartButton.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartButton.Size = new System.Drawing.Size(312, 62);
            this.StartButton.StateCommon.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.StateCommon.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.StartButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StartButton.StateCommon.Border.Width = 0;
            this.StartButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StartButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.StatePressed.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.StartButton.StatePressed.Back.Color2 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.StateTracking.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.StartButton.StateTracking.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.StartButton.TabIndex = 23;
            this.StartButton.Values.Text = "Mulai Pencarian!";
            this.StartButton.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // DitemukanTitle
            // 
            this.DitemukanTitle.Location = new System.Drawing.Point(629, 495);
            this.DitemukanTitle.Margin = new System.Windows.Forms.Padding(4);
            this.DitemukanTitle.Name = "DitemukanTitle";
            this.DitemukanTitle.Size = new System.Drawing.Size(193, 33);
            this.DitemukanTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DitemukanTitle.TabIndex = 25;
            this.DitemukanTitle.Values.Text = "File Ditemukan!";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(755, 197);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(129, 29);
            this.kryptonLabel4.TabIndex = 27;
            this.kryptonLabel4.Values.Text = "kryptonLabel4";
            this.kryptonLabel4.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
            // 
            // kryptonLinkLabel1
            // 
            this.kryptonLinkLabel1.Location = new System.Drawing.Point(789, 286);
            this.kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            this.kryptonLinkLabel1.Size = new System.Drawing.Size(162, 29);
            this.kryptonLinkLabel1.TabIndex = 29;
            this.kryptonLinkLabel1.Values.Text = "kryptonLinkLabel1";
            this.kryptonLinkLabel1.LinkClicked += new System.EventHandler(this.kryptonLinkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1572, 830);
            this.Controls.Add(this.kryptonLinkLabel1);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.DitemukanTitle);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonWrapLabel1);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.BFS);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.SemuaFileCheck);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.InputTitle);
            this.Controls.Add(this.StartingTitle);
            this.Controls.Add(this.FolderLabel);
            this.Controls.Add(this.BrowseFolderButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1594, 886);
            this.MinimumSize = new System.Drawing.Size(1594, 886);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Crawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonButton BrowseFolderButton;
        private Krypton.Toolkit.KryptonLabel FolderLabel;
        private Krypton.Toolkit.KryptonLabel StartingTitle;
        private Krypton.Toolkit.KryptonLabel InputTitle;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonCheckBox SemuaFileCheck;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonRadioButton BFS;
        private Krypton.Toolkit.KryptonRadioButton DFS;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private FolderBrowserDialog folderBrowserDialog1;
        private Krypton.Toolkit.KryptonButton StartButton;
        private Krypton.Toolkit.KryptonLabel DitemukanTitle;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
    }
}