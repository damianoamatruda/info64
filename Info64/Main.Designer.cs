namespace Info64
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ROM_Properties = new System.Windows.Forms.GroupBox();
            this.ROM_Properties_ChangeCartID = new System.Windows.Forms.TextBox();
            this.ROM_Properties_ChangeManufacturer = new System.Windows.Forms.TextBox();
            this.ROM_Properties_SetChangeCartID = new System.Windows.Forms.CheckBox();
            this.ROM_Properties_SetChangeManufacturer = new System.Windows.Forms.CheckBox();
            this.ROM_Properties_ChangeRegion = new System.Windows.Forms.ComboBox();
            this.ROM_Properties_SetChangeRegion = new System.Windows.Forms.CheckBox();
            this.ROM_Properties_Version = new System.Windows.Forms.Label();
            this.ROM_Properties_CRC2 = new System.Windows.Forms.Label();
            this.ROM_Properties_CRC1 = new System.Windows.Forms.Label();
            this.ROM_Properties_MD5 = new System.Windows.Forms.Label();
            this.ROM_Properties_CartID = new System.Windows.Forms.Label();
            this.ROM_Properties_Manufacturer = new System.Windows.Forms.Label();
            this.ROM_Properties_Region = new System.Windows.Forms.Label();
            this.ROM_Properties_SetRename = new System.Windows.Forms.CheckBox();
            this.ROM_Properties_Rename = new System.Windows.Forms.TextBox();
            this.ROM_Properties_Name = new System.Windows.Forms.Label();
            this.ROM_Properties_Size = new System.Windows.Forms.Label();
            this.ROM_Properties_Type = new System.Windows.Forms.Label();
            this.ROM_label = new System.Windows.Forms.Label();
            this.ROM_Properties_Save = new System.Windows.Forms.Button();
            this.LoadROM = new System.Windows.Forms.Button();
            this.ROMFile = new System.Windows.Forms.TextBox();
            this.TestROM = new System.Windows.Forms.Button();
            this.ROM_Properties.SuspendLayout();
            this.SuspendLayout();
            // 
            // ROM_Properties
            // 
            this.ROM_Properties.Controls.Add(this.ROM_Properties_ChangeCartID);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_ChangeManufacturer);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_SetChangeCartID);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_SetChangeManufacturer);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_ChangeRegion);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_SetChangeRegion);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_Version);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_CRC2);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_CRC1);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_MD5);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_CartID);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_Manufacturer);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_Region);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_SetRename);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_Rename);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_Name);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_Size);
            this.ROM_Properties.Controls.Add(this.ROM_Properties_Type);
            this.ROM_Properties.Enabled = false;
            this.ROM_Properties.Location = new System.Drawing.Point(12, 53);
            this.ROM_Properties.Name = "ROM_Properties";
            this.ROM_Properties.Size = new System.Drawing.Size(600, 275);
            this.ROM_Properties.TabIndex = 128;
            this.ROM_Properties.TabStop = false;
            this.ROM_Properties.Text = "Properties";
            // 
            // ROM_Properties_ChangeCartID
            // 
            this.ROM_Properties_ChangeCartID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ROM_Properties_ChangeCartID.Enabled = false;
            this.ROM_Properties_ChangeCartID.Location = new System.Drawing.Point(338, 122);
            this.ROM_Properties_ChangeCartID.MaxLength = 2;
            this.ROM_Properties_ChangeCartID.Name = "ROM_Properties_ChangeCartID";
            this.ROM_Properties_ChangeCartID.Size = new System.Drawing.Size(250, 20);
            this.ROM_Properties_ChangeCartID.TabIndex = 132;
            // 
            // ROM_Properties_ChangeManufacturer
            // 
            this.ROM_Properties_ChangeManufacturer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ROM_Properties_ChangeManufacturer.Enabled = false;
            this.ROM_Properties_ChangeManufacturer.Location = new System.Drawing.Point(338, 97);
            this.ROM_Properties_ChangeManufacturer.MaxLength = 1;
            this.ROM_Properties_ChangeManufacturer.Name = "ROM_Properties_ChangeManufacturer";
            this.ROM_Properties_ChangeManufacturer.Size = new System.Drawing.Size(250, 20);
            this.ROM_Properties_ChangeManufacturer.TabIndex = 131;
            // 
            // ROM_Properties_SetChangeCartID
            // 
            this.ROM_Properties_SetChangeCartID.AutoSize = true;
            this.ROM_Properties_SetChangeCartID.Location = new System.Drawing.Point(266, 124);
            this.ROM_Properties_SetChangeCartID.Name = "ROM_Properties_SetChangeCartID";
            this.ROM_Properties_SetChangeCartID.Size = new System.Drawing.Size(63, 17);
            this.ROM_Properties_SetChangeCartID.TabIndex = 127;
            this.ROM_Properties_SetChangeCartID.Text = "Change";
            this.ROM_Properties_SetChangeCartID.UseVisualStyleBackColor = true;
            this.ROM_Properties_SetChangeCartID.CheckedChanged += new System.EventHandler(this.ROM_Properties_SetChangeCartID_CheckedChanged);
            // 
            // ROM_Properties_SetChangeManufacturer
            // 
            this.ROM_Properties_SetChangeManufacturer.AutoSize = true;
            this.ROM_Properties_SetChangeManufacturer.Location = new System.Drawing.Point(266, 99);
            this.ROM_Properties_SetChangeManufacturer.Name = "ROM_Properties_SetChangeManufacturer";
            this.ROM_Properties_SetChangeManufacturer.Size = new System.Drawing.Size(63, 17);
            this.ROM_Properties_SetChangeManufacturer.TabIndex = 125;
            this.ROM_Properties_SetChangeManufacturer.Text = "Change";
            this.ROM_Properties_SetChangeManufacturer.UseVisualStyleBackColor = true;
            this.ROM_Properties_SetChangeManufacturer.CheckedChanged += new System.EventHandler(this.ROM_Properties_SetChangeManufacturer_CheckedChanged);
            // 
            // ROM_Properties_ChangeRegion
            // 
            this.ROM_Properties_ChangeRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ROM_Properties_ChangeRegion.Enabled = false;
            this.ROM_Properties_ChangeRegion.FormattingEnabled = true;
            this.ROM_Properties_ChangeRegion.Items.AddRange(new object[] {
            "0x00 - Demo",
            "0x20 - Europe",
            "0x21 - Europe",
            "0x36 - Beta",
            "0x38 - Europe",
            "0x41 - Japan/USA",
            "0x44 - Germany",
            "0x45 - USA",
            "0x46 - France",
            "0x49 - Italy",
            "0x4A - Japan",
            "0x50 - Europe",
            "0x53 - Spain",
            "0x55 - Australia",
            "0x58 - Europe",
            "0x59 - Australia",
            "0x70 - Europe"});
            this.ROM_Properties_ChangeRegion.Location = new System.Drawing.Point(338, 72);
            this.ROM_Properties_ChangeRegion.Name = "ROM_Properties_ChangeRegion";
            this.ROM_Properties_ChangeRegion.Size = new System.Drawing.Size(250, 21);
            this.ROM_Properties_ChangeRegion.TabIndex = 124;
            // 
            // ROM_Properties_SetChangeRegion
            // 
            this.ROM_Properties_SetChangeRegion.AutoSize = true;
            this.ROM_Properties_SetChangeRegion.Location = new System.Drawing.Point(266, 74);
            this.ROM_Properties_SetChangeRegion.Name = "ROM_Properties_SetChangeRegion";
            this.ROM_Properties_SetChangeRegion.Size = new System.Drawing.Size(63, 17);
            this.ROM_Properties_SetChangeRegion.TabIndex = 123;
            this.ROM_Properties_SetChangeRegion.Text = "Change";
            this.ROM_Properties_SetChangeRegion.UseVisualStyleBackColor = true;
            this.ROM_Properties_SetChangeRegion.CheckedChanged += new System.EventHandler(this.ROM_Properties_SetChangeRegion_CheckedChanged);
            // 
            // ROM_Properties_Version
            // 
            this.ROM_Properties_Version.AutoSize = true;
            this.ROM_Properties_Version.Location = new System.Drawing.Point(15, 225);
            this.ROM_Properties_Version.Name = "ROM_Properties_Version";
            this.ROM_Properties_Version.Size = new System.Drawing.Size(45, 13);
            this.ROM_Properties_Version.TabIndex = 122;
            this.ROM_Properties_Version.Text = "Version:";
            // 
            // ROM_Properties_CRC2
            // 
            this.ROM_Properties_CRC2.AutoSize = true;
            this.ROM_Properties_CRC2.Location = new System.Drawing.Point(15, 200);
            this.ROM_Properties_CRC2.Name = "ROM_Properties_CRC2";
            this.ROM_Properties_CRC2.Size = new System.Drawing.Size(38, 13);
            this.ROM_Properties_CRC2.TabIndex = 121;
            this.ROM_Properties_CRC2.Text = "CRC2:";
            // 
            // ROM_Properties_CRC1
            // 
            this.ROM_Properties_CRC1.AutoSize = true;
            this.ROM_Properties_CRC1.Location = new System.Drawing.Point(15, 175);
            this.ROM_Properties_CRC1.Name = "ROM_Properties_CRC1";
            this.ROM_Properties_CRC1.Size = new System.Drawing.Size(38, 13);
            this.ROM_Properties_CRC1.TabIndex = 120;
            this.ROM_Properties_CRC1.Text = "CRC1:";
            // 
            // ROM_Properties_MD5
            // 
            this.ROM_Properties_MD5.AutoSize = true;
            this.ROM_Properties_MD5.Location = new System.Drawing.Point(15, 150);
            this.ROM_Properties_MD5.Name = "ROM_Properties_MD5";
            this.ROM_Properties_MD5.Size = new System.Drawing.Size(61, 13);
            this.ROM_Properties_MD5.TabIndex = 119;
            this.ROM_Properties_MD5.Text = "MD5 Hash:";
            // 
            // ROM_Properties_CartID
            // 
            this.ROM_Properties_CartID.AutoSize = true;
            this.ROM_Properties_CartID.Location = new System.Drawing.Point(15, 125);
            this.ROM_Properties_CartID.Name = "ROM_Properties_CartID";
            this.ROM_Properties_CartID.Size = new System.Drawing.Size(66, 13);
            this.ROM_Properties_CartID.TabIndex = 118;
            this.ROM_Properties_CartID.Text = "Cartridge ID:";
            // 
            // ROM_Properties_Manufacturer
            // 
            this.ROM_Properties_Manufacturer.AutoSize = true;
            this.ROM_Properties_Manufacturer.Location = new System.Drawing.Point(15, 100);
            this.ROM_Properties_Manufacturer.Name = "ROM_Properties_Manufacturer";
            this.ROM_Properties_Manufacturer.Size = new System.Drawing.Size(73, 13);
            this.ROM_Properties_Manufacturer.TabIndex = 117;
            this.ROM_Properties_Manufacturer.Text = "Manufacturer:";
            // 
            // ROM_Properties_Region
            // 
            this.ROM_Properties_Region.AutoSize = true;
            this.ROM_Properties_Region.Location = new System.Drawing.Point(15, 75);
            this.ROM_Properties_Region.Name = "ROM_Properties_Region";
            this.ROM_Properties_Region.Size = new System.Drawing.Size(44, 13);
            this.ROM_Properties_Region.TabIndex = 116;
            this.ROM_Properties_Region.Text = "Region:";
            // 
            // ROM_Properties_SetRename
            // 
            this.ROM_Properties_SetRename.AutoSize = true;
            this.ROM_Properties_SetRename.Location = new System.Drawing.Point(266, 24);
            this.ROM_Properties_SetRename.Name = "ROM_Properties_SetRename";
            this.ROM_Properties_SetRename.Size = new System.Drawing.Size(66, 17);
            this.ROM_Properties_SetRename.TabIndex = 113;
            this.ROM_Properties_SetRename.Text = "Rename";
            this.ROM_Properties_SetRename.UseVisualStyleBackColor = true;
            this.ROM_Properties_SetRename.CheckedChanged += new System.EventHandler(this.ROM_Properties_SetRename_CheckedChanged);
            // 
            // ROM_Properties_Rename
            // 
            this.ROM_Properties_Rename.Enabled = false;
            this.ROM_Properties_Rename.Location = new System.Drawing.Point(338, 22);
            this.ROM_Properties_Rename.MaxLength = 20;
            this.ROM_Properties_Rename.Name = "ROM_Properties_Rename";
            this.ROM_Properties_Rename.Size = new System.Drawing.Size(250, 20);
            this.ROM_Properties_Rename.TabIndex = 112;
            // 
            // ROM_Properties_Name
            // 
            this.ROM_Properties_Name.AutoSize = true;
            this.ROM_Properties_Name.Location = new System.Drawing.Point(15, 25);
            this.ROM_Properties_Name.Name = "ROM_Properties_Name";
            this.ROM_Properties_Name.Size = new System.Drawing.Size(38, 13);
            this.ROM_Properties_Name.TabIndex = 108;
            this.ROM_Properties_Name.Text = "Name:";
            // 
            // ROM_Properties_Size
            // 
            this.ROM_Properties_Size.AutoSize = true;
            this.ROM_Properties_Size.Location = new System.Drawing.Point(15, 250);
            this.ROM_Properties_Size.Name = "ROM_Properties_Size";
            this.ROM_Properties_Size.Size = new System.Drawing.Size(30, 13);
            this.ROM_Properties_Size.TabIndex = 1;
            this.ROM_Properties_Size.Text = "Size:";
            // 
            // ROM_Properties_Type
            // 
            this.ROM_Properties_Type.AutoSize = true;
            this.ROM_Properties_Type.Location = new System.Drawing.Point(15, 50);
            this.ROM_Properties_Type.Name = "ROM_Properties_Type";
            this.ROM_Properties_Type.Size = new System.Drawing.Size(34, 13);
            this.ROM_Properties_Type.TabIndex = 0;
            this.ROM_Properties_Type.Text = "Type:";
            // 
            // ROM_label
            // 
            this.ROM_label.AutoSize = true;
            this.ROM_label.Location = new System.Drawing.Point(12, 20);
            this.ROM_label.Name = "ROM_label";
            this.ROM_label.Size = new System.Drawing.Size(32, 13);
            this.ROM_label.TabIndex = 127;
            this.ROM_label.Text = "ROM";
            // 
            // ROM_Properties_Save
            // 
            this.ROM_Properties_Save.Cursor = System.Windows.Forms.Cursors.Default;
            this.ROM_Properties_Save.Enabled = false;
            this.ROM_Properties_Save.Location = new System.Drawing.Point(12, 334);
            this.ROM_Properties_Save.Name = "ROM_Properties_Save";
            this.ROM_Properties_Save.Size = new System.Drawing.Size(600, 30);
            this.ROM_Properties_Save.TabIndex = 123;
            this.ROM_Properties_Save.Text = "Save";
            this.ROM_Properties_Save.UseVisualStyleBackColor = true;
            this.ROM_Properties_Save.Click += new System.EventHandler(this.ROM_Properties_Save_Click);
            // 
            // LoadROM
            // 
            this.LoadROM.Location = new System.Drawing.Point(537, 15);
            this.LoadROM.Name = "LoadROM";
            this.LoadROM.Size = new System.Drawing.Size(75, 23);
            this.LoadROM.TabIndex = 126;
            this.LoadROM.Text = "Load";
            this.LoadROM.UseVisualStyleBackColor = true;
            this.LoadROM.Click += new System.EventHandler(this.LoadROM_Click);
            // 
            // ROMFile
            // 
            this.ROMFile.BackColor = System.Drawing.SystemColors.Window;
            this.ROMFile.Enabled = false;
            this.ROMFile.Location = new System.Drawing.Point(50, 17);
            this.ROMFile.Name = "ROMFile";
            this.ROMFile.ReadOnly = true;
            this.ROMFile.Size = new System.Drawing.Size(481, 20);
            this.ROMFile.TabIndex = 125;
            // 
            // TestROM
            // 
            this.TestROM.Enabled = false;
            this.TestROM.Location = new System.Drawing.Point(12, 370);
            this.TestROM.Name = "TestROM";
            this.TestROM.Size = new System.Drawing.Size(600, 30);
            this.TestROM.TabIndex = 124;
            this.TestROM.Text = "Test ROM";
            this.TestROM.UseVisualStyleBackColor = true;
            this.TestROM.Click += new System.EventHandler(this.TestROM_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 412);
            this.Controls.Add(this.ROM_Properties);
            this.Controls.Add(this.ROM_label);
            this.Controls.Add(this.ROM_Properties_Save);
            this.Controls.Add(this.LoadROM);
            this.Controls.Add(this.ROMFile);
            this.Controls.Add(this.TestROM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info64";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ROM_Properties.ResumeLayout(false);
            this.ROM_Properties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ROM_Properties;
        private System.Windows.Forms.ComboBox ROM_Properties_ChangeRegion;
        private System.Windows.Forms.CheckBox ROM_Properties_SetChangeRegion;
        private System.Windows.Forms.Label ROM_Properties_Version;
        private System.Windows.Forms.Label ROM_Properties_CRC2;
        private System.Windows.Forms.Label ROM_Properties_CRC1;
        private System.Windows.Forms.Label ROM_Properties_MD5;
        private System.Windows.Forms.Label ROM_Properties_CartID;
        private System.Windows.Forms.Label ROM_Properties_Manufacturer;
        private System.Windows.Forms.Label ROM_Properties_Region;
        private System.Windows.Forms.CheckBox ROM_Properties_SetRename;
        private System.Windows.Forms.TextBox ROM_Properties_Rename;
        private System.Windows.Forms.Label ROM_Properties_Name;
        private System.Windows.Forms.Label ROM_Properties_Size;
        private System.Windows.Forms.Label ROM_Properties_Type;
        internal System.Windows.Forms.Label ROM_label;
        private System.Windows.Forms.Button ROM_Properties_Save;
        internal System.Windows.Forms.Button LoadROM;
        private System.Windows.Forms.TextBox ROMFile;
        private System.Windows.Forms.Button TestROM;
        private System.Windows.Forms.CheckBox ROM_Properties_SetChangeManufacturer;
        private System.Windows.Forms.TextBox ROM_Properties_ChangeCartID;
        private System.Windows.Forms.TextBox ROM_Properties_ChangeManufacturer;
        private System.Windows.Forms.CheckBox ROM_Properties_SetChangeCartID;
    }
}

