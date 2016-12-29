using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaKayit3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "hasta.txt";
        int kisisayisi = 0;
        string[,] kisiler;

        void diziyaz()
        {
            {//kişisay
                int say = 0;
                foreach (string line in File.ReadLines(path))
                {
                    say++;
                }
                kisisayisi = say / 6;
                kisiler = new string[kisisayisi, 6];
            }

            int i=0, j=0;
            foreach (string line in File.ReadLines(path))//txtdeki satırları döndüren döngü
            {
                if(j<5)
                {
                    kisiler[i, j] = line;
                    j++;
                }
                else
                {
                    kisiler[i, j] = line;
                    j = 0;
                    i++;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            string createText="";
            for (int i=0;i<kisisayisi;i++)
                id = Convert.ToInt32(kisiler[i, 0]) + 1;
            for(int i=0;i<kisisayisi;i++)
            {
                for(int j=0;j<6;j++)
                {
                    createText =createText+ kisiler[i, j] + Environment.NewLine;
                }
            }
            createText = createText + id.ToString() + Environment.NewLine+ textBox1.Text + Environment.NewLine + textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + textBox4.Text + Environment.NewLine + textBox5.Text;
            File.WriteAllText(path, createText);
            MessageBox.Show("Kayıt başarıyla eklendi!");
            diziyaz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diziyaz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
