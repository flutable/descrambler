namespace Descramble597
{
    partial class Descrambler
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
            this.tbxScrambled = new System.Windows.Forms.TextBox();
            this.tbxDescrambled = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblSizeLabel = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.udStrip = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.udBlocksize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBlocksize)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxScrambled
            // 
            this.tbxScrambled.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScrambled.Location = new System.Drawing.Point(12, 37);
            this.tbxScrambled.Multiline = true;
            this.tbxScrambled.Name = "tbxScrambled";
            this.tbxScrambled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxScrambled.Size = new System.Drawing.Size(911, 265);
            this.tbxScrambled.TabIndex = 0;
            // 
            // tbxDescrambled
            // 
            this.tbxDescrambled.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescrambled.Location = new System.Drawing.Point(12, 438);
            this.tbxDescrambled.Multiline = true;
            this.tbxDescrambled.Name = "tbxDescrambled";
            this.tbxDescrambled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescrambled.Size = new System.Drawing.Size(911, 298);
            this.tbxDescrambled.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 318);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(162, 41);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // lblSizeLabel
            // 
            this.lblSizeLabel.AutoSize = true;
            this.lblSizeLabel.Location = new System.Drawing.Point(14, 369);
            this.lblSizeLabel.Name = "lblSizeLabel";
            this.lblSizeLabel.Size = new System.Drawing.Size(100, 20);
            this.lblSizeLabel.TabIndex = 4;
            this.lblSizeLabel.Text = "Size (bytes): ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(120, 329);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 20);
            this.lblSize.TabIndex = 5;
            // 
            // udStrip
            // 
            this.udStrip.Location = new System.Drawing.Point(222, 341);
            this.udStrip.Name = "udStrip";
            this.udStrip.Size = new System.Drawing.Size(120, 26);
            this.udStrip.TabIndex = 6;
            this.udStrip.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Strip x bytes from start";
            // 
            // udBlocksize
            // 
            this.udBlocksize.Location = new System.Drawing.Point(12, 768);
            this.udBlocksize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udBlocksize.Name = "udBlocksize";
            this.udBlocksize.Size = new System.Drawing.Size(120, 26);
            this.udBlocksize.TabIndex = 8;
            this.udBlocksize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udBlocksize.ValueChanged += new System.EventHandler(this.UdBlocksize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 739);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Block size; click up/down to descramble according to block size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descrambled text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Scrambled text";
            // 
            // Descrambler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 802);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.udBlocksize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udStrip);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblSizeLabel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbxDescrambled);
            this.Controls.Add(this.tbxScrambled);
            this.Name = "Descrambler";
            this.Text = "DeScrambler ITC597";
            ((System.ComponentModel.ISupportInitialize)(this.udStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBlocksize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxScrambled;
        private System.Windows.Forms.TextBox tbxDescrambled;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblSizeLabel;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown udStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udBlocksize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

