namespace ViDu {
    partial class CalculatorForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.tbSecondValue = new System.Windows.Forms.RichTextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bEnter = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.bDivide = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.tbFirstValue = new System.Windows.Forms.RichTextBox();
            this.tbOperator = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMainValue
            // 
            this.tbSecondValue.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecondValue.Location = new System.Drawing.Point(12, 12);
            this.tbSecondValue.Name = "tbMainValue";
            this.tbSecondValue.ReadOnly = true;
            this.tbSecondValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSecondValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbSecondValue.Size = new System.Drawing.Size(484, 96);
            this.tbSecondValue.TabIndex = 0;
            this.tbSecondValue.Text = "0";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 182);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(70, 70);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 258);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(70, 70);
            this.b4.TabIndex = 1;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 334);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(70, 70);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(88, 334);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(70, 70);
            this.b8.TabIndex = 1;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(88, 258);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(70, 70);
            this.b5.TabIndex = 1;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(88, 182);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(70, 70);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(164, 182);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(70, 70);
            this.b3.TabIndex = 1;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(164, 258);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(70, 70);
            this.b6.TabIndex = 1;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(164, 334);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(70, 70);
            this.b9.TabIndex = 1;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(419, 182);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(77, 222);
            this.bEnter.TabIndex = 1;
            this.bEnter.Text = "ENTER";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.OnEnterClick);
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(240, 182);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(70, 70);
            this.bPlus.TabIndex = 1;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // bSub
            // 
            this.bSub.Location = new System.Drawing.Point(316, 182);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(70, 70);
            this.bSub.TabIndex = 1;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // bMulti
            // 
            this.bMulti.Location = new System.Drawing.Point(240, 258);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(70, 70);
            this.bMulti.TabIndex = 1;
            this.bMulti.Text = "*";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // bDivide
            // 
            this.bDivide.Location = new System.Drawing.Point(316, 258);
            this.bDivide.Name = "bDivide";
            this.bDivide.Size = new System.Drawing.Size(70, 70);
            this.bDivide.TabIndex = 1;
            this.bDivide.Text = "/";
            this.bDivide.UseVisualStyleBackColor = true;
            this.bDivide.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(316, 334);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(70, 70);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "CLEAR";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.OnClearClick);
            // 
            // tbSubValue
            // 
            this.tbFirstValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstValue.Location = new System.Drawing.Point(205, 114);
            this.tbFirstValue.Name = "tbSubValue";
            this.tbFirstValue.ReadOnly = true;
            this.tbFirstValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbFirstValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbFirstValue.Size = new System.Drawing.Size(290, 26);
            this.tbFirstValue.TabIndex = 2;
            this.tbFirstValue.Text = "0";
            // 
            // tbOperator
            // 
            this.tbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperator.Location = new System.Drawing.Point(184, 114);
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.ReadOnly = true;
            this.tbOperator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbOperator.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbOperator.Size = new System.Drawing.Size(15, 26);
            this.tbOperator.TabIndex = 2;
            this.tbOperator.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnNumberClick);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbFirstValue);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bDivide);
            this.Controls.Add(this.bMulti);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tbSecondValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPER CALCULATOR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbSecondValue;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button bDivide;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.RichTextBox tbFirstValue;
        private System.Windows.Forms.RichTextBox tbOperator;
        private System.Windows.Forms.Button button1;
    }
}