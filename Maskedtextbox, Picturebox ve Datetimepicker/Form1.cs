namespace Maskedtextbox__Picturebox_ve_Datetimepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Telefon mumaranýz: " + MskTel.Text);
            listBox1.Items.Add("T.C. Kimlik Numaranýz:" + MskTC.Text);
            listBox1.Items.Add("Tarih: " + MskDate.Text);
            listBox1.Items.Add("Saat: " + MskTime.Text);
            listBox1.Items.Add("Tarih ve Gün: " + dateTimePicker1.Text);
        }
    }
}