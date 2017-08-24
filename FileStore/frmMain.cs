#region Usings
using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

//import NBT(Named Binary Tag) handler

using NBT;
using NBT.IO;
using NBT.IO.Compression;
using NBT.Tags;
using NBT.Exceptions;

 #endregion
namespace FileStore
{
    public partial class frmMain : Form
    {
        NBTFile nbtFile = new NBTFile();
        string lastKey;
        string path;
        string fileSize;
        public frmMain(string _path)
        {
            path = _path;
            InitializeComponent();
            Status("Loading");
            tb_path.Text = path;
            nbtFile.Compression = getCompression();
            nbtFile.RootTagName = "File Store";
            toolStripCompression.Text = nbtFile.Compression.ToString();
            nbtFile.Load(this.path);
            ReloadList();
            Status("Loaded");
        }

        private void lblFileSize_update()
        {
            fileSize = SizeSuffix(long.Parse(new FileInfo(path).Length.ToString()));
            lblFileSize.Text = string.Format("Size:{0}", fileSize.ToString());
        }

        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        private NBTCompressionType getCompression()
        {
            nbtFile.Load(path);
            foreach (KeyValuePair<string, Tag> item in nbtFile.RootTag)
            {
                if (item.Value.GetType() == typeof(TagString))
                {
                    if (item.Key.ToString() == "CompressionType" && item.Value.Value.ToString() == "Uncompressed")
                    {
                        return NBTCompressionType.Uncompressed;
                    }
                    if (item.Key.ToString() == "CompressionType" && item.Value.Value.ToString() == "ZlibCompression")
                    {
                        return NBTCompressionType.ZlibCompression;
                    }
                    if (item.Key.ToString() == "CompressionType" && item.Value.Value.ToString() == "GZipCompression")
                    {
                        return NBTCompressionType.GZipCompression;
                    }
                }
            }
            return NBTCompressionType.Uncompressed;
        }

        private void Status(string text)
        {
            toolStripStatusLabel.Text = text;
        }

        private void btn_changePath_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "nbt|*.nbt|All|*.*";
            this.nbtFile.Save(path);
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                tb_path.Text = path;
                ReloadList();
                Status("path changed");
            }
        }


        /// <summary>
        /// reloads the datagridview
        /// </summary>
        private void ReloadList()
        {
            try
            {
                dgv_data.Rows.Clear();
                nbtFile.Load(path);
                foreach (KeyValuePair<string, Tag> item in nbtFile.RootTag)
                {
                    if (item.Value.GetType() == typeof(TagByteArray))
                    {
                        dgv_data.Rows.Add(item.Key.ToString());
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            if (nbtFile.Compression == NBTCompressionType.Uncompressed) { rb_Uncompressed.Select(); }
            if (nbtFile.Compression == NBTCompressionType.ZlibCompression) { rb_ZlibCompression.Select(); }
            if (nbtFile.Compression == NBTCompressionType.GZipCompression) { rb_GZipCompression.Select(); }
            lblFileSize_update();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nbtFile.RootTag.Remove(lastKey);
            nbtFile.Save(path);
            ReloadList();
            Status("File Removed");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All|*.*";
            DialogResult dr = openFileDialog.ShowDialog();
            string[] file = openFileDialog.FileNames;
            if (dr == DialogResult.OK)
            {
                try
                {
                    for (int i = 0;i <= file.Length - 1;i++)
                    {
                    string[] tmp = file[i].Split('\\');
                    string fileName = tmp[tmp.Length - 1];
                    byte[] Data = File.ReadAllBytes(file[i]);
                    nbtFile.RootTag.Add(fileName.ToString(), new TagByteArray(Data));
                    }
                    nbtFile.Save(path);
                    ReloadList();
                    Status("File added");
                }
                catch (NBT_InvalidArgumentException err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog.ShowDialog();
            string folder = folderBrowserDialog.SelectedPath;
            if (dr == DialogResult.OK)
            {
                Status("Exporting");
                try
                {
                    foreach (KeyValuePair<string, Tag> item in nbtFile.RootTag)
                    {
                        if (item.Value.GetType() == typeof(TagByteArray))
                        {
                            byte[] data = item.Value.Value as byte[];
                            string tofile = folder + "\\" + item.Key;
                            File.WriteAllBytes(tofile, data);
                            Status(string.Format("File exported to {0}", tofile.ToString()));
                        }
                    }
                }
                catch (Exception err)
                {
                    Status("Export Failed");
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
                }
                lblFileSize_update();
            }
            nbtFile.Save(path);
            ReloadList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Status("Saving");
            try
            {
                this.nbtFile.Save(this.path);
                Status("Saved");
            }
            catch (NBT_IOException err)
            {
                Status("Save Failed");
                MessageBox.Show("Error", err.Message, MessageBoxButtons.OK);
            }
            lblFileSize_update();
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastKey = dgv_data.CurrentRow.Cells["FileName"].Value.ToString();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Status("Shutting Down");
            nbtFile.Save(path);
            try{
                this.Dispose();
            }
            catch (Exception){ }
            Application.Exit();
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
                nbtFile.Load(path);
                tb_path.Text = path;
                ReloadList();
            }
        }

        #region radio buttons
        private void rb_Uncompressed_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.gb_compression.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Name.Equals("rb_Uncompressed") && radio.Checked)
                    {
                        nbtFile.Compression = NBTCompressionType.Uncompressed;
                        nbtFile.RootTag.Remove("CompressionType");
                        nbtFile.RootTag.Add("CompressionType", new TagString("Uncompressed"));
                        toolStripCompression.Text = nbtFile.Compression.ToString();
                        break;
                    }
                }
            }
        }

        private void rb_GZipCompression_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.gb_compression.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Name.Equals("rb_GZipCompression") && radio.Checked)
                    {
                        nbtFile.Compression = NBTCompressionType.GZipCompression;
                        nbtFile.RootTag.Remove("CompressionType");
                        nbtFile.RootTag.Add("CompressionType", new TagString("GZipCompression"));
                        toolStripCompression.Text = nbtFile.Compression.ToString();
                        break;
                    }
                }
            }
        }

        private void rb_ZlibCompression_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.gb_compression.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Name.Equals("rb_ZlibCompression") && radio.Checked)
                    {
                        nbtFile.Compression = NBTCompressionType.ZlibCompression;
                        nbtFile.RootTag.Remove("CompressionType");
                        nbtFile.RootTag.Add("CompressionType", new TagString("ZlibCompression"));
                        toolStripCompression.Text = nbtFile.Compression.ToString();
                        break;
                    }
                }
            }
        }
        #endregion

    }
}
