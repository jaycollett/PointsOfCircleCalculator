namespace PointsOfCircleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericOriginX = new System.Windows.Forms.NumericUpDown();
            this.numericOriginY = new System.Windows.Forms.NumericUpDown();
            this.numericRadius = new System.Windows.Forms.NumericUpDown();
            this.numericNumberOfPoints = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericOriginX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOriginY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(387, 429);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 51);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 223);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(532, 200);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Origin of X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Origin of Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number Of Points";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Calculated Points";
            // 
            // numericOriginX
            // 
            this.numericOriginX.DecimalPlaces = 2;
            this.numericOriginX.Location = new System.Drawing.Point(15, 39);
            this.numericOriginX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericOriginX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericOriginX.Name = "numericOriginX";
            this.numericOriginX.Size = new System.Drawing.Size(120, 20);
            this.numericOriginX.TabIndex = 1;
            // 
            // numericOriginY
            // 
            this.numericOriginY.DecimalPlaces = 2;
            this.numericOriginY.Location = new System.Drawing.Point(15, 78);
            this.numericOriginY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericOriginY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericOriginY.Name = "numericOriginY";
            this.numericOriginY.Size = new System.Drawing.Size(120, 20);
            this.numericOriginY.TabIndex = 2;
            // 
            // numericRadius
            // 
            this.numericRadius.DecimalPlaces = 2;
            this.numericRadius.Location = new System.Drawing.Point(15, 120);
            this.numericRadius.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRadius.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericRadius.Name = "numericRadius";
            this.numericRadius.Size = new System.Drawing.Size(120, 20);
            this.numericRadius.TabIndex = 3;
            // 
            // numericNumberOfPoints
            // 
            this.numericNumberOfPoints.Location = new System.Drawing.Point(15, 159);
            this.numericNumberOfPoints.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericNumberOfPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumberOfPoints.Name = "numericNumberOfPoints";
            this.numericNumberOfPoints.Size = new System.Drawing.Size(120, 20);
            this.numericNumberOfPoints.TabIndex = 4;
            this.numericNumberOfPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 492);
            this.Controls.Add(this.numericNumberOfPoints);
            this.Controls.Add(this.numericRadius);
            this.Controls.Add(this.numericOriginY);
            this.Controls.Add(this.numericOriginX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCalculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Points Of A Circle Calculator (v 1.0) written by Jay Collett (www.jaycollett.com)" +
    "";
            ((System.ComponentModel.ISupportInitialize)(this.numericOriginX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOriginY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericOriginX;
        private System.Windows.Forms.NumericUpDown numericOriginY;
        private System.Windows.Forms.NumericUpDown numericRadius;
        private System.Windows.Forms.NumericUpDown numericNumberOfPoints;
    }
}

