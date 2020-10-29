namespace Asmx
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textX = new System.Windows.Forms.TextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.textAddResponse = new System.Windows.Forms.TextBox();
            this.textS = new System.Windows.Forms.TextBox();
            this.textD = new System.Windows.Forms.TextBox();
            this.textConcatResponse = new System.Windows.Forms.TextBox();
            this.textA1S = new System.Windows.Forms.TextBox();
            this.textA2S = new System.Windows.Forms.TextBox();
            this.textSumResponse = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonConcat = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textA2K = new System.Windows.Forms.TextBox();
            this.textA1K = new System.Windows.Forms.TextBox();
            this.textA2F = new System.Windows.Forms.TextBox();
            this.textA1F = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(26, 12);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(63, 20);
            this.textX.TabIndex = 0;
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(110, 12);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(61, 20);
            this.textY.TabIndex = 1;
            // 
            // textAddResponse
            // 
            this.textAddResponse.Location = new System.Drawing.Point(279, 12);
            this.textAddResponse.Name = "textAddResponse";
            this.textAddResponse.Size = new System.Drawing.Size(100, 20);
            this.textAddResponse.TabIndex = 2;
            // 
            // textS
            // 
            this.textS.Location = new System.Drawing.Point(25, 39);
            this.textS.Name = "textS";
            this.textS.Size = new System.Drawing.Size(64, 20);
            this.textS.TabIndex = 3;
            // 
            // textD
            // 
            this.textD.Location = new System.Drawing.Point(110, 39);
            this.textD.Name = "textD";
            this.textD.Size = new System.Drawing.Size(61, 20);
            this.textD.TabIndex = 4;
            // 
            // textConcatResponse
            // 
            this.textConcatResponse.Location = new System.Drawing.Point(279, 38);
            this.textConcatResponse.Name = "textConcatResponse";
            this.textConcatResponse.Size = new System.Drawing.Size(100, 20);
            this.textConcatResponse.TabIndex = 5;
            // 
            // textA1S
            // 
            this.textA1S.Location = new System.Drawing.Point(116, 128);
            this.textA1S.Name = "textA1S";
            this.textA1S.Size = new System.Drawing.Size(63, 20);
            this.textA1S.TabIndex = 6;
            // 
            // textA2S
            // 
            this.textA2S.Location = new System.Drawing.Point(201, 128);
            this.textA2S.Name = "textA2S";
            this.textA2S.Size = new System.Drawing.Size(61, 20);
            this.textA2S.TabIndex = 7;
            // 
            // textSumResponse
            // 
            this.textSumResponse.Location = new System.Drawing.Point(197, 227);
            this.textSumResponse.Name = "textSumResponse";
            this.textSumResponse.Size = new System.Drawing.Size(104, 20);
            this.textSumResponse.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(187, 9);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // buttonConcat
            // 
            this.buttonConcat.Location = new System.Drawing.Point(187, 37);
            this.buttonConcat.Name = "buttonConcat";
            this.buttonConcat.Size = new System.Drawing.Size(75, 23);
            this.buttonConcat.TabIndex = 10;
            this.buttonConcat.Text = "Concat";
            this.buttonConcat.UseVisualStyleBackColor = true;
            this.buttonConcat.Click += new System.EventHandler(this.Concat_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(116, 224);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(75, 23);
            this.buttonSum.TabIndex = 11;
            this.buttonSum.Text = "Sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(150, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Object A";
            // 
            // textA2K
            // 
            this.textA2K.Location = new System.Drawing.Point(201, 163);
            this.textA2K.Name = "textA2K";
            this.textA2K.Size = new System.Drawing.Size(61, 20);
            this.textA2K.TabIndex = 18;
            // 
            // textA1K
            // 
            this.textA1K.Location = new System.Drawing.Point(116, 163);
            this.textA1K.Name = "textA1K";
            this.textA1K.Size = new System.Drawing.Size(63, 20);
            this.textA1K.TabIndex = 17;
            // 
            // textA2F
            // 
            this.textA2F.Location = new System.Drawing.Point(201, 198);
            this.textA2F.Name = "textA2F";
            this.textA2F.Size = new System.Drawing.Size(61, 20);
            this.textA2F.TabIndex = 20;
            // 
            // textA1F
            // 
            this.textA1F.Location = new System.Drawing.Point(117, 198);
            this.textA1F.Name = "textA1F";
            this.textA1F.Size = new System.Drawing.Size(63, 20);
            this.textA1F.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(225, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "a2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(136, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "a1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "S";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "K";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "F";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Sum ASMX";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SumAsmx_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(23, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(356, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Check Request to ASMX Service";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 330);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textA2F);
            this.Controls.Add(this.textA1F);
            this.Controls.Add(this.textA2K);
            this.Controls.Add(this.textA1K);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonConcat);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textSumResponse);
            this.Controls.Add(this.textA2S);
            this.Controls.Add(this.textA1S);
            this.Controls.Add(this.textConcatResponse);
            this.Controls.Add(this.textD);
            this.Controls.Add(this.textS);
            this.Controls.Add(this.textAddResponse);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.textX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textAddResponse;
        private System.Windows.Forms.TextBox textS;
        private System.Windows.Forms.TextBox textD;
        private System.Windows.Forms.TextBox textConcatResponse;
        private System.Windows.Forms.TextBox textA1S;
        private System.Windows.Forms.TextBox textA2S;
        private System.Windows.Forms.TextBox textSumResponse;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonConcat;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textA2K;
        private System.Windows.Forms.TextBox textA1K;
        private System.Windows.Forms.TextBox textA2F;
        private System.Windows.Forms.TextBox textA1F;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}

