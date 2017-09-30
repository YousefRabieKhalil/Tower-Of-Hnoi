using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tower_OF_Hanoi
{
    public partial class Form1 : Form
    {
        int number;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            SolveHanoiUsinRec(number, 1, 3, 2);
               
        }
        void SolveHanoiUsinRec(int NumberOfPalate, int source, int Destination, int inter)
        {
            if (NumberOfPalate == 1)
                listBox1.Items.Add(source.ToString() + "   " + Destination.ToString());

            else
            {
                SolveHanoiUsinRec(NumberOfPalate - 1, source, inter, Destination);
                SolveHanoiUsinRec(1, source, Destination, inter);
                SolveHanoiUsinRec(NumberOfPalate - 1, inter, Destination, source);
            }
        }
    }
}
