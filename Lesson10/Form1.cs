using Lesson10.Goods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson10
{
    public partial class Form1 : Form
    {
        private Lorry lorry;
        public Form1()
        {
            InitializeComponent();
            lorry = new Lorry(500);
        }

        private void btn_DoSmth_Click(object sender, EventArgs e)
        {
            int bCount = int.Parse(tb_bCount.Text);
            if (bCount > 0)
            {
                Book book = new Book(tb_bName.Text, double.Parse(tb_bWeight.Text));
                for (int i = 0; i < bCount; i++)
                    lorry.Add(book);
            }
            int dCount = int.Parse(tb_dCount.Text);
            if (dCount > 0)
            {
                Disc disc = new Disc(tb_dName.Text, double.Parse(tb_dWeight.Text));
                for (int i = 0; i < dCount; i++)
                    lorry.Add(disc);
            }
            MessageBox.Show(String.Format("В грузовике {0} товаров", lorry.items.Count));
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lorry.items[1].Print());
        }
    }
}
