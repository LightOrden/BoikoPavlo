

namespace komand
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxIn = new TextBox();
            textBoxOut = new TextBox();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnBackSP = new Button();
            btnRightBr = new Button();
            btnLeftBr = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDiv = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnChangeSign = new Button();
            btn0 = new Button();
            btnMultpl = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            button17 = new Button();
            button21 = new Button();
            btnOutBuf = new Button();
            btnAddBuf = new Button();
            btnClearBuf = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Expression";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Result";
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(120, 17);
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(291, 27);
            textBoxIn.TabIndex = 2;
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(120, 66);
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.Size = new Size(291, 27);
            textBoxOut.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnBackSP);
            groupBox1.Controls.Add(btnRightBr);
            groupBox1.Controls.Add(btnLeftBr);
            groupBox1.Location = new Point(25, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 87);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editing";
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(294, 26);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 50);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackSP
            // 
            btnBackSP.ForeColor = Color.Red;
            btnBackSP.Location = new Point(162, 26);
            btnBackSP.Name = "btnBackSP";
            btnBackSP.Size = new Size(126, 50);
            btnBackSP.TabIndex = 2;
            btnBackSP.Text = "Backspace";
            btnBackSP.UseVisualStyleBackColor = true;
            btnBackSP.Click += btnBackSP_Click;
            // 
            // btnRightBr
            // 
            btnRightBr.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRightBr.Location = new Point(72, 28);
            btnRightBr.Name = "btnRightBr";
            btnRightBr.Size = new Size(51, 50);
            btnRightBr.TabIndex = 1;
            btnRightBr.Text = ")";
            btnRightBr.UseVisualStyleBackColor = true;
            btnRightBr.Click += btnRightBr_Click;
            // 
            // btnLeftBr
            // 
            btnLeftBr.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLeftBr.Location = new Point(15, 28);
            btnLeftBr.Name = "btnLeftBr";
            btnLeftBr.Size = new Size(51, 50);
            btnLeftBr.TabIndex = 0;
            btnLeftBr.Text = "(";
            btnLeftBr.UseVisualStyleBackColor = true;
            btnLeftBr.Click += btnLeftBr_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn1.Location = new Point(40, 232);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 50);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn2.Location = new Point(97, 232);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 50);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn3.Location = new Point(154, 232);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 50);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.ForeColor = Color.Red;
            btnDiv.Location = new Point(211, 232);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(54, 50);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn4.Location = new Point(40, 288);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 50);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn5.Location = new Point(97, 288);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 50);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn6.Location = new Point(154, 288);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 50);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn7.Location = new Point(40, 344);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 50);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn8.Location = new Point(97, 344);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 50);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn9.Location = new Point(154, 344);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 50);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnChangeSign
            // 
            btnChangeSign.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnChangeSign.Location = new Point(40, 400);
            btnChangeSign.Name = "btnChangeSign";
            btnChangeSign.Size = new Size(51, 50);
            btnChangeSign.TabIndex = 13;
            btnChangeSign.Text = "+/-";
            btnChangeSign.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn0.Location = new Point(97, 400);
            btn0.Name = "btn0";
            btn0.Size = new Size(51, 50);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnMultpl
            // 
            btnMultpl.ForeColor = Color.Red;
            btnMultpl.Location = new Point(211, 288);
            btnMultpl.Name = "btnMultpl";
            btnMultpl.Size = new Size(54, 50);
            btnMultpl.TabIndex = 16;
            btnMultpl.Text = "*";
            btnMultpl.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.ForeColor = Color.Red;
            btnMinus.Location = new Point(211, 344);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(54, 50);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.ForeColor = Color.Red;
            btnPlus.Location = new Point(211, 400);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(54, 50);
            btnPlus.TabIndex = 18;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.ForeColor = Color.Red;
            button17.Location = new Point(151, 400);
            button17.Name = "button17";
            button17.Size = new Size(54, 50);
            button17.TabIndex = 19;
            button17.Text = "mod";
            button17.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.ForeColor = Color.Red;
            button21.Location = new Point(342, 404);
            button21.Name = "button21";
            button21.Size = new Size(54, 50);
            button21.TabIndex = 20;
            button21.Text = "=";
            button21.UseVisualStyleBackColor = true;
            // 
            // btnOutBuf
            // 
            btnOutBuf.ForeColor = Color.Blue;
            btnOutBuf.Location = new Point(342, 232);
            btnOutBuf.Name = "btnOutBuf";
            btnOutBuf.Size = new Size(54, 50);
            btnOutBuf.TabIndex = 23;
            btnOutBuf.Text = "MR";
            btnOutBuf.UseVisualStyleBackColor = true;
            // 
            // btnAddBuf
            // 
            btnAddBuf.ForeColor = Color.Blue;
            btnAddBuf.Location = new Point(342, 288);
            btnAddBuf.Name = "btnAddBuf";
            btnAddBuf.Size = new Size(54, 50);
            btnAddBuf.TabIndex = 24;
            btnAddBuf.Text = "M+";
            btnAddBuf.UseVisualStyleBackColor = true;
            // 
            // btnClearBuf
            // 
            btnClearBuf.ForeColor = Color.Blue;
            btnClearBuf.Location = new Point(342, 344);
            btnClearBuf.Name = "btnClearBuf";
            btnClearBuf.Size = new Size(54, 50);
            btnClearBuf.TabIndex = 25;
            btnClearBuf.Text = "MC";
            btnClearBuf.UseVisualStyleBackColor = true;
            btnClearBuf.Click += btnClearBuf_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 473);
            Controls.Add(btnClearBuf);
            Controls.Add(btnAddBuf);
            Controls.Add(btnOutBuf);
            Controls.Add(button21);
            Controls.Add(button17);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnMultpl);
            Controls.Add(btn0);
            Controls.Add(btnChangeSign);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDiv);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(groupBox1);
            Controls.Add(textBoxOut);
            Controls.Add(textBoxIn);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calc";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLeftBr_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRightBr_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBackSP_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnBackSP;
        private Button btnRightBr;
        private Button btnLeftBr;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDiv;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnChangeSign;
        private Button btn0;
        private Button btnMultpl;
        private Button btnMinus;
        private Button btnPlus;
        private Button button17;
        private Button button21;
        private Button btnOutBuf;
        private Button btnAddBuf;
        private Button btnClearBuf;
    }
}
