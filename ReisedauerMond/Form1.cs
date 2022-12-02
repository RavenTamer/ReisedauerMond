namespace ReisedauerMond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void calculate_Click(object sender, EventArgs e)
        {
            double speedKmh = Convert.ToDouble(speedbox.Value);
            Mondreise moon = new Mondreise(speedKmh);
            if (radiodays.Checked == true)
            {
                resultbox.Text = Convert.ToString(moon.GetTravelDurationDays());
            }
            else if (radiohours.Checked == true)
            {
                resultbox.Text = Convert.ToString(moon.GetTravelDurationHours());
            }
        }
    }
}