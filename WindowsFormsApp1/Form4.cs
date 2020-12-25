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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private String Pad(int a, string s)
        {
            Dictionary<int, char> m = new Dictionary<int, char>();
            string test = "abcdefghijklmnopqrstuvwxyz0123456789.";
            for (int i = 0; i < test.Length; i++) //map all the alphabet characters to the corresponding number
            {
                m.Add(i, test[i]);
            }
            string str = ""; //build the output string that ignores unnecessary characters and makes lowercase
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsLetterOrDigit(c) || c == '.')
                {
                    c = char.ToLower(c);
                    str += c;
                }
            }
            int numpad;
            if (a % 37 == 0 && a != 0)
                numpad = 37;
            else
                numpad = a%37;
            char ch;
            if (numpad == 37)
                ch = m[0]; //choose 'a' for 37 padded
            else
                ch = m[numpad]; //choose corresponding symbol for 1-36

            for (int j = numpad; j > 0; j--)
            {
                str += ch; //add corresponding symbol however many times necessary
            }

            return str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Plaintext.Text == "" || Rotation.Text == "")
            {
                MessageBox.Show("Enter plaintext or pad value!");
            }
            else
            {
                try
                {
                    int temp = int.Parse(Rotation.Text);
                    Ciphertext.Text = Pad(temp, Plaintext.Text);
                }
                catch
                {
                    MessageBox.Show("Enter plaintext or pad value!");
                }
            }
        }

        private void CLR_Click(object sender, EventArgs e)
        {
            Plaintext.Text = "";
            Rotation.Text = "";
            Ciphertext.Text = "";
        }
    }
}
