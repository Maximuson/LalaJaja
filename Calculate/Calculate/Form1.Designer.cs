namespace Calculate
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
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.bttnPlus = new System.Windows.Forms.Button();
            this.bttnMinus = new System.Windows.Forms.Button();
            this.bttnMult = new System.Windows.Forms.Button();
            this.bttnDavid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(254, 96);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(188, 135);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 1;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(125, 96);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 2;
            // 
            // bttnPlus
            // 
            this.bttnPlus.Location = new System.Drawing.Point(125, 67);
            this.bttnPlus.Name = "bttnPlus";
            this.bttnPlus.Size = new System.Drawing.Size(75, 23);
            this.bttnPlus.TabIndex = 3;
            this.bttnPlus.Text = "+";
            this.bttnPlus.UseVisualStyleBackColor = true;
            this.bttnPlus.Click += new System.EventHandler(this.bttnPlus_Click);
            // 
            // bttnMinus
            // 
            this.bttnMinus.Location = new System.Drawing.Point(125, 38);
            this.bttnMinus.Name = "bttnMinus";
            this.bttnMinus.Size = new System.Drawing.Size(75, 23);
            this.bttnMinus.TabIndex = 4;
            this.bttnMinus.Text = "-";
            this.bttnMinus.UseVisualStyleBackColor = true;
            this.bttnMinus.Click += new System.EventHandler(this.bttnMinus_Click);
            // 
            // bttnMult
            // 
            this.bttnMult.Location = new System.Drawing.Point(206, 67);
            this.bttnMult.Name = "bttnMult";
            this.bttnMult.Size = new System.Drawing.Size(75, 23);
            this.bttnMult.TabIndex = 5;
            this.bttnMult.Text = "*";
            this.bttnMult.UseVisualStyleBackColor = true;
            // 
            // bttnDavid
            // 
            this.bttnDavid.Location = new System.Drawing.Point(206, 38);
            this.bttnDavid.Name = "bttnDavid";
            this.bttnDavid.Size = new System.Drawing.Size(75, 23);
            this.bttnDavid.TabIndex = 6;
            this.bttnDavid.Text = "/";
            this.bttnDavid.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnDavid);
            this.Controls.Add(this.bttnMult);
            this.Controls.Add(this.bttnMinus);
            this.Controls.Add(this.bttnPlus);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button bttnPlus;
        private System.Windows.Forms.Button bttnMinus;
        private System.Windows.Forms.Button bttnMult;
        private System.Windows.Forms.Button bttnDavid;
    }
}

