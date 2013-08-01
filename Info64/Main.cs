using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info64
{
    public partial class Main : Form
    {
        private static int i;
        private static bool error = false;
        private int rn;
        private char man;
        private string cid;
        private static byte[] regions =
        {
            0x00, 0x20, 0x21, 0x36, 0x38, 0x41,
            0x44, 0x45, 0x46, 0x49, 0x4A, 0x50,
            0x53, 0x55, 0x58, 0x59, 0x70
        };

        private static string getRegion(byte id)
        {
            switch (id)
            {
                default:   return "Unknown";

                case 0x00: return "Demo";

                case 0x20: return "Europe";

                case 0x21: return "Europe";

                case 0x36: return "Beta";

                case 0x38: return "Europe";

                case 0x41: return "Japan/USA";

                case 0x44: return "Germany";

                case 0x45: return "USA";

                case 0x46: return "France";

                case 0x49: return "Italy";

                case 0x4A: return "Japan";

                case 0x50: return "Europe";

                case 0x53: return "Spain";

                case 0x55: return "Australia";

                case 0x58: return "Europe";

                case 0x59: return "Australia";

                case 0x70: return "Europe";
            }
        }

        private void getMD5(FileStream fs)
        {
            var md5 = MD5.Create();
            ROM_Properties_MD5.Text = "MD5 Hash: " + BitConverter.ToString(md5.ComputeHash(fs)).Replace("-", "");
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            new Credits().ShowDialog();
        }

        private void LoadROM_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadROM = new OpenFileDialog();
            loadROM.Title = "Load a Nintendo 64 ROM";
            loadROM.Filter = "Nintendo 64 ROM|*.z64; *.n64; *.v64";
            if (loadROM.ShowDialog() == DialogResult.OK)
            {
                ROM_Properties_SetRename.Checked = ROM_Properties_SetChangeRegion.Checked = ROM_Properties_SetChangeManufacturer.Checked = ROM_Properties_SetChangeCartID.Checked = false;
                string ext = Path.GetExtension(loadROM.FileName);
                FileStream fs = new FileStream(loadROM.FileName, FileMode.Open, FileAccess.ReadWrite);
                BinaryReader br = new BinaryReader(fs);
                BinaryWriter bw = new BinaryWriter(fs);

                /* Get Byte Order */
                ROM_Properties_Type.Text = "Type: ";
                int[] header = new int[4];
                for (i = 0; i <= 3; i++)
                {
                    fs.Seek(i, SeekOrigin.Begin);
                    header[i] = br.ReadByte();
                }
                int[] header_z64 = { 0x80, 0x37, 0x12, 0x40 };
                int[] header_le_n64 = { 0x40, 0x12, 0x37, 0x80 };
                int[] header_ws_n64 = { 0x12, 0x40, 0x80, 0x37 };
                int[] header_v64 = { 0x37, 0x80, 0x40, 0x12 };
                string new_ext = ext;
                if (header.SequenceEqual(header_z64) == true)
                {
                    ROM_Properties_Type.Text += "Big Endian";
                    if (ext != ".z64") new_ext = ".z64";
                }
                else if (header.SequenceEqual(header_le_n64) || header.SequenceEqual(header_ws_n64))
                {
                    ROM_Properties_Type.Text += (header.SequenceEqual(header_le_n64) ? "Little Endian" : "Wordswapped");
                    if (ext != ".n64") new_ext = ".n64";
                }
                else if (header.SequenceEqual(header_v64))
                {
                    ROM_Properties_Type.Text += "Byteswapped";
                    if (ext != ".v64") new_ext = ".v64";
                }
                else
                {
                    br.Close();
                    bw.Close();
                    fs.Close();
                    MessageBox.Show("ROM Corrupted!", "Error!");
                    return;
                }

                /* Check correct extension */
                if (new_ext != ext)
                {
                    MessageBox.Show("The ROM's extension is wrong!\nIt will now be changed from " + ext.Replace(".", null).ToUpper() + " to " + new_ext.Replace(".", null).ToUpper(), "Error!");
                    ROMFile.Text = Path.ChangeExtension(loadROM.FileName, new_ext);
                    br.Close();
                    bw.Close();
                    fs.Close();
                    File.Move(loadROM.FileName, ROMFile.Text);
                    loadROM.FileName = ROMFile.Text;
                    fs = new FileStream(loadROM.FileName, FileMode.Open, FileAccess.ReadWrite);
                    br = new BinaryReader(fs);
                    bw = new BinaryWriter(fs);
                    MessageBox.Show("Done!");
                }
                else new_ext = default(string);

                ROMFile.Text = loadROM.FileName;

                /* Get Name */
                ROM_Properties_Name.Text = "Name: ";
                for (i = 0x20; i <= 0x32; i++)
                {
                    fs.Seek(i, SeekOrigin.Begin);
                    ROM_Properties_Name.Text += br.ReadChar();
                }

                /* Get Region */
                fs.Seek(0x3E, SeekOrigin.Begin);
                byte reg = br.ReadByte();
                rn = Array.IndexOf(regions, reg);
                ROM_Properties_Region.Text = "Region: " + getRegion(reg) + " (0x" + reg.ToString("X") + ")";

                /* Get Manufacturer */
                fs.Seek(0x3B, SeekOrigin.Begin);
                man = br.ReadChar();
                ROM_Properties_Manufacturer.Text = "Manufacturer: " + (man == 'N' ? "Nintendo" : "Unknown") + " (" + man + ")";

                /* Get Cartridge's ID */
                ROM_Properties_CartID.Text = "Cartridge ID: ";
                for (i = 0x3C; i < 0x3E; i++)
                {
                    fs.Seek(i, SeekOrigin.Begin);
                    cid += br.ReadChar();
                }
                ROM_Properties_CartID.Text += cid;

                getMD5(fs); // Calculate MD5

                /* Get CRC1 */
                int[] data = new int[4];
                int a = 0;
                for (i = 0x10; i <= 0x13; i++)
                {
                    fs.Seek(i, SeekOrigin.Begin);
                    data[a] = br.ReadByte();
                    a++;
                }
                ROM_Properties_CRC1.Text = "CRC1: 0x" + (data[0] << 24 | data[1] << 16 | data[2] << 8 | data[3]).ToString("X");

                /* Get CRC2 */
                a = 0;
                for (i = 0x14; i <= 0x17; i++)
                {
                    fs.Seek(i, SeekOrigin.Begin);
                    data[a] = br.ReadByte();
                    a++;
                }
                ROM_Properties_CRC2.Text = "CRC2: 0x" + (data[0] << 24 | data[1] << 16 | data[2] << 8 | data[3]).ToString("X");

                /* Get Version */
                a = 0;
                for (i = 0x0C; i <= 0x0F; i++)
                {
                    fs.Seek(i, SeekOrigin.Begin);
                    data[a] = br.ReadByte();
                    a++;
                }
                ROM_Properties_Version.Text = "Version: 0x" + (data[0] << 24 | data[1] << 16 | data[2] << 8 | data[3]).ToString("X");
                a = default(int);

                /* Get ROM's size */
                ROM_Properties_Size.Text = "Size: " + fs.Length + " bytes";

                ROM_Properties.Enabled = ROM_Properties_Save.Enabled = TestROM.Enabled = true;
                br.Close();
                bw.Close();
                fs.Close();
            }
        }

        private void ROM_Properties_SetRename_CheckedChanged(object sender, EventArgs e)
        {
            ROM_Properties_Rename.Text = null;
            ROM_Properties_Rename.Enabled = ROM_Properties_SetRename.Checked;
        }

        private void ROM_Properties_SetChangeRegion_CheckedChanged(object sender, EventArgs e)
        {
            ROM_Properties_ChangeRegion.SelectedIndex = -1;
            ROM_Properties_ChangeRegion.Enabled = ROM_Properties_SetChangeRegion.Checked;
        }

        private void ROM_Properties_SetChangeManufacturer_CheckedChanged(object sender, EventArgs e)
        {
            ROM_Properties_ChangeManufacturer.Text = null;
            ROM_Properties_ChangeManufacturer.Enabled = ROM_Properties_SetChangeManufacturer.Checked;
        }

        private void ROM_Properties_SetChangeCartID_CheckedChanged(object sender, EventArgs e)
        {
            ROM_Properties_ChangeCartID.Text = null;
            ROM_Properties_ChangeCartID.Enabled = ROM_Properties_SetChangeCartID.Checked;
        }

        private void ROM_Properties_Save_Click(object sender, EventArgs e)
        {
            if (ROM_Properties_SetRename.Checked || ROM_Properties_SetChangeRegion.Checked || ROM_Properties_SetChangeManufacturer.Checked || ROM_Properties_SetChangeCartID.Checked)
            {
                if (!File.Exists(ROMFile.Text + ".bak")) File.Copy(ROMFile.Text, ROMFile.Text + ".bak");
                FileStream fs = new FileStream(ROMFile.Text, FileMode.Open, FileAccess.ReadWrite);
                BinaryReader br = new BinaryReader(fs);
                BinaryWriter bw = new BinaryWriter(fs);

                /* Rename */
                if (ROM_Properties_SetRename.Checked)
                {
                    string old_name = ROM_Properties_Name.Text.Replace("Name: ", null);
                    if (ROM_Properties_Rename.Text != old_name && ROM_Properties_Rename.Text != "")
                    {
                        bw.Seek(0x20, SeekOrigin.Begin);
                        foreach (byte c in ROM_Properties_Rename.Text) bw.Write(c);
                        for (i = 0; i < 20 - ROM_Properties_Rename.Text.Length; i++) bw.Write((byte)0x20);
                        ROM_Properties_Name.Text = "Name: " + ROM_Properties_Rename.Text;
                    }
                    ROM_Properties_Rename.Text = null;
                    ROM_Properties_SetRename.Checked = false;
                }

                /* Change Region */
                if (ROM_Properties_SetChangeRegion.Checked)
                {
                    if (ROM_Properties_ChangeRegion.SelectedIndex != rn && ROM_Properties_ChangeRegion.SelectedIndex != -1)
                    {
                        rn = ROM_Properties_ChangeRegion.SelectedIndex;
                        byte reg = regions[rn];
                        bw.Seek(0x3E, SeekOrigin.Begin);
                        bw.Write(reg);
                        ROM_Properties_Region.Text = "Region: " + getRegion(reg) + " (0x" + reg.ToString("X") + ")";
                    }
                    ROM_Properties_ChangeRegion.SelectedIndex = -1;
                    ROM_Properties_SetChangeRegion.Checked = false;
                }

                /* Change Manufacturer */
                if (ROM_Properties_SetChangeManufacturer.Checked)
                {
                    if (ROM_Properties_ChangeManufacturer.Text != "" && ROM_Properties_ChangeManufacturer.Text.ToCharArray()[0] != man)
                    {
                        man = ROM_Properties_ChangeManufacturer.Text.ToCharArray()[0];
                        bw.Seek(0x3B, SeekOrigin.Begin);
                        bw.Write(man);
                        ROM_Properties_Manufacturer.Text = "Manufacturer: " + (ROM_Properties_ChangeManufacturer.Text == "N" ? "Nintendo" : "Unknown") + " (" + ROM_Properties_ChangeManufacturer.Text + ")";
                    }
                    ROM_Properties_ChangeManufacturer.Text = null;
                    ROM_Properties_SetChangeManufacturer.Checked = false;
                }

                /* Change Cartridge's ID */
                if (ROM_Properties_SetChangeCartID.Checked)
                {
                    if (ROM_Properties_ChangeCartID.Text != cid && ROM_Properties_ChangeCartID.Text != "")
                    {
                        cid = ROM_Properties_ChangeCartID.Text;
                        bw.Seek(0x3C, SeekOrigin.Begin);
                        foreach (byte c in ROM_Properties_ChangeCartID.Text) bw.Write(c);
                        for (i = 0; i <= 2 - ROM_Properties_ChangeCartID.Text.Length; i++) bw.Write((byte)0x20);
                        ROM_Properties_CartID.Text = "Cartridge ID: " + ROM_Properties_ChangeCartID.Text;
                    }
                    ROM_Properties_ChangeCartID.Text = null;
                    ROM_Properties_SetChangeCartID.Checked = false;
                }

                getMD5(fs); // Calculate MD5

                br.Close();
                bw.Close();
                fs.Close();
            }
            else error = true;

            if (error) MessageBox.Show("Nothing to change!", "Error!");
            else MessageBox.Show("Settings saved!", "Done!");
        }

        private void TestROM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ROMFile.Text);
        }
    }
}
