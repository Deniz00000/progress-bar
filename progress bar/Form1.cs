using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progress_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
            int cemil = Convert.ToInt32(textBox1.Text);
            progressBar1.Value = cemil;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata:"+ex.Message);
               
            }


        }
    }
}
