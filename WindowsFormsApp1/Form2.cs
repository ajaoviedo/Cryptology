using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Plaintext.Text == "")
            {
                MessageBox.Show("Enter plaintext!");
            }
            else
            {
                try
                {
                    Ciphertext.Text = Strip(Plaintext.Text);
                }
                catch
                {
                    MessageBox.Show("Enter plaintext!");
                }
            }
        }

        private void CLR_Click(object sender, EventArgs e)
        {
            Plaintext.Text = "";
            Ciphertext.Text = "";
        }

        private String Strip(string inp)
        {
            string o = "";
            for (int i = 0; i < inp.Length; i++)
            {
                char c = inp[i];
                if (char.IsUpper(c))
                    c = char.ToLower(c);
                if (char.IsLetterOrDigit(c) || c == '.')
                    o += c; //adds lowercase alphanumeric or period character to big string			
            }
            return o;
        }
    }
}
