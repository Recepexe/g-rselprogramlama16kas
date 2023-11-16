using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult sonuc;
            sonuc = MessageBox.Show("Evet Butonuna Basarsanız Kayıt Silinecektir.\nKayıt Silinme İşlemini Onaylıyor musunuz?"
                , "DİKKAT"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1);

            if (sonuc == DialogResult.Yes)
            {
                MessageBox.Show("Kayıt Silindi.");
            }
            else
            {
                MessageBox.Show("kayıt silme işlemi iptal edildi.");
            }
        }
        }
    }

