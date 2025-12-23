using Tyuiu.ZamyakinaOA.Sprint6.Task1.V8.Lib;
using System.Windows.Forms.VisualStyles;

namespace Tyuiu.ZamyakinaOA.Sprint6.Task1.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {
            Class1 ds = new Class1();
            try
            {
                int start = Convert.ToInt32(textBox1.Text);
                int stop = Convert.ToInt32(textBox2.Text);
                string str;
                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                textBox3.Text = "";
                textBox3.AppendText("+-----------+----------+" + Environment.NewLine);
                textBox3.AppendText("+    X      +    F(x)  +" + Environment.NewLine);
                textBox3.AppendText("+-----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {

                    str = String.Format("|{0,7:d}   |{1, 7:f2}   |", start, value[i]);
                    textBox3.AppendText(str + Environment.NewLine);
                    start++;
                }
                textBox3.AppendText("+-----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
