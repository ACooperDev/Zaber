namespace Zaber
{
    partial class ZaberControler
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
            this.components = new System.ComponentModel.Container();
            this.GetPort = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonMoveNegative = new System.Windows.Forms.Button();
            this.buttonMovePositive = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownStepSize = new System.Windows.Forms.NumericUpDown();
            this.buttonRun = new System.Windows.Forms.Button();
            this.numericUpDownScanSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartPosition = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownScanLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScanSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScanLength)).BeginInit();
            this.SuspendLayout();
            // 
            // GetPort
            // 
            this.GetPort.Location = new System.Drawing.Point(12, 49);
            this.GetPort.Name = "GetPort";
            this.GetPort.Size = new System.Drawing.Size(75, 23);
            this.GetPort.TabIndex = 0;
            this.GetPort.Text = "GetPort";
            this.GetPort.UseVisualStyleBackColor = true;
            this.GetPort.Click += new System.EventHandler(this.button1GetPort);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(93, 54);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port";
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(12, 78);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(93, 78);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonEnd.TabIndex = 4;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonMoveNegative
            // 
            this.buttonMoveNegative.Location = new System.Drawing.Point(12, 107);
            this.buttonMoveNegative.Name = "buttonMoveNegative";
            this.buttonMoveNegative.Size = new System.Drawing.Size(32, 23);
            this.buttonMoveNegative.TabIndex = 5;
            this.buttonMoveNegative.Text = "-";
            this.buttonMoveNegative.UseVisualStyleBackColor = true;
            this.buttonMoveNegative.Click += new System.EventHandler(this.buttonMoveNegative_Click);
            // 
            // buttonMovePositive
            // 
            this.buttonMovePositive.Location = new System.Drawing.Point(136, 107);
            this.buttonMovePositive.Name = "buttonMovePositive";
            this.buttonMovePositive.Size = new System.Drawing.Size(32, 23);
            this.buttonMovePositive.TabIndex = 6;
            this.buttonMovePositive.Text = "+";
            this.buttonMovePositive.UseVisualStyleBackColor = true;
            this.buttonMovePositive.Click += new System.EventHandler(this.buttonMovePositive_Click);
            // 
            // numericUpDownStepSize
            // 
            this.numericUpDownStepSize.Location = new System.Drawing.Point(50, 110);
            this.numericUpDownStepSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStepSize.Name = "numericUpDownStepSize";
            this.numericUpDownStepSize.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownStepSize.TabIndex = 7;
            this.numericUpDownStepSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonRun
            // 
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.Location = new System.Drawing.Point(12, 12);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(156, 31);
            this.buttonRun.TabIndex = 8;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // numericUpDownScanSpeed
            // 
            this.numericUpDownScanSpeed.Location = new System.Drawing.Point(12, 159);
            this.numericUpDownScanSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownScanSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScanSpeed.Name = "numericUpDownScanSpeed";
            this.numericUpDownScanSpeed.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownScanSpeed.TabIndex = 9;
            this.numericUpDownScanSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownStartSpeed
            // 
            this.numericUpDownStartSpeed.Location = new System.Drawing.Point(12, 198);
            this.numericUpDownStartSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStartSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStartSpeed.Name = "numericUpDownStartSpeed";
            this.numericUpDownStartSpeed.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownStartSpeed.TabIndex = 10;
            this.numericUpDownStartSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownStartPosition
            // 
            this.numericUpDownStartPosition.Location = new System.Drawing.Point(12, 237);
            this.numericUpDownStartPosition.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownStartPosition.Name = "numericUpDownStartPosition";
            this.numericUpDownStartPosition.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownStartPosition.TabIndex = 11;
            // 
            // numericUpDownScanLength
            // 
            this.numericUpDownScanLength.Location = new System.Drawing.Point(12, 276);
            this.numericUpDownScanLength.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownScanLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownScanLength.Name = "numericUpDownScanLength";
            this.numericUpDownScanLength.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownScanLength.TabIndex = 12;
            this.numericUpDownScanLength.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Scan Speed (mm/s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Move To Start Speed (mm/s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Scan Start Position (mm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Scan Length (mm)";
            // 
            // ZaberControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownScanLength);
            this.Controls.Add(this.numericUpDownStartPosition);
            this.Controls.Add(this.numericUpDownStartSpeed);
            this.Controls.Add(this.numericUpDownScanSpeed);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.numericUpDownStepSize);
            this.Controls.Add(this.buttonMovePositive);
            this.Controls.Add(this.buttonMoveNegative);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.GetPort);
            this.Name = "ZaberControler";
            this.Text = "Zaber Controller";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScanSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScanLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetPort;
        private System.Windows.Forms.Label labelPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonMoveNegative;
        private System.Windows.Forms.Button buttonMovePositive;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NumericUpDown numericUpDownStepSize;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.NumericUpDown numericUpDownScanSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownStartSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownStartPosition;
        private System.Windows.Forms.NumericUpDown numericUpDownScanLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

