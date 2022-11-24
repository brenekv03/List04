using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = int.Parse(textBox1.Text);
            List<int> list = new List<int>();
            Random random = new Random();
            int min = 101;
            int max = -101;
            int indexMin = 0;
            int indexMax = 0;
            for(int i = 0; i < n; i++)
            {
                list.Add(random.Next(-100,101));
                int cislo = list[i];
                listBox1.Items.Add(cislo);
                if(cislo%3==0&&cislo<min)
                {
                    indexMin = i;
                    min = cislo;
                }
                if(cislo%2==0&&cislo>max)
                {
                    indexMax = i;
                    max = cislo;
                }
            }
            list[indexMin] = max;
            list[indexMax] = min;
            foreach(int x in list)
            {
                listBox2.Items.Add(x);
            }
        }
    }
}
