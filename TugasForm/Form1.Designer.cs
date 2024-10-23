namespace TugasForm
{
    partial class Form1
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
            this.inputName = new System.Windows.Forms.TextBox();
            this.labelErrorName = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.NumericUpDown();
            this.labelErrorAge = new System.Windows.Forms.Label();
            this.radioGenderMen = new System.Windows.Forms.RadioButton();
            this.groupName = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupAge = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGender = new System.Windows.Forms.Panel();
            this.flowLayoutPanelGender = new System.Windows.Forms.FlowLayoutPanel();
            this.radioGenderWoman = new System.Windows.Forms.RadioButton();
            this.labelErrorGender = new System.Windows.Forms.Label();
            this.checkBoxTnc = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputAge)).BeginInit();
            this.groupName.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupAge.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupGender.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panelGender.SuspendLayout();
            this.flowLayoutPanelGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(3, 3);
            this.inputName.MaxLength = 50;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(300, 20);
            this.inputName.TabIndex = 0;
            // 
            // labelErrorName
            // 
            this.labelErrorName.AutoSize = true;
            this.labelErrorName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorName.Location = new System.Drawing.Point(3, 26);
            this.labelErrorName.Name = "labelErrorName";
            this.labelErrorName.Size = new System.Drawing.Size(0, 13);
            this.labelErrorName.TabIndex = 4;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(3, 3);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(80, 20);
            this.inputAge.TabIndex = 3;
            // 
            // labelErrorAge
            // 
            this.labelErrorAge.AutoSize = true;
            this.labelErrorAge.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAge.Location = new System.Drawing.Point(3, 26);
            this.labelErrorAge.Name = "labelErrorAge";
            this.labelErrorAge.Size = new System.Drawing.Size(0, 13);
            this.labelErrorAge.TabIndex = 5;
            // 
            // radioGenderMen
            // 
            this.radioGenderMen.AutoSize = true;
            this.radioGenderMen.Location = new System.Drawing.Point(3, 3);
            this.radioGenderMen.Name = "radioGenderMen";
            this.radioGenderMen.Size = new System.Drawing.Size(68, 17);
            this.radioGenderMen.TabIndex = 7;
            this.radioGenderMen.TabStop = true;
            this.radioGenderMen.Text = "Laki-Laki";
            this.radioGenderMen.UseVisualStyleBackColor = true;
            // 
            // groupName
            // 
            this.groupName.AutoSize = true;
            this.groupName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupName.Controls.Add(this.flowLayoutPanel1);
            this.groupName.Location = new System.Drawing.Point(12, 10);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(318, 74);
            this.groupName.TabIndex = 8;
            this.groupName.TabStop = false;
            this.groupName.Text = "Nama";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.inputName);
            this.flowLayoutPanel1.Controls.Add(this.labelErrorName);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 39);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // groupAge
            // 
            this.groupAge.AutoSize = true;
            this.groupAge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupAge.Controls.Add(this.flowLayoutPanel2);
            this.groupAge.Location = new System.Drawing.Point(12, 90);
            this.groupAge.Name = "groupAge";
            this.groupAge.Size = new System.Drawing.Size(98, 77);
            this.groupAge.TabIndex = 9;
            this.groupAge.TabStop = false;
            this.groupAge.Text = "Umur";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.inputAge);
            this.flowLayoutPanel2.Controls.Add(this.labelErrorAge);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(86, 39);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // groupGender
            // 
            this.groupGender.AutoSize = true;
            this.groupGender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupGender.Controls.Add(this.flowLayoutPanel4);
            this.groupGender.Location = new System.Drawing.Point(12, 173);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(183, 84);
            this.groupGender.TabIndex = 10;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Jenis Kelamin";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.panelGender);
            this.flowLayoutPanel4.Controls.Add(this.labelErrorGender);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 17);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(171, 48);
            this.flowLayoutPanel4.TabIndex = 12;
            // 
            // panelGender
            // 
            this.panelGender.AutoSize = true;
            this.panelGender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGender.Controls.Add(this.flowLayoutPanelGender);
            this.panelGender.Location = new System.Drawing.Point(3, 3);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(165, 29);
            this.panelGender.TabIndex = 12;
            // 
            // flowLayoutPanelGender
            // 
            this.flowLayoutPanelGender.AutoSize = true;
            this.flowLayoutPanelGender.Controls.Add(this.radioGenderMen);
            this.flowLayoutPanelGender.Controls.Add(this.radioGenderWoman);
            this.flowLayoutPanelGender.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelGender.Name = "flowLayoutPanelGender";
            this.flowLayoutPanelGender.Size = new System.Drawing.Size(159, 23);
            this.flowLayoutPanelGender.TabIndex = 11;
            // 
            // radioGenderWoman
            // 
            this.radioGenderWoman.AutoSize = true;
            this.radioGenderWoman.Location = new System.Drawing.Point(77, 3);
            this.radioGenderWoman.Name = "radioGenderWoman";
            this.radioGenderWoman.Size = new System.Drawing.Size(79, 17);
            this.radioGenderWoman.TabIndex = 13;
            this.radioGenderWoman.TabStop = true;
            this.radioGenderWoman.Text = "Perempuan";
            this.radioGenderWoman.UseVisualStyleBackColor = true;
            // 
            // labelErrorGender
            // 
            this.labelErrorGender.AutoSize = true;
            this.labelErrorGender.ForeColor = System.Drawing.Color.Red;
            this.labelErrorGender.Location = new System.Drawing.Point(3, 35);
            this.labelErrorGender.Name = "labelErrorGender";
            this.labelErrorGender.Size = new System.Drawing.Size(0, 13);
            this.labelErrorGender.TabIndex = 11;
            // 
            // checkBoxTnc
            // 
            this.checkBoxTnc.AutoSize = true;
            this.checkBoxTnc.Location = new System.Drawing.Point(12, 263);
            this.checkBoxTnc.Name = "checkBoxTnc";
            this.checkBoxTnc.Size = new System.Drawing.Size(638, 17);
            this.checkBoxTnc.TabIndex = 11;
            this.checkBoxTnc.Text = "Dengan ini, saya menyatakan bahwa saya telah membaca, memahami, dan menyetujui se" + "mua syarat dan ketentuan yang berlaku.";
            this.checkBoxTnc.UseVisualStyleBackColor = true;
            this.checkBoxTnc.CheckedChanged += new System.EventHandler(this.checkBoxTnc_CheckedChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(12, 286);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(637, 39);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Kirim";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 336);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.checkBoxTnc);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.groupAge);
            this.Controls.Add(this.groupName);
            this.MinimumSize = new System.Drawing.Size(677, 375);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputAge)).EndInit();
            this.groupName.ResumeLayout(false);
            this.groupName.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupAge.ResumeLayout(false);
            this.groupAge.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.flowLayoutPanelGender.ResumeLayout(false);
            this.flowLayoutPanelGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonSubmit;

        private System.Windows.Forms.CheckBox checkBoxTnc;

        private System.Windows.Forms.Label labelErrorGender;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;

        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGender;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton radioGenderWoman;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

        private System.Windows.Forms.GroupBox groupAge;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.GroupBox groupName;

        private System.Windows.Forms.RadioButton radioGenderMen;

        private System.Windows.Forms.Label labelErrorAge;

        private System.Windows.Forms.Label labelErrorName;

        private System.Windows.Forms.NumericUpDown inputAge;

        private System.Windows.Forms.TextBox inputName;

        #endregion
    }
}