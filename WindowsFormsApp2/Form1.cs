using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[,] dizi = new byte[4, 4];
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random(); 
            int satirRastgele = rastgele.Next(4);
            int sutunRastgele = rastgele.Next(4); 
            dizi[satirRastgele, sutunRastgele] = 1; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte satir = byte.Parse(txtSatir.Text);
            byte sutun = byte.Parse(txtSutun.Text);
            PictureBox kutu = this.Controls.Find("p"+satir + sutun, true)[0] as PictureBox;
            byte durum = dizi[satir, sutun];
            if (durum == 0)
            { kutu.BackColor = Color.Green; }
            else
            { kutu.BackColor = Color.Red; }
        }
    }
}
