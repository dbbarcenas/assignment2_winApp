namespace WindowsFormsApplication1
{
    partial class AutoCenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoCenterForm));
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.TradeAllowanceLabel = new System.Windows.Forms.Label();
            this.AdditionalOpitonsLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.TradeAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalOptionsTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.AdditionalGroupBox = new System.Windows.Forms.GroupBox();
            this.ComputerNavCheckBox = new System.Windows.Forms.CheckBox();
            this.LeatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.StereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.ExteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomizedRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.AdditionalGroupBox.SuspendLayout();
            this.ExteriorFinishGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(18, 221);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(58, 13);
            this.BasePriceLabel.TabIndex = 3;
            this.BasePriceLabel.Text = "Base Price";
            // 
            // TradeAllowanceLabel
            // 
            this.TradeAllowanceLabel.AutoSize = true;
            this.TradeAllowanceLabel.Location = new System.Drawing.Point(18, 248);
            this.TradeAllowanceLabel.Name = "TradeAllowanceLabel";
            this.TradeAllowanceLabel.Size = new System.Drawing.Size(98, 13);
            this.TradeAllowanceLabel.TabIndex = 4;
            this.TradeAllowanceLabel.Text = "Trade-in Allowance";
            // 
            // AdditionalOpitonsLabel
            // 
            this.AdditionalOpitonsLabel.AutoSize = true;
            this.AdditionalOpitonsLabel.Location = new System.Drawing.Point(18, 284);
            this.AdditionalOpitonsLabel.Name = "AdditionalOpitonsLabel";
            this.AdditionalOpitonsLabel.Size = new System.Drawing.Size(92, 13);
            this.AdditionalOpitonsLabel.TabIndex = 5;
            this.AdditionalOpitonsLabel.Text = "Additional Options";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(18, 310);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(53, 13);
            this.SubTotalLabel.TabIndex = 6;
            this.SubTotalLabel.Text = "Sub Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(18, 336);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(54, 13);
            this.SalesTaxLabel.TabIndex = 7;
            this.SalesTaxLabel.Text = "Sales Tax";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(18, 361);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 8;
            this.TotalLabel.Text = "Total ";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Location = new System.Drawing.Point(18, 387);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(66, 13);
            this.AmountDueLabel.TabIndex = 9;
            this.AmountDueLabel.Text = "Amount Due";
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(122, 214);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BasePriceTextBox.TabIndex = 10;
            this.BasePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BasePriceTextBox_TextChanged);
            // 
            // TradeAllowanceTextBox
            // 
            this.TradeAllowanceTextBox.Location = new System.Drawing.Point(122, 241);
            this.TradeAllowanceTextBox.Name = "TradeAllowanceTextBox";
            this.TradeAllowanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.TradeAllowanceTextBox.TabIndex = 11;
            this.TradeAllowanceTextBox.Text = "0";
            // 
            // AdditionalOptionsTextBox
            // 
            this.AdditionalOptionsTextBox.Location = new System.Drawing.Point(122, 277);
            this.AdditionalOptionsTextBox.Name = "AdditionalOptionsTextBox";
            this.AdditionalOptionsTextBox.ReadOnly = true;
            this.AdditionalOptionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdditionalOptionsTextBox.TabIndex = 12;
            this.AdditionalOptionsTextBox.Text = "0";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(122, 329);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesTaxTextBox.TabIndex = 14;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(122, 354);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 15;
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(122, 380);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountDueTextBox.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fontToolStripMenuItem.Text = "&Font ...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.colorToolStripMenuItem.Text = "C&olor...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            // 
            // AdditionalGroupBox
            // 
            this.AdditionalGroupBox.Controls.Add(this.ComputerNavCheckBox);
            this.AdditionalGroupBox.Controls.Add(this.LeatherInteriorCheckBox);
            this.AdditionalGroupBox.Controls.Add(this.StereoSystemCheckBox);
            this.AdditionalGroupBox.Location = new System.Drawing.Point(243, 50);
            this.AdditionalGroupBox.Name = "AdditionalGroupBox";
            this.AdditionalGroupBox.Size = new System.Drawing.Size(182, 113);
            this.AdditionalGroupBox.TabIndex = 18;
            this.AdditionalGroupBox.TabStop = false;
            this.AdditionalGroupBox.Text = "Additional Items";
            // 
            // ComputerNavCheckBox
            // 
            this.ComputerNavCheckBox.AutoSize = true;
            this.ComputerNavCheckBox.Location = new System.Drawing.Point(30, 75);
            this.ComputerNavCheckBox.Name = "ComputerNavCheckBox";
            this.ComputerNavCheckBox.Size = new System.Drawing.Size(125, 17);
            this.ComputerNavCheckBox.TabIndex = 2;
            this.ComputerNavCheckBox.Text = "Computer Navigation";
            this.ComputerNavCheckBox.UseVisualStyleBackColor = true;
            this.ComputerNavCheckBox.Click += new System.EventHandler(this.AdditionalOptionsTextBox_TextChanged);
            // 
            // LeatherInteriorCheckBox
            // 
            this.LeatherInteriorCheckBox.AutoSize = true;
            this.LeatherInteriorCheckBox.Location = new System.Drawing.Point(30, 52);
            this.LeatherInteriorCheckBox.Name = "LeatherInteriorCheckBox";
            this.LeatherInteriorCheckBox.Size = new System.Drawing.Size(97, 17);
            this.LeatherInteriorCheckBox.TabIndex = 1;
            this.LeatherInteriorCheckBox.Text = "Leather Interior";
            this.LeatherInteriorCheckBox.UseVisualStyleBackColor = true;
            this.LeatherInteriorCheckBox.Click += new System.EventHandler(this.AdditionalOptionsTextBox_TextChanged);
            // 
            // StereoSystemCheckBox
            // 
            this.StereoSystemCheckBox.AutoSize = true;
            this.StereoSystemCheckBox.Location = new System.Drawing.Point(30, 29);
            this.StereoSystemCheckBox.Name = "StereoSystemCheckBox";
            this.StereoSystemCheckBox.Size = new System.Drawing.Size(94, 17);
            this.StereoSystemCheckBox.TabIndex = 0;
            this.StereoSystemCheckBox.Text = "Stereo System";
            this.StereoSystemCheckBox.UseVisualStyleBackColor = true;
            this.StereoSystemCheckBox.Click += new System.EventHandler(this.AdditionalOptionsTextBox_TextChanged);
            // 
            // ExteriorFinishGroupBox
            // 
            this.ExteriorFinishGroupBox.Controls.Add(this.CustomizedRadioButton);
            this.ExteriorFinishGroupBox.Controls.Add(this.PearlizedRadioButton);
            this.ExteriorFinishGroupBox.Controls.Add(this.StandardRadioButton);
            this.ExteriorFinishGroupBox.Location = new System.Drawing.Point(243, 241);
            this.ExteriorFinishGroupBox.Name = "ExteriorFinishGroupBox";
            this.ExteriorFinishGroupBox.Size = new System.Drawing.Size(182, 121);
            this.ExteriorFinishGroupBox.TabIndex = 19;
            this.ExteriorFinishGroupBox.TabStop = false;
            this.ExteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // CustomizedRadioButton
            // 
            this.CustomizedRadioButton.AutoSize = true;
            this.CustomizedRadioButton.Location = new System.Drawing.Point(30, 83);
            this.CustomizedRadioButton.Name = "CustomizedRadioButton";
            this.CustomizedRadioButton.Size = new System.Drawing.Size(123, 17);
            this.CustomizedRadioButton.TabIndex = 2;
            this.CustomizedRadioButton.Text = "Customized Detailing";
            this.CustomizedRadioButton.UseVisualStyleBackColor = true;
            this.CustomizedRadioButton.Click += new System.EventHandler(this.AdditionalOptionsTextBox_TextChanged);
            // 
            // PearlizedRadioButton
            // 
            this.PearlizedRadioButton.AutoSize = true;
            this.PearlizedRadioButton.Location = new System.Drawing.Point(30, 60);
            this.PearlizedRadioButton.Name = "PearlizedRadioButton";
            this.PearlizedRadioButton.Size = new System.Drawing.Size(68, 17);
            this.PearlizedRadioButton.TabIndex = 1;
            this.PearlizedRadioButton.Text = "Pearlized";
            this.PearlizedRadioButton.UseVisualStyleBackColor = true;
            this.PearlizedRadioButton.Click += new System.EventHandler(this.AdditionalOptionsTextBox_TextChanged);
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(30, 36);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(68, 17);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            this.StandardRadioButton.Click += new System.EventHandler(this.AdditionalOptionsTextBox_TextChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(21, 425);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 20;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(167, 425);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(321, 425);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.ErrorImage = null;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.InitialImage = null;
            this.LogoPictureBox.Location = new System.Drawing.Point(30, 39);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(169, 147);
            this.LogoPictureBox.TabIndex = 23;
            this.LogoPictureBox.TabStop = false;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(122, 303);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 24;
            // 
            // AutoCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 460);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExteriorFinishGroupBox);
            this.Controls.Add(this.AdditionalGroupBox);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.AdditionalOptionsTextBox);
            this.Controls.Add(this.TradeAllowanceTextBox);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.AdditionalOpitonsLabel);
            this.Controls.Add(this.TradeAllowanceLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutoCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Center";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AdditionalGroupBox.ResumeLayout(false);
            this.AdditionalGroupBox.PerformLayout();
            this.ExteriorFinishGroupBox.ResumeLayout(false);
            this.ExteriorFinishGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label TradeAllowanceLabel;
        private System.Windows.Forms.Label AdditionalOpitonsLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.TextBox TradeAllowanceTextBox;
        private System.Windows.Forms.TextBox AdditionalOptionsTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox AdditionalGroupBox;
        private System.Windows.Forms.CheckBox ComputerNavCheckBox;
        private System.Windows.Forms.CheckBox LeatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox StereoSystemCheckBox;
        private System.Windows.Forms.GroupBox ExteriorFinishGroupBox;
        private System.Windows.Forms.RadioButton CustomizedRadioButton;
        private System.Windows.Forms.RadioButton PearlizedRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox SubTotalTextBox;
    }
}

