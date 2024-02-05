namespace RustColorPicker
{
    partial class frm1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatCheckBox1 = new FlatUI.FlatCheckBox();
            this.btnColor = new FlatUI.FlatButton();
            this.tbA = new FlatUI.FlatTrackBar();
            this.tbB = new FlatUI.FlatTrackBar();
            this.tbG = new FlatUI.FlatTrackBar();
            this.tbR = new FlatUI.FlatTrackBar();
            this.btnRust = new FlatUI.FlatButton();
            this.btnHex = new FlatUI.FlatButton();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.txtRust = new FlatUI.FlatTextBox();
            this.txtHex = new FlatUI.FlatTextBox();
            this.flatStatusBar1 = new FlatUI.FlatStatusBar();
            this.picboxColor = new System.Windows.Forms.PictureBox();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatCheckBox1);
            this.formSkin1.Controls.Add(this.btnColor);
            this.formSkin1.Controls.Add(this.tbA);
            this.formSkin1.Controls.Add(this.tbB);
            this.formSkin1.Controls.Add(this.tbG);
            this.formSkin1.Controls.Add(this.tbR);
            this.formSkin1.Controls.Add(this.btnRust);
            this.formSkin1.Controls.Add(this.btnHex);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.txtRust);
            this.formSkin1.Controls.Add(this.txtHex);
            this.formSkin1.Controls.Add(this.flatStatusBar1);
            this.formSkin1.Controls.Add(this.picboxColor);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(353, 268);
            this.formSkin1.TabIndex = 18;
            this.formSkin1.Text = "ColorPicker RUST";
            // 
            // flatCheckBox1
            // 
            this.flatCheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.flatCheckBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatCheckBox1.Checked = true;
            this.flatCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBox1.Location = new System.Drawing.Point(279, 246);
            this.flatCheckBox1.Name = "flatCheckBox1";
            this.flatCheckBox1.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBox1.Size = new System.Drawing.Size(72, 22);
            this.flatCheckBox1.TabIndex = 27;
            this.flatCheckBox1.Text = "OnTop";
            this.flatCheckBox1.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.flatCheckBox1_CheckedChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnColor.Location = new System.Drawing.Point(279, 170);
            this.btnColor.Name = "btnColor";
            this.btnColor.Rounded = false;
            this.btnColor.Size = new System.Drawing.Size(64, 64);
            this.btnColor.TabIndex = 26;
            this.btnColor.Text = "Win";
            this.btnColor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tbA
            // 
            this.tbA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tbA.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.tbA.Location = new System.Drawing.Point(8, 141);
            this.tbA.Maximum = 255;
            this.tbA.Minimum = 0;
            this.tbA.Name = "tbA";
            this.tbA.ShowValue = true;
            this.tbA.Size = new System.Drawing.Size(335, 23);
            this.tbA.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.tbA.TabIndex = 25;
            this.tbA.Text = "tbA";
            this.tbA.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.tbA.Value = 0;
            this.tbA.Click += new System.EventHandler(this.tb_Scroll);
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tbB.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbB.Location = new System.Drawing.Point(87, 108);
            this.tbB.Maximum = 255;
            this.tbB.Minimum = 0;
            this.tbB.Name = "tbB";
            this.tbB.ShowValue = true;
            this.tbB.Size = new System.Drawing.Size(256, 23);
            this.tbB.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.tbB.TabIndex = 25;
            this.tbB.Text = "flatTrackBar1";
            this.tbB.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.tbB.Value = 0;
            this.tbB.Click += new System.EventHandler(this.tb_Scroll);
            // 
            // tbG
            // 
            this.tbG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tbG.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.tbG.Location = new System.Drawing.Point(87, 85);
            this.tbG.Maximum = 255;
            this.tbG.Minimum = 0;
            this.tbG.Name = "tbG";
            this.tbG.ShowValue = true;
            this.tbG.Size = new System.Drawing.Size(256, 23);
            this.tbG.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.tbG.TabIndex = 25;
            this.tbG.Text = "flatTrackBar1";
            this.tbG.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.tbG.Value = 0;
            this.tbG.Click += new System.EventHandler(this.tb_Scroll);
            // 
            // tbR
            // 
            this.tbR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tbR.HatchColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tbR.Location = new System.Drawing.Point(87, 62);
            this.tbR.Maximum = 255;
            this.tbR.Minimum = 0;
            this.tbR.Name = "tbR";
            this.tbR.ShowValue = true;
            this.tbR.Size = new System.Drawing.Size(256, 23);
            this.tbR.Style = FlatUI.FlatTrackBar._Style.Slider;
            this.tbR.TabIndex = 25;
            this.tbR.Text = "flatTrackBar1";
            this.tbR.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.tbR.Value = 0;
            this.tbR.Click += new System.EventHandler(this.tb_Scroll);
            // 
            // btnRust
            // 
            this.btnRust.BackColor = System.Drawing.Color.Transparent;
            this.btnRust.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnRust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRust.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRust.Location = new System.Drawing.Point(168, 205);
            this.btnRust.Name = "btnRust";
            this.btnRust.Rounded = false;
            this.btnRust.Size = new System.Drawing.Size(106, 29);
            this.btnRust.TabIndex = 24;
            this.btnRust.Text = "Convert Rust";
            this.btnRust.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnRust.Click += new System.EventHandler(this.btnRust_Click);
            // 
            // btnHex
            // 
            this.btnHex.BackColor = System.Drawing.Color.Transparent;
            this.btnHex.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnHex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHex.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHex.Location = new System.Drawing.Point(168, 170);
            this.btnHex.Name = "btnHex";
            this.btnHex.Rounded = false;
            this.btnHex.Size = new System.Drawing.Size(106, 29);
            this.btnHex.TabIndex = 23;
            this.btnHex.Text = "Convert Hex";
            this.btnHex.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(323, 14);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 22;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(299, 14);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 21;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // txtRust
            // 
            this.txtRust.BackColor = System.Drawing.Color.Transparent;
            this.txtRust.FocusOnHover = false;
            this.txtRust.Location = new System.Drawing.Point(8, 205);
            this.txtRust.MaxLength = 32767;
            this.txtRust.Multiline = false;
            this.txtRust.Name = "txtRust";
            this.txtRust.ReadOnly = false;
            this.txtRust.Size = new System.Drawing.Size(154, 29);
            this.txtRust.TabIndex = 20;
            this.txtRust.Text = "RUST";
            this.txtRust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRust.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtRust.UseSystemPasswordChar = false;
            // 
            // txtHex
            // 
            this.txtHex.BackColor = System.Drawing.Color.Transparent;
            this.txtHex.FocusOnHover = false;
            this.txtHex.Location = new System.Drawing.Point(8, 170);
            this.txtHex.MaxLength = 32767;
            this.txtHex.Multiline = false;
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = false;
            this.txtHex.Size = new System.Drawing.Size(154, 29);
            this.txtHex.TabIndex = 19;
            this.txtHex.Text = "HEX";
            this.txtHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHex.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtHex.UseSystemPasswordChar = false;
            // 
            // flatStatusBar1
            // 
            this.flatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatStatusBar1.ForeColor = System.Drawing.Color.White;
            this.flatStatusBar1.Location = new System.Drawing.Point(0, 246);
            this.flatStatusBar1.Name = "flatStatusBar1";
            this.flatStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStatusBar1.ShowTimeDate = false;
            this.flatStatusBar1.Size = new System.Drawing.Size(353, 22);
            this.flatStatusBar1.TabIndex = 18;
            this.flatStatusBar1.Text = "Discord: 0xD5F#4496";
            this.flatStatusBar1.TextColor = System.Drawing.Color.White;
            // 
            // picboxColor
            // 
            this.picboxColor.Location = new System.Drawing.Point(8, 59);
            this.picboxColor.Name = "picboxColor";
            this.picboxColor.Size = new System.Drawing.Size(70, 70);
            this.picboxColor.TabIndex = 15;
            this.picboxColor.TabStop = false;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 268);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rust Color Picker";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picboxColor;
        private FlatUI.FlatStatusBar flatStatusBar1;
        private FlatUI.FlatTextBox txtHex;
        private FlatUI.FlatTextBox txtRust;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatButton btnHex;
        private FlatUI.FlatButton btnRust;
        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatTrackBar tbA;
        private FlatUI.FlatTrackBar tbB;
        private FlatUI.FlatTrackBar tbG;
        private FlatUI.FlatTrackBar tbR;
        private FlatUI.FlatCheckBox flatCheckBox1;
        private FlatUI.FlatButton btnColor;
    }
}

