namespace FileStore
{
    partial class setPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setPath));
            this.btn_changePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_select = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_changePath
            // 
            this.btn_changePath.Location = new System.Drawing.Point(12, 35);
            this.btn_changePath.Name = "btn_changePath";
            this.btn_changePath.Size = new System.Drawing.Size(87, 23);
            this.btn_changePath.TabIndex = 7;
            this.btn_changePath.Text = "Open";
            this.btn_changePath.UseVisualStyleBackColor = true;
            this.btn_changePath.Click += new System.EventHandler(this.btn_changePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path:";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(53, 9);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(237, 20);
            this.tb_path.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "nbt";
            this.openFileDialog1.Filter = "nbt|*.nbt|All|*.*";
            // 
            // btn_select
            // 
            this.btn_select.Enabled = false;
            this.btn_select.Location = new System.Drawing.Point(215, 35);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 8;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(119, 35);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "nbt";
            this.saveFileDialog1.Filter = "nbt|*.nbt|All|*.*";
            // 
            // setPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 66);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_changePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_changePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}