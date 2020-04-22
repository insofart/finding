namespace finding
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.edt_identificator = new System.Windows.Forms.TextBox();
            this.btn_findIdentificator = new System.Windows.Forms.Button();
            this.lbl_indIdIdentificator = new System.Windows.Forms.Label();
            this.lbl_indIdIdentificator2 = new System.Windows.Forms.Label();
            this.lbl_timer1 = new System.Windows.Forms.Label();
            this.lbl_timer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Формируем список идентификаторов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 368);
            this.listBox1.TabIndex = 2;
            // 
            // edt_identificator
            // 
            this.edt_identificator.Location = new System.Drawing.Point(217, 74);
            this.edt_identificator.Name = "edt_identificator";
            this.edt_identificator.Size = new System.Drawing.Size(100, 20);
            this.edt_identificator.TabIndex = 3;
            // 
            // btn_findIdentificator
            // 
            this.btn_findIdentificator.Location = new System.Drawing.Point(335, 74);
            this.btn_findIdentificator.Name = "btn_findIdentificator";
            this.btn_findIdentificator.Size = new System.Drawing.Size(75, 23);
            this.btn_findIdentificator.TabIndex = 4;
            this.btn_findIdentificator.Text = "Найти";
            this.btn_findIdentificator.UseVisualStyleBackColor = true;
            this.btn_findIdentificator.Click += new System.EventHandler(this.btn_findIdentificator_Click);
            // 
            // lbl_indIdIdentificator
            // 
            this.lbl_indIdIdentificator.AutoSize = true;
            this.lbl_indIdIdentificator.Location = new System.Drawing.Point(430, 74);
            this.lbl_indIdIdentificator.Name = "lbl_indIdIdentificator";
            this.lbl_indIdIdentificator.Size = new System.Drawing.Size(35, 13);
            this.lbl_indIdIdentificator.TabIndex = 5;
            this.lbl_indIdIdentificator.Text = "label2";
            // 
            // lbl_indIdIdentificator2
            // 
            this.lbl_indIdIdentificator2.AutoSize = true;
            this.lbl_indIdIdentificator2.Location = new System.Drawing.Point(430, 96);
            this.lbl_indIdIdentificator2.Name = "lbl_indIdIdentificator2";
            this.lbl_indIdIdentificator2.Size = new System.Drawing.Size(35, 13);
            this.lbl_indIdIdentificator2.TabIndex = 6;
            this.lbl_indIdIdentificator2.Text = "label2";
            // 
            // lbl_timer1
            // 
            this.lbl_timer1.AutoSize = true;
            this.lbl_timer1.Location = new System.Drawing.Point(620, 74);
            this.lbl_timer1.Name = "lbl_timer1";
            this.lbl_timer1.Size = new System.Drawing.Size(35, 13);
            this.lbl_timer1.TabIndex = 7;
            this.lbl_timer1.Text = "label2";
            // 
            // lbl_timer2
            // 
            this.lbl_timer2.AutoSize = true;
            this.lbl_timer2.Location = new System.Drawing.Point(620, 96);
            this.lbl_timer2.Name = "lbl_timer2";
            this.lbl_timer2.Size = new System.Drawing.Size(35, 13);
            this.lbl_timer2.TabIndex = 8;
            this.lbl_timer2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_timer2);
            this.Controls.Add(this.lbl_timer1);
            this.Controls.Add(this.lbl_indIdIdentificator2);
            this.Controls.Add(this.lbl_indIdIdentificator);
            this.Controls.Add(this.btn_findIdentificator);
            this.Controls.Add(this.edt_identificator);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox edt_identificator;
        private System.Windows.Forms.Button btn_findIdentificator;
        private System.Windows.Forms.Label lbl_indIdIdentificator;
        private System.Windows.Forms.Label lbl_indIdIdentificator2;
        private System.Windows.Forms.Label lbl_timer1;
        private System.Windows.Forms.Label lbl_timer2;
        private System.Windows.Forms.Label label1;
    }
}

