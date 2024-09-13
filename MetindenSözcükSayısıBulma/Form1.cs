using System.Windows.Forms;

namespace MetindenSözcükSayısıBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            {
              
                string kelime = txt_Sözcük.Text.Trim();

                
                if (string.IsNullOrEmpty(kelime))
                {
                    MessageBox.Show("Lütfen bir kelime girin!");
                    return;
                }
                string metin = txt_Metin.Text;

                
                int sayac = 0;
                int index = 0;

                
                while ((index = metin.IndexOf(kelime, index, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    sayac++;
                    index += kelime.Length;
                }

               
                lbl_Sonuc.Text = $"{kelime}, Sözcüğü metin içinde {sayac} kez geçiyor.";
                lbl_Sonuc.ForeColor = Color.White;
            }
        }
    }

}
  
