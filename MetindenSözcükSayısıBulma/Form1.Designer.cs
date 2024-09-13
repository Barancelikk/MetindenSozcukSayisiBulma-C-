namespace MetindenSözcükSayısıBulma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btn_Ara = new Button();
            txt_Sözcük = new TextBox();
            txt_Metin = new RichTextBox();
            lbl_Adet = new Label();
            lbl_Sonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(517, 26);
            label1.TabIndex = 0;
            label1.Text = "Aşağıdaki Metinde Adedini Merak Ettiğiniz Sözcüğü Giriniz :";
            // 
            // btn_Ara
            // 
            btn_Ara.ForeColor = SystemColors.ActiveCaptionText;
            btn_Ara.Location = new Point(606, 105);
            btn_Ara.Name = "btn_Ara";
            btn_Ara.Size = new Size(77, 33);
            btn_Ara.TabIndex = 1;
            btn_Ara.Text = "Ara";
            btn_Ara.UseVisualStyleBackColor = true;
            btn_Ara.Click += btn_Ara_Click;
            // 
            // txt_Sözcük
            // 
            txt_Sözcük.Location = new Point(559, 68);
            txt_Sözcük.Name = "txt_Sözcük";
            txt_Sözcük.Size = new Size(171, 31);
            txt_Sözcük.TabIndex = 2;
            // 
            // txt_Metin
            // 
            txt_Metin.BackColor = Color.Bisque;
            txt_Metin.Location = new Point(13, 246);
            txt_Metin.Name = "txt_Metin";
            txt_Metin.ReadOnly = true;
            txt_Metin.Size = new Size(839, 411);
            txt_Metin.TabIndex = 3;
            txt_Metin.Text = resources.GetString("txt_Metin.Text");
            txt_Metin.TextChanged += richTextBox1_TextChanged;
            // 
            // lbl_Adet
            // 
            lbl_Adet.AutoSize = true;
            lbl_Adet.BackColor = Color.LightCoral;
            lbl_Adet.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Adet.Location = new Point(13, 188);
            lbl_Adet.Margin = new Padding(4, 0, 4, 0);
            lbl_Adet.Name = "lbl_Adet";
            lbl_Adet.Size = new Size(136, 26);
            lbl_Adet.TabIndex = 4;
            lbl_Adet.Text = "Sözcük Adedi :";
            // 
            // lbl_Sonuc
            // 
            lbl_Sonuc.AutoSize = true;
            lbl_Sonuc.Location = new Point(156, 190);
            lbl_Sonuc.Name = "lbl_Sonuc";
            lbl_Sonuc.Size = new Size(0, 23);
            lbl_Sonuc.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(870, 699);
            Controls.Add(lbl_Sonuc);
            Controls.Add(lbl_Adet);
            Controls.Add(txt_Metin);
            Controls.Add(txt_Sözcük);
            Controls.Add(btn_Ara);
            Controls.Add(label1);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Ara;
        private TextBox txt_Sözcük;
        private RichTextBox txt_Metin;
        private Label lbl_Adet;
        private Label lbl_Sonuc;
    }
}
