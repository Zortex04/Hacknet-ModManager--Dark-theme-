namespace HacknetModManager {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.minimizeButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.tlpPlay = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlayUnmodded = new System.Windows.Forms.Button();
            this.btnPlayPathfinder = new System.Windows.Forms.Button();
            this.lblTitleVersion = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateMod = new System.Windows.Forms.Button();
            this.btnEditMod = new System.Windows.Forms.Button();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.clbMods = new System.Windows.Forms.CheckedListBox();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnDisableAll = new System.Windows.Forms.Button();
            this.btnEnableAll = new System.Windows.Forms.Button();
            this.btnOpenModFolder = new System.Windows.Forms.Button();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tlpPlay.SuspendLayout();
            this.tlpSide.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.AutoSize = true;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(666, -4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(21, 23);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "_";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(686, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tlpPlay
            // 
            this.tlpPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPlay.ColumnCount = 2;
            this.tlpPlay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpPlay.Controls.Add(this.btnPlayUnmodded, 0, 0);
            this.tlpPlay.Controls.Add(this.btnPlayPathfinder, 1, 0);
            this.tlpPlay.Location = new System.Drawing.Point(6, 480);
            this.tlpPlay.Margin = new System.Windows.Forms.Padding(4);
            this.tlpPlay.Name = "tlpPlay";
            this.tlpPlay.RowCount = 1;
            this.tlpPlay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlay.Size = new System.Drawing.Size(430, 38);
            this.tlpPlay.TabIndex = 2;
            // 
            // btnPlayUnmodded
            // 
            this.btnPlayUnmodded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnPlayUnmodded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayUnmodded.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnPlayUnmodded.FlatAppearance.BorderSize = 0;
            this.btnPlayUnmodded.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnPlayUnmodded.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnPlayUnmodded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayUnmodded.ForeColor = System.Drawing.Color.White;
            this.btnPlayUnmodded.Location = new System.Drawing.Point(4, 4);
            this.btnPlayUnmodded.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayUnmodded.Name = "btnPlayUnmodded";
            this.btnPlayUnmodded.Size = new System.Drawing.Size(207, 30);
            this.btnPlayUnmodded.TabIndex = 1;
            this.btnPlayUnmodded.Text = "Play (Unmodded)";
            this.btnPlayUnmodded.UseVisualStyleBackColor = false;
            this.btnPlayUnmodded.Click += new System.EventHandler(this.btnPlayUnmodded_Click);
            // 
            // btnPlayPathfinder
            // 
            this.btnPlayPathfinder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnPlayPathfinder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayPathfinder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnPlayPathfinder.FlatAppearance.BorderSize = 0;
            this.btnPlayPathfinder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnPlayPathfinder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnPlayPathfinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPathfinder.ForeColor = System.Drawing.Color.White;
            this.btnPlayPathfinder.Location = new System.Drawing.Point(219, 4);
            this.btnPlayPathfinder.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayPathfinder.Name = "btnPlayPathfinder";
            this.btnPlayPathfinder.Size = new System.Drawing.Size(207, 30);
            this.btnPlayPathfinder.TabIndex = 0;
            this.btnPlayPathfinder.Text = "Play (Pathfinder)";
            this.btnPlayPathfinder.UseVisualStyleBackColor = false;
            this.btnPlayPathfinder.Click += new System.EventHandler(this.btnPlayPathfinder_Click);
            // 
            // lblTitleVersion
            // 
            this.lblTitleVersion.AutoEllipsis = true;
            this.lblTitleVersion.AutoSize = true;
            this.lblTitleVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleVersion.ForeColor = System.Drawing.Color.White;
            this.lblTitleVersion.Location = new System.Drawing.Point(21, 11);
            this.lblTitleVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleVersion.MaximumSize = new System.Drawing.Size(0, 21);
            this.lblTitleVersion.Name = "lblTitleVersion";
            this.lblTitleVersion.Size = new System.Drawing.Size(40, 21);
            this.lblTitleVersion.TabIndex = 3;
            this.lblTitleVersion.Text = "N/A";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(25, 32);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.MaximumSize = new System.Drawing.Size(0, 34);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 18);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "N/A";
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoEllipsis = true;
            this.lblAuthors.ForeColor = System.Drawing.Color.White;
            this.lblAuthors.Location = new System.Drawing.Point(25, 47);
            this.lblAuthors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthors.MaximumSize = new System.Drawing.Size(0, 34);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(0, 19);
            this.lblAuthors.TabIndex = 5;
            this.lblAuthors.Text = "N/A";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(8, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(267, 396);
            this.textBox1.TabIndex = 6;
            // 
            // tlpSide
            // 
            this.tlpSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tlpSide.ColumnCount = 1;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSide.Controls.Add(this.btnCreateMod, 0, 1);
            this.tlpSide.Controls.Add(this.btnEditMod, 0, 2);
            this.tlpSide.Controls.Add(this.btnHomepage, 0, 0);
            this.tlpSide.Location = new System.Drawing.Point(283, 80);
            this.tlpSide.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 3;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.Size = new System.Drawing.Size(153, 116);
            this.tlpSide.TabIndex = 7;
            // 
            // btnCreateMod
            // 
            this.btnCreateMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCreateMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCreateMod.FlatAppearance.BorderSize = 0;
            this.btnCreateMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnCreateMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnCreateMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMod.ForeColor = System.Drawing.Color.White;
            this.btnCreateMod.Location = new System.Drawing.Point(4, 42);
            this.btnCreateMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateMod.Name = "btnCreateMod";
            this.btnCreateMod.Size = new System.Drawing.Size(145, 30);
            this.btnCreateMod.TabIndex = 2;
            this.btnCreateMod.Text = "Create";
            this.btnCreateMod.UseVisualStyleBackColor = false;
            // 
            // btnEditMod
            // 
            this.btnEditMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnEditMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnEditMod.FlatAppearance.BorderSize = 0;
            this.btnEditMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnEditMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnEditMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMod.ForeColor = System.Drawing.Color.White;
            this.btnEditMod.Location = new System.Drawing.Point(4, 80);
            this.btnEditMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMod.Name = "btnEditMod";
            this.btnEditMod.Size = new System.Drawing.Size(145, 32);
            this.btnEditMod.TabIndex = 3;
            this.btnEditMod.Text = "Edit";
            this.btnEditMod.UseVisualStyleBackColor = false;
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnHomepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHomepage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnHomepage.FlatAppearance.BorderSize = 0;
            this.btnHomepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnHomepage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomepage.ForeColor = System.Drawing.Color.White;
            this.btnHomepage.Location = new System.Drawing.Point(4, 4);
            this.btnHomepage.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(145, 30);
            this.btnHomepage.TabIndex = 4;
            this.btnHomepage.Text = "Visit Homepage";
            this.btnHomepage.UseVisualStyleBackColor = false;
            // 
            // clbMods
            // 
            this.clbMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.clbMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbMods.ForeColor = System.Drawing.Color.White;
            this.clbMods.FormattingEnabled = true;
            this.clbMods.IntegralHeight = false;
            this.clbMods.Location = new System.Drawing.Point(6, 51);
            this.clbMods.Margin = new System.Windows.Forms.Padding(4);
            this.clbMods.Name = "clbMods";
            this.clbMods.Size = new System.Drawing.Size(246, 421);
            this.clbMods.TabIndex = 2;
            // 
            // tlpTop
            // 
            this.tlpTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tlpTop.ColumnCount = 3;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpTop.Controls.Add(this.btnDisableAll, 1, 0);
            this.tlpTop.Controls.Add(this.btnEnableAll, 0, 0);
            this.tlpTop.Controls.Add(this.btnOpenModFolder, 2, 0);
            this.tlpTop.Location = new System.Drawing.Point(4, 5);
            this.tlpTop.Margin = new System.Windows.Forms.Padding(4);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(248, 38);
            this.tlpTop.TabIndex = 0;
            // 
            // btnDisableAll
            // 
            this.btnDisableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnDisableAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisableAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnDisableAll.FlatAppearance.BorderSize = 0;
            this.btnDisableAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnDisableAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnDisableAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableAll.ForeColor = System.Drawing.Color.White;
            this.btnDisableAll.Location = new System.Drawing.Point(103, 4);
            this.btnDisableAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisableAll.Name = "btnDisableAll";
            this.btnDisableAll.Size = new System.Drawing.Size(92, 30);
            this.btnDisableAll.TabIndex = 4;
            this.btnDisableAll.Text = "Disable All";
            this.btnDisableAll.UseVisualStyleBackColor = false;
            this.btnDisableAll.Click += new System.EventHandler(this.btnDisableAll_Click);
            // 
            // btnEnableAll
            // 
            this.btnEnableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnEnableAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnableAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnEnableAll.FlatAppearance.BorderSize = 0;
            this.btnEnableAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnEnableAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnEnableAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableAll.ForeColor = System.Drawing.Color.White;
            this.btnEnableAll.Location = new System.Drawing.Point(4, 4);
            this.btnEnableAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnableAll.Name = "btnEnableAll";
            this.btnEnableAll.Size = new System.Drawing.Size(91, 30);
            this.btnEnableAll.TabIndex = 3;
            this.btnEnableAll.Text = "Enable All";
            this.btnEnableAll.UseVisualStyleBackColor = false;
            this.btnEnableAll.Click += new System.EventHandler(this.btnEnableAll_Click);
            // 
            // btnOpenModFolder
            // 
            this.btnOpenModFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnOpenModFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenModFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnOpenModFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenModFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnOpenModFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnOpenModFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenModFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenModFolder.Image = global::HacknetModManager.Properties.Resources.folder_go;
            this.btnOpenModFolder.Location = new System.Drawing.Point(203, 4);
            this.btnOpenModFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenModFolder.Name = "btnOpenModFolder";
            this.btnOpenModFolder.Size = new System.Drawing.Size(41, 30);
            this.btnOpenModFolder.TabIndex = 5;
            this.btnOpenModFolder.UseVisualStyleBackColor = false;
            this.btnOpenModFolder.Click += new System.EventHandler(this.btnOpenModFolder_Click);
            // 
            // tlpBottom
            // 
            this.tlpBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBottom.ColumnCount = 3;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpBottom.Controls.Add(this.btnRemove, 0, 0);
            this.tlpBottom.Controls.Add(this.btnInstall, 0, 0);
            this.tlpBottom.Controls.Add(this.btnRefresh, 2, 0);
            this.tlpBottom.Location = new System.Drawing.Point(4, 476);
            this.tlpBottom.Margin = new System.Windows.Forms.Padding(4);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 1;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Size = new System.Drawing.Size(248, 38);
            this.tlpBottom.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(107, 4);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 30);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.ForeColor = System.Drawing.Color.White;
            this.btnInstall.Location = new System.Drawing.Point(4, 4);
            this.btnInstall.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(95, 30);
            this.btnInstall.TabIndex = 3;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::HacknetModManager.Properties.Resources.arrow_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(210, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.Location = new System.Drawing.Point(256, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 599);
            this.panel2.TabIndex = 8;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelRight.Controls.Add(this.textBox1);
            this.panelRight.Controls.Add(this.lblTitleVersion);
            this.panelRight.Controls.Add(this.lblDescription);
            this.panelRight.Controls.Add(this.lblAuthors);
            this.panelRight.Controls.Add(this.tlpPlay);
            this.panelRight.Controls.Add(this.tlpSide);
            this.panelRight.Location = new System.Drawing.Point(263, 23);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(473, 554);
            this.panelRight.TabIndex = 9;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelLeft.Controls.Add(this.clbMods);
            this.panelLeft.Controls.Add(this.tlpTop);
            this.panelLeft.Controls.Add(this.tlpBottom);
            this.panelLeft.Location = new System.Drawing.Point(0, 23);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(257, 534);
            this.panelLeft.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(707, 550);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(574, 47);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacknet Mod Manager";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tlpPlay.ResumeLayout(false);
            this.tlpSide.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpPlay;
        private System.Windows.Forms.Button btnPlayUnmodded;
        private System.Windows.Forms.Button btnPlayPathfinder;
        private System.Windows.Forms.Label lblTitleVersion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.Button btnCreateMod;
        private System.Windows.Forms.Button btnEditMod;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.CheckedListBox clbMods;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Button btnDisableAll;
        private System.Windows.Forms.Button btnEnableAll;
        private System.Windows.Forms.Button btnOpenModFolder;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
    }
}

