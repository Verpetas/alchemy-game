using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Scraper;

namespace GraphProg
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1(@"C:\Users\renat\Desktop\jsons\combos.json");
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                Scraper.Scraper.HTMLGetter(comboBox1.SelectedItem.ToString(), @"C:\Users\renat\Desktop\jsons\combos.json");
        }
    }
}
