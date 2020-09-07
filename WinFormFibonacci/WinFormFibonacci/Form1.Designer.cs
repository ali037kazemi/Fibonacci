namespace WinFormFibonacci {
    partial class FormFibonacci {
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
            this.gBoxFiboNumbers = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxFiboNumbers
            // 
            this.gBoxFiboNumbers.Location = new System.Drawing.Point(234, 12);
            this.gBoxFiboNumbers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gBoxFiboNumbers.Name = "gBoxFiboNumbers";
            this.gBoxFiboNumbers.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gBoxFiboNumbers.Size = new System.Drawing.Size(237, 411);
            this.gBoxFiboNumbers.TabIndex = 0;
            this.gBoxFiboNumbers.TabStop = false;
            this.gBoxFiboNumbers.Text = "اعداد فیبوناچی";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 93);
            this.txtInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(107, 23);
            this.txtInput.TabIndex = 1;
            this.txtInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "تعداد اعداد دنباله را وارد کنید:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(78, 154);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // FormFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 435);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.gBoxFiboNumbers);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormFibonacci";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Fibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.txtInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFiboNumbers;
        private System.Windows.Forms.NumericUpDown txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
    }
}

