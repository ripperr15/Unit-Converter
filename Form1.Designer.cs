namespace Unit_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_volume = new System.Windows.Forms.RadioButton();
            this.rdo_area = new System.Windows.Forms.RadioButton();
            this.rdo_length = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cmb_convertfrom = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cmb_convertto = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rESETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rdo_volume);
            this.groupBox1.Controls.Add(this.rdo_area);
            this.groupBox1.Controls.Add(this.rdo_length);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Units>=";
            // 
            // rdo_volume
            // 
            this.rdo_volume.AutoSize = true;
            this.rdo_volume.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdo_volume.ForeColor = System.Drawing.SystemColors.Control;
            this.rdo_volume.Location = new System.Drawing.Point(33, 152);
            this.rdo_volume.Name = "rdo_volume";
            this.rdo_volume.Size = new System.Drawing.Size(88, 24);
            this.rdo_volume.TabIndex = 2;
            this.rdo_volume.TabStop = true;
            this.rdo_volume.Text = "VOLUME";
            this.rdo_volume.UseVisualStyleBackColor = false;
            this.rdo_volume.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdo_area
            // 
            this.rdo_area.AutoSize = true;
            this.rdo_area.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdo_area.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdo_area.Location = new System.Drawing.Point(33, 99);
            this.rdo_area.Name = "rdo_area";
            this.rdo_area.Size = new System.Drawing.Size(67, 24);
            this.rdo_area.TabIndex = 1;
            this.rdo_area.TabStop = true;
            this.rdo_area.Text = "AREA";
            this.rdo_area.UseVisualStyleBackColor = false;
            this.rdo_area.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdo_length
            // 
            this.rdo_length.AutoSize = true;
            this.rdo_length.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdo_length.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdo_length.Location = new System.Drawing.Point(33, 49);
            this.rdo_length.Name = "rdo_length";
            this.rdo_length.Size = new System.Drawing.Size(85, 24);
            this.rdo_length.TabIndex = 0;
            this.rdo_length.TabStop = true;
            this.rdo_length.Text = "LENGTH";
            this.rdo_length.UseVisualStyleBackColor = false;
            this.rdo_length.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Controls.Add(this.cmb_convertfrom);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(406, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONVERT FROM";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(371, 48);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(125, 27);
            this.txt1.TabIndex = 1;
            // 
            // cmb_convertfrom
            // 
            this.cmb_convertfrom.FormattingEnabled = true;
            this.cmb_convertfrom.Location = new System.Drawing.Point(36, 47);
            this.cmb_convertfrom.Name = "cmb_convertfrom";
            this.cmb_convertfrom.Size = new System.Drawing.Size(151, 28);
            this.cmb_convertfrom.TabIndex = 0;
          //   this.cmb_convertfrom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Controls.Add(this.txt2);
            this.groupBox3.Controls.Add(this.cmb_convertto);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(406, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONVERT TO";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(371, 39);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(125, 27);
            this.txt2.TabIndex = 1;
            // 
            // cmb_convertto
            // 
            this.cmb_convertto.FormattingEnabled = true;
            this.cmb_convertto.Location = new System.Drawing.Point(36, 38);
            this.cmb_convertto.Name = "cmb_convertto";
            this.cmb_convertto.Size = new System.Drawing.Size(151, 28);
            this.cmb_convertto.TabIndex = 0;
            this.cmb_convertto.SelectedIndexChanged += new System.EventHandler(this.cmb_convertto_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rESETToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rESETToolStripMenuItem
            // 
            this.rESETToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rESETToolStripMenuItem.Name = "rESETToolStripMenuItem";
            this.rESETToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.rESETToolStripMenuItem.Text = "RESET";
            this.rESETToolStripMenuItem.Click += new System.EventHandler(this.rESETToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1022, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdo_volume;
        private RadioButton rdo_area;
        private RadioButton rdo_length;
        private GroupBox groupBox2;
        private TextBox txt1;
        private ComboBox cmb_convertfrom;
        private GroupBox groupBox3;
        private TextBox txt2;
        private ComboBox cmb_convertto;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem rESETToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
    }
}