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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string Rot(int r, string inp)
        {
            Dictionary<int, char> m = new Dictionary<int, char>();
            string test = "abcdefghijklmnopqrstuvwxyz0123456789.";
            for (int i = 0; i < test.Length; i++) //map all the alphabet characters to the corresponding number
            {
                m.Add(i, test[i]);
            }
            string str = "";
            for (int j = 0; j < inp.Length; j++) //starts at 1 to skip the space between the rotation number and string input
            {
                char c = inp[j];
                if (char.IsLetterOrDigit(c) || c == '.')
                {
                    c = char.ToLower(c);
                    int key = 0;
                    foreach (KeyValuePair<int,char>it in m)
                    {
                        if (it.Value == c)
                        {
                            key = it.Key; //finds the key for the character
                            break;
                        }
                    }
                    key += r; //adds the rotation to the key
                    key = key % 37; //key mod 37
                    if (key < 0) //if key is negative bring back in the range
                        key += 37;
                    char o = m[key];
                    o = char.ToUpper(o);
			str += o;
                }
                else
			str += c;
            }
            return str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Plaintext.Text == "" || Rotation.Text == "")
            {
                MessageBox.Show("Enter plaintext or rotation value!");
            }
            else
            {
                try
                {
                    int temp = int.Parse(Rotation.Text);
                    Ciphertext.Text = Rot(temp, Plaintext.Text);
                }
                catch
                {
                    MessageBox.Show("Enter plaintext or rotation value!");
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
