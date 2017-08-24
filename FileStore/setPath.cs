using System;
using System.Windows.Forms;

using NBT;
using NBT.IO;
using NBT.Tags;
using NBT.Exceptions;

namespace FileStore
{
    public partial class setPath : Form
    {
        string path;
        public setPath()
        {
            InitializeComponent();
        }

        private void btn_changePath_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                tb_path.Text = path;
                btn_select.Enabled = true;
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            ShowForm(new frmMain(path));
        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void frm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ShowForm(Form frm)
        {
            frm.Shown += new EventHandler(frm_Shown);
            frm.FormClosing += new FormClosingEventHandler(frm_FormClosing);
            frm.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "nbt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                NBTFile nbtfile = new NBTFile();
                path = saveFileDialog1.FileName;
                nbtfile.Compression = NBT.IO.Compression.NBTCompressionType.Uncompressed;
                nbtfile.RootTagName = "File Store";
                nbtfile.RootTag.Add("CompressionType", new TagString("Uncompressed"));
                nbtfile.Save(path);
                tb_path.Text = path;
                btn_select.Enabled = true;
            }
        }
    }
}
