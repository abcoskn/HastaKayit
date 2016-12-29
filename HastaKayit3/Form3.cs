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
    public partial class Form3 : Form
    {
        public Form3()
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

            int i = 0, j = 0;
            foreach (string line in File.ReadLines(path))//txtdeki satırları döndüren döngü
            {
                if (j < 5)
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

        private void Form3_Load(object sender, EventArgs e)
        {

            diziyaz();
            for (int i = 0; i < kisisayisi; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < 6; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = kisiler[i, j];
                }
            }
        }
    }
}
