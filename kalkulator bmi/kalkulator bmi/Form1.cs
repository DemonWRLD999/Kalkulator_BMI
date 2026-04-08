namespace kalkulator_bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressbar.Maximum = 60;
        }
 
        private void obliczbtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(wzrosttxt.Text, out double wzrost))
            {
                if (double.TryParse(wagatxt.Text, out double waga))
                {
                    double bmi = Math.Round (waga / (wzrost * wzrost),2);
                    progressbar.Value = (int)bmi;
                    obliczanie.Text = "Twoje BMI: " + bmi.ToString("0.00");
                    if(bmi < 16.0) {
                        progbmi.Text = "Wygłodzenie";
                    }
                    else if (bmi < 16.99)
                    {
                        progbmi.Text = "Wychudzenie";
                    }
                    else if(bmi < 18.49)
                    {
                        progbmi.Text = "Niedowaga";
                    }
                    else if(bmi < 24.99)
                    {
                        progbmi.Text = "Prawidłowa Waga";
                    }
                    else if (bmi < 29.99)
                    {
                        progbmi.Text = "Nadwaga";
                    }
                    else if (bmi < 34.99)
                    {
                        progbmi.Text = "Otyłość I Stopnia";
                    }
                    else if (bmi < 39.99)
                    {
                        progbmi.Text = "Otyłość II Stopnia";
                    }
                    else
                    {
                        progbmi.Text = "Otyłość III Stopnia";
                    }
                }
            }
            else
            {
                
            }
            
        } 
    }
}
