namespace FileStore
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.btnNew = new System.Windows.Forms.Button();
            this.gb_compression = new System.Windows.Forms.GroupBox();
            this.rb_GZipCompression = new System.Windows.Forms.RadioButton();
            this.rb_ZlibCompression = new System.Windows.Forms.RadioButton();
            this.rb_Uncompressed = new System.Windows.Forms.RadioButton();
            this.btn_changePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripCompression = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SettingsTab.SuspendLayout();
            this.gb_compression.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 240);
            this.tabControl1.TabIndex = 3;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.lblFileSize);
            this.MainTab.Controls.Add(this.btn_quit);
            this.MainTab.Controls.Add(this.btn_Delete);
            this.MainTab.Controls.Add(this.btn_save);
            this.MainTab.Controls.Add(this.btnGet);
            this.MainTab.Controls.Add(this.btnAdd);
            this.MainTab.Controls.Add(this.groupBox1);
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(426, 214);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.BackColor = System.Drawing.Color.Transparent;
            this.lblFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.Location = new System.Drawing.Point(8, 185);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(44, 20);
            this.lblFileSize.TabIndex = 14;
            this.lblFileSize.Text = "Size:";
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(8, 141);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 13;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(8, 112);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Remove";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(8, 83);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(8, 54);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_data);
            this.groupBox1.Location = new System.Drawing.Point(190, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.AllowUserToDeleteRows = false;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName});
            this.dgv_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_data.Location = new System.Drawing.Point(3, 16);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.ReadOnly = true;
            this.dgv_data.Size = new System.Drawing.Size(224, 183);
            this.dgv_data.TabIndex = 0;
            this.dgv_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellClick);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.FillWeight = 78.17259F;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.btnNew);
            this.SettingsTab.Controls.Add(this.gb_compression);
            this.SettingsTab.Controls.Add(this.btn_changePath);
            this.SettingsTab.Controls.Add(this.label1);
            this.SettingsTab.Controls.Add(this.tb_path);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(426, 214);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(104, 46);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gb_compression
            // 
            this.gb_compression.Controls.Add(this.rb_GZipCompression);
            this.gb_compression.Controls.Add(this.rb_ZlibCompression);
            this.gb_compression.Controls.Add(this.rb_Uncompressed);
            this.gb_compression.Location = new System.Drawing.Point(11, 98);
            this.gb_compression.Name = "gb_compression";
            this.gb_compression.Size = new System.Drawing.Size(120, 90);
            this.gb_compression.TabIndex = 8;
            this.gb_compression.TabStop = false;
            this.gb_compression.Text = "Compression";
            // 
            // rb_GZipCompression
            // 
            this.rb_GZipCompression.AutoSize = true;
            this.rb_GZipCompression.Location = new System.Drawing.Point(6, 65);
            this.rb_GZipCompression.Name = "rb_GZipCompression";
            this.rb_GZipCompression.Size = new System.Drawing.Size(108, 17);
            this.rb_GZipCompression.TabIndex = 6;
            this.rb_GZipCompression.TabStop = true;
            this.rb_GZipCompression.Text = "GZipCompression";
            this.rb_GZipCompression.UseVisualStyleBackColor = true;
            this.rb_GZipCompression.CheckedChanged += new System.EventHandler(this.rb_GZipCompression_CheckedChanged);
            // 
            // rb_ZlibCompression
            // 
            this.rb_ZlibCompression.AutoSize = true;
            this.rb_ZlibCompression.Location = new System.Drawing.Point(6, 42);
            this.rb_ZlibCompression.Name = "rb_ZlibCompression";
            this.rb_ZlibCompression.Size = new System.Drawing.Size(102, 17);
            this.rb_ZlibCompression.TabIndex = 7;
            this.rb_ZlibCompression.TabStop = true;
            this.rb_ZlibCompression.Text = "ZlibCompression";
            this.rb_ZlibCompression.UseVisualStyleBackColor = true;
            this.rb_ZlibCompression.CheckedChanged += new System.EventHandler(this.rb_ZlibCompression_CheckedChanged);
            // 
            // rb_Uncompressed
            // 
            this.rb_Uncompressed.AutoSize = true;
            this.rb_Uncompressed.Location = new System.Drawing.Point(6, 19);
            this.rb_Uncompressed.Name = "rb_Uncompressed";
            this.rb_Uncompressed.Size = new System.Drawing.Size(96, 17);
            this.rb_Uncompressed.TabIndex = 5;
            this.rb_Uncompressed.TabStop = true;
            this.rb_Uncompressed.Text = "Uncompressed";
            this.rb_Uncompressed.UseVisualStyleBackColor = true;
            this.rb_Uncompressed.CheckedChanged += new System.EventHandler(this.rb_Uncompressed_CheckedChanged);
            // 
            // btn_changePath
            // 
            this.btn_changePath.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_changePath.Location = new System.Drawing.Point(11, 46);
            this.btn_changePath.Name = "btn_changePath";
            this.btn_changePath.Size = new System.Drawing.Size(87, 23);
            this.btn_changePath.TabIndex = 4;
            this.btn_changePath.Text = "Change Path";
            this.btn_changePath.UseVisualStyleBackColor = true;
            this.btn_changePath.Click += new System.EventHandler(this.btn_changePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path:";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(52, 20);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(365, 20);
            this.tb_path.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "nbt";
            this.openFileDialog.Filter = "All|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCompression,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 240);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(434, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "stausStrip";
            // 
            // toolStripCompression
            // 
            this.toolStripCompression.Name = "toolStripCompression";
            this.toolStripCompression.Size = new System.Drawing.Size(86, 17);
            this.toolStripCompression.Text = "Uncompressed";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel.Text = "loaded";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "nbt";
            this.saveFileDialog1.Filter = "nbt|*.nbt|All|*.*";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Store";
            this.tabControl1.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.gb_compression.ResumeLayout(false);
            this.gb_compression.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_changePath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.RadioButton rb_ZlibCompression;
        private System.Windows.Forms.RadioButton rb_GZipCompression;
        private System.Windows.Forms.RadioButton rb_Uncompressed;
        private System.Windows.Forms.GroupBox gb_compression;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCompression;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

