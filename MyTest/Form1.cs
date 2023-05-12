namespace MyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double resultNum = double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text);
            txtRes.Text = resultNum.ToString();
        }
    }
}