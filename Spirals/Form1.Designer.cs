namespace DrawSpiral
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intSeedRadius = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chxFlipped = new System.Windows.Forms.CheckBox();
            this.intSpiralLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpiralColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.intThickness = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.intTightness = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intSeedRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSpiralLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intTightness)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 469);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.intSeedRadius);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chxFlipped);
            this.groupBox1.Controls.Add(this.intSpiralLength);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSpiralColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.intThickness);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.intTightness);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // intSeedRadius
            // 
            this.intSeedRadius.Location = new System.Drawing.Point(266, 52);
            this.intSeedRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.intSeedRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intSeedRadius.Name = "intSeedRadius";
            this.intSeedRadius.Size = new System.Drawing.Size(75, 20);
            this.intSeedRadius.TabIndex = 10;
            this.intSeedRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seed Radius:";
            // 
            // chxFlipped
            // 
            this.chxFlipped.AutoSize = true;
            this.chxFlipped.Location = new System.Drawing.Point(367, 53);
            this.chxFlipped.Name = "chxFlipped";
            this.chxFlipped.Size = new System.Drawing.Size(60, 17);
            this.chxFlipped.TabIndex = 8;
            this.chxFlipped.Text = "Flipped";
            this.chxFlipped.UseVisualStyleBackColor = true;
            // 
            // intSpiralLength
            // 
            this.intSpiralLength.Location = new System.Drawing.Point(266, 26);
            this.intSpiralLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.intSpiralLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intSpiralLength.Name = "intSpiralLength";
            this.intSpiralLength.Size = new System.Drawing.Size(75, 20);
            this.intSpiralLength.TabIndex = 7;
            this.intSpiralLength.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Length:";
            // 
            // btnSpiralColor
            // 
            this.btnSpiralColor.BackColor = System.Drawing.Color.Black;
            this.btnSpiralColor.Location = new System.Drawing.Point(417, 23);
            this.btnSpiralColor.Name = "btnSpiralColor";
            this.btnSpiralColor.Size = new System.Drawing.Size(91, 23);
            this.btnSpiralColor.TabIndex = 5;
            this.btnSpiralColor.UseVisualStyleBackColor = false;
            this.btnSpiralColor.Click += new System.EventHandler(this.btnSpiralColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color:";
            // 
            // intThickness
            // 
            this.intThickness.Location = new System.Drawing.Point(104, 52);
            this.intThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intThickness.Name = "intThickness";
            this.intThickness.Size = new System.Drawing.Size(74, 20);
            this.intThickness.TabIndex = 3;
            this.intThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thickness:";
            // 
            // intTightness
            // 
            this.intTightness.Location = new System.Drawing.Point(104, 26);
            this.intTightness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intTightness.Name = "intTightness";
            this.intTightness.Size = new System.Drawing.Size(74, 20);
            this.intTightness.TabIndex = 1;
            this.intTightness.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tightness:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Spirals - Adam Spindler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intSeedRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSpiralLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intTightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intThickness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown intTightness;
        private System.Windows.Forms.Button btnSpiralColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown intSpiralLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chxFlipped;
        private System.Windows.Forms.NumericUpDown intSeedRadius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

