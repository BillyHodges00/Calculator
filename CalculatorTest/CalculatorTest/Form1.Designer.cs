namespace CalculatorTest
{
    partial class calcMainWindow
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
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.btnNumOne = new System.Windows.Forms.Button();
            this.btnNumTwo = new System.Windows.Forms.Button();
            this.btnNumThree = new System.Windows.Forms.Button();
            this.btnNumSix = new System.Windows.Forms.Button();
            this.btnNumFive = new System.Windows.Forms.Button();
            this.btnNumFour = new System.Windows.Forms.Button();
            this.btnNumNine = new System.Windows.Forms.Button();
            this.btnNumEight = new System.Windows.Forms.Button();
            this.btnNumSeven = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNumZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Enabled = false;
            this.txtBoxOutput.Location = new System.Drawing.Point(12, 28);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(207, 29);
            this.txtBoxOutput.TabIndex = 0;
            this.txtBoxOutput.Text = "0";
            this.txtBoxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxOutput.TextChanged += new System.EventHandler(this.txtBoxOutput_TextChanged);
            // 
            // btnNumOne
            // 
            this.btnNumOne.Location = new System.Drawing.Point(12, 72);
            this.btnNumOne.Name = "btnNumOne";
            this.btnNumOne.Size = new System.Drawing.Size(40, 35);
            this.btnNumOne.TabIndex = 1;
            this.btnNumOne.Text = "1";
            this.btnNumOne.UseVisualStyleBackColor = true;
            this.btnNumOne.Click += new System.EventHandler(this.btnNumOne_Click);
            // 
            // btnNumTwo
            // 
            this.btnNumTwo.Location = new System.Drawing.Point(58, 72);
            this.btnNumTwo.Name = "btnNumTwo";
            this.btnNumTwo.Size = new System.Drawing.Size(40, 35);
            this.btnNumTwo.TabIndex = 2;
            this.btnNumTwo.Text = "2";
            this.btnNumTwo.UseVisualStyleBackColor = true;
            this.btnNumTwo.Click += new System.EventHandler(this.btnNumTwo_Click);
            // 
            // btnNumThree
            // 
            this.btnNumThree.Location = new System.Drawing.Point(104, 72);
            this.btnNumThree.Name = "btnNumThree";
            this.btnNumThree.Size = new System.Drawing.Size(40, 35);
            this.btnNumThree.TabIndex = 3;
            this.btnNumThree.Text = "3";
            this.btnNumThree.UseVisualStyleBackColor = true;
            this.btnNumThree.Click += new System.EventHandler(this.btnNumThree_Click);
            // 
            // btnNumSix
            // 
            this.btnNumSix.Location = new System.Drawing.Point(104, 113);
            this.btnNumSix.Name = "btnNumSix";
            this.btnNumSix.Size = new System.Drawing.Size(40, 35);
            this.btnNumSix.TabIndex = 7;
            this.btnNumSix.Text = "6";
            this.btnNumSix.UseVisualStyleBackColor = true;
            this.btnNumSix.Click += new System.EventHandler(this.btnNumSix_Click);
            // 
            // btnNumFive
            // 
            this.btnNumFive.Location = new System.Drawing.Point(58, 113);
            this.btnNumFive.Name = "btnNumFive";
            this.btnNumFive.Size = new System.Drawing.Size(40, 35);
            this.btnNumFive.TabIndex = 6;
            this.btnNumFive.Text = "5";
            this.btnNumFive.UseVisualStyleBackColor = true;
            this.btnNumFive.Click += new System.EventHandler(this.btnNumFive_Click);
            // 
            // btnNumFour
            // 
            this.btnNumFour.Location = new System.Drawing.Point(12, 113);
            this.btnNumFour.Name = "btnNumFour";
            this.btnNumFour.Size = new System.Drawing.Size(40, 35);
            this.btnNumFour.TabIndex = 5;
            this.btnNumFour.Text = "4";
            this.btnNumFour.UseVisualStyleBackColor = true;
            this.btnNumFour.Click += new System.EventHandler(this.btnNumFour_Click);
            // 
            // btnNumNine
            // 
            this.btnNumNine.Location = new System.Drawing.Point(104, 154);
            this.btnNumNine.Name = "btnNumNine";
            this.btnNumNine.Size = new System.Drawing.Size(40, 35);
            this.btnNumNine.TabIndex = 10;
            this.btnNumNine.Text = "9";
            this.btnNumNine.UseVisualStyleBackColor = true;
            this.btnNumNine.Click += new System.EventHandler(this.btnNumNine_Click);
            // 
            // btnNumEight
            // 
            this.btnNumEight.Location = new System.Drawing.Point(58, 154);
            this.btnNumEight.Name = "btnNumEight";
            this.btnNumEight.Size = new System.Drawing.Size(40, 35);
            this.btnNumEight.TabIndex = 9;
            this.btnNumEight.Text = "8";
            this.btnNumEight.UseVisualStyleBackColor = true;
            this.btnNumEight.Click += new System.EventHandler(this.btnNumEight_Click);
            // 
            // btnNumSeven
            // 
            this.btnNumSeven.Location = new System.Drawing.Point(12, 154);
            this.btnNumSeven.Name = "btnNumSeven";
            this.btnNumSeven.Size = new System.Drawing.Size(40, 35);
            this.btnNumSeven.TabIndex = 8;
            this.btnNumSeven.Text = "7";
            this.btnNumSeven.UseVisualStyleBackColor = true;
            this.btnNumSeven.Click += new System.EventHandler(this.btnNumSeven_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(149, 72);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(70, 35);
            this.btnBackspace.TabIndex = 11;
            this.btnBackspace.Text = "Backspace";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(149, 113);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(70, 35);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(149, 154);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(70, 35);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(12, 236);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(116, 35);
            this.btnEquals.TabIndex = 14;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(149, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(103, 195);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(40, 35);
            this.btnMinus.TabIndex = 16;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(134, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 35);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNumZero
            // 
            this.btnNumZero.Location = new System.Drawing.Point(58, 195);
            this.btnNumZero.Name = "btnNumZero";
            this.btnNumZero.Size = new System.Drawing.Size(40, 35);
            this.btnNumZero.TabIndex = 18;
            this.btnNumZero.Text = "0";
            this.btnNumZero.UseVisualStyleBackColor = true;
            this.btnNumZero.Click += new System.EventHandler(this.btnNumZero_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(12, 195);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(40, 35);
            this.btnDecimal.TabIndex = 19;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // calcMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 281);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNumZero);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnNumNine);
            this.Controls.Add(this.btnNumEight);
            this.Controls.Add(this.btnNumSeven);
            this.Controls.Add(this.btnNumSix);
            this.Controls.Add(this.btnNumFive);
            this.Controls.Add(this.btnNumFour);
            this.Controls.Add(this.btnNumThree);
            this.Controls.Add(this.btnNumTwo);
            this.Controls.Add(this.btnNumOne);
            this.Controls.Add(this.txtBoxOutput);
            this.MaximumSize = new System.Drawing.Size(248, 320);
            this.Name = "calcMainWindow";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Button btnNumOne;
        private System.Windows.Forms.Button btnNumTwo;
        private System.Windows.Forms.Button btnNumThree;
        private System.Windows.Forms.Button btnNumSix;
        private System.Windows.Forms.Button btnNumFive;
        private System.Windows.Forms.Button btnNumFour;
        private System.Windows.Forms.Button btnNumNine;
        private System.Windows.Forms.Button btnNumEight;
        private System.Windows.Forms.Button btnNumSeven;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNumZero;
        private System.Windows.Forms.Button btnDecimal;
    }
}

