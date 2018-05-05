using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tablouri_Bidimensionale
{
    public partial class Form1 : Form
    {
        int n;
        string[,] a = new string[10, 10];
        string[,] b = new string[10, 10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void afisare_Click(object sender, EventArgs e)
        {
            string aa = "";
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    aa += a[i, j];
                    aa += " ";
                }

                aa += Environment.NewLine;
            }
            this.textBox27.Text = aa;
        }

        private void chenar_Click(object sender, EventArgs e)
        {
            string aa = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || j == 1 || i == n  || j == n )
                        aa += a[i, j];
                     aa += " ";
                }

                aa += Environment.NewLine;
            }
            this.textBox27.Text = aa;
        }

        private void vecini_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            
            Random rnd = new Random();

            int x, y;
            x = rnd.Next(1, n);
            y = rnd.Next(1, n);
            label1.Text="Vecinii a["+x+","+y+"] sunt:"+Environment.NewLine+"Vecinul de deasupra este : " + a[x - 1, y]+ Environment.NewLine
                +"Vecinul din dreapta este :" + a[x, y + 1]+ Environment.NewLine+"Vecinul din stanga este :" + a[x, y - 1]+ 
                Environment.NewLine+"Vecinul de sub este :" + a[x + 1, y]+ Environment.NewLine;

        }


        private void rotire_180_Click(object sender, EventArgs e)
        {
            rotireST();
            rotireST();
            afis(a);
        }

        private void rotireST()
        {
            string aux;
            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                for (int j = i; j <= (n + 1) / 2; j++)
                {
                    aux = a[i, j];
                    a[i, j] = a[j, n + 1 - i];
                    a[j, n + 1 - i] = a[n + 1 - i, n + 1 - j];
                    a[n + 1 - i, n + 1 - j] = a[n + 1 - j, i];
                    a[n + 1 - j, i] = aux;
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            TextBox[] mat6 = { textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10,
                               textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17,
                               textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25, textBox26 };

            foreach (TextBox tb in mat6)
            {
                tb.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            n = 1;
            TextBox[] mat1 = { textBox2 };

            foreach (TextBox tb in mat1)
            {
                tb.Visible=true;
            }

            a[n, n] = textBox2.Text;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            n = 2;
            int k = 0;
            TextBox[] mat2 = { textBox2, textBox3, textBox7, textBox8 };

            foreach(TextBox tb in mat2)
            {
                tb.Visible = true;
            }

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    a[i, j] = mat2[k].Text;
                    k++;
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            n = 3;
            int k = 0;
            TextBox[] mat3 = { textBox2, textBox3, textBox4, textBox7, textBox8, textBox9, textBox12, textBox13, textBox14 };

            foreach (TextBox tb in mat3)
            {
                tb.Visible = true;
            }

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    a[i, j] = mat3[k].Text;
                    k++;
                }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            clear();
            n = 4;
            int k = 0;
            TextBox[] mat4 = { textBox2, textBox3, textBox4, textBox5, textBox7, textBox8, textBox9,
                                textBox10, textBox12, textBox13, textBox14, textBox15, textBox17, textBox18, textBox19, textBox20 };
            foreach (TextBox tb in mat4)
            {
                tb.Visible = true;
            }

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    a[i, j] = mat4[k].Text;
                    k++;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
            n = 5;
            int k = 0;
            TextBox[] mat5 = { textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10,
                               textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18,
                               textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25, textBox26 };

            foreach (TextBox tb in mat5)
            {
                tb.Visible = true; ;
            }

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                {
                    a[i, j] = mat5[k].Text;
                    k++;
                }
        }

        private void afis(string [,]a)
        {
            string aa = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    aa += a[i, j];
                    aa += " ";
                }

                aa += Environment.NewLine;
            }
            this.textBox27.Text = aa;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rotire_dreapta_Click(object sender, EventArgs e)
        {
            rotireDR();
        }

        private void rotireDR()
        {

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    b[j, n + 1 - i] = a[i, j];
            afis(b);
        }

        private void rotire_stanga_Click(object sender, EventArgs e)
        {
            string aux;

            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                for (int j = i; j <= (n + 1) / 2; j++)
                {
                    aux = a[i, j];
                    a[i, j] = a[j, n + 1 - i];
                    a[j, n + 1 - i] = a[n + 1 - i, n + 1 - j];
                    a[n + 1 - i, n + 1 - j] = a[n + 1 - j, i];
                    a[n + 1 - j, i] = aux;
                }
            }
            afis(a);
        }

        private void diag_sec_Click(object sender, EventArgs e)
        {
            string aa = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == n + 1 ) aa += a[i, j];
                    else aa += "  ";
                    aa += "  ";
                }
                aa += Environment.NewLine;
            }
            this.textBox27.Text = aa;
        }

        private void diag_prin_Click(object sender, EventArgs e)
        {
            string aa = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == j) aa += a[i, j];
                    aa += "  ";
                }
                aa += Environment.NewLine;
            }
            this.textBox27.Text = aa;
        }

        private void suma_Click(object sender, EventArgs e)
        {
            int s = 0;

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    s = s + Convert.ToInt32(a[i, j]);

            this.textBox27.Text = s.ToString();

        }

        private void sus_diag_prin_Click(object sender, EventArgs e)
        {
            string aa = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i < j) aa += a[i, j];
                    else aa += "  ";
                    aa += "  ";
                }
                aa += Environment.NewLine;
            }
            this.textBox27.Text = aa;
        }

        private void jos_diag_prin_Click(object sender, EventArgs e)
        {
            string aa = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i > j) aa += a[i, j];
                    else aa += " ";
                    aa += " ";
                }
                aa += Environment.NewLine;
            }
            this.textBox27.Text = aa;
        }

        private void sus_diag_sec_Click(object sender, EventArgs e)
        {
            string aa = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j < n + 1) aa += a[i, j];
                    else aa += " ";
                    aa += " ";
                }
                aa += Environment.NewLine;
            }
            this.textBox27.Text = aa;
        }

        private void sub_diag_sec_Click(object sender, EventArgs e)
        {
            string aa = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j > n + 1) aa += a[i, j];
                    else aa += " ";
                    aa += " ";
                }
                aa += Environment.NewLine;
            }
            this.textBox27.Text = aa;
        }

        private void ordo_Click(object sender, EventArgs e)
        {
            int i, j, k = 0, aux;
            bool ok;
            int[] v = new int[26];

            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                {
                    v[++k] = Convert.ToInt32(a[i, j]);
                    
                }
            
            do
            {
                ok = false;
                for (i = 1; i < k; i++)
                    if (v[i] < v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = true;
                    }
            } while (ok);

            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = Convert.ToString(v[k]);
                    k--;
                }
 
            afis(a);
        }

        private void prod_Click(object sender, EventArgs e)
        {
            int p = 1;

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    p = p * Convert.ToInt32(a[i, j]);

            this.textBox27.Text = p.ToString();
        }

        private void minmax_Click(object sender, EventArgs e)
        {
            int max = int.MinValue, min = int.MaxValue; 
            for(int i=1;i<= n;i++)
                for(int j=1;j<= n;j++)
                {
                    if (Convert.ToInt32(a[i, j]) > max) max = Convert.ToInt32(a[i, j]);
                    if (Convert.ToInt32(a[i, j]) < min) min = Convert.ToInt32(a[i, j]);
                }
            
            MessageBox.Show("Maximul este :" + Convert.ToString(max)+"\n"+"Minimul este :" +Convert.ToString(min));
        }
    }
}

