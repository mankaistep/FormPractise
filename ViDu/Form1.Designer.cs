namespace ViDu {
    partial class BaiTap1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(47, 170);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(135, 62);
            this.btnC1.TabIndex = 0;
            this.btnC1.Text = "Cách 1";
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.onButtonC1Click);
            // 
            // btnC2
            // 
            this.btnC2.Location = new System.Drawing.Point(199, 170);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(135, 62);
            this.btnC2.TabIndex = 0;
            this.btnC2.Text = "Cách 2";
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.onButtonC2Click);
            // 
            // btnC3
            // 
            this.btnC3.Location = new System.Drawing.Point(353, 170);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(135, 62);
            this.btnC3.TabIndex = 0;
            this.btnC3.Text = "Cách 3";
            this.btnC3.UseVisualStyleBackColor = true;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(185, 91);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(163, 22);
            this.tbInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Số";
            // 
            // BaiTap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Name = "BaiTap1";
            this.Text = "Form Bai Tap Skrrt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
    }
}

