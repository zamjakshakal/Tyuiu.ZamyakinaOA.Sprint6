using Tyuiu.ZamyakinaOA.Sprint6.Task0.V13.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint6.Task0.V13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ds = new Class1();
            try
            {
                textBox2.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox1.Text)));
            }
            catch
            {
                MessageBox.Show("error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
