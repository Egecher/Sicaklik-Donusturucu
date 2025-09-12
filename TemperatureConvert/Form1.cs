namespace TemperatureConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTemperature.Text)) { 
                    MessageBox.Show("Sýcaklýk deðeri boþ olamaz!",
                        "Uyarý!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!double.TryParse(txtTemperature.Text, out double inputTemperature)) 
                { 
                    MessageBox.Show("Lütfen geçerli bir sayý girin!",
                        "Hata!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                //double inputTemperature = double.Parse(txtTemperature.Text);

                double convertedTemperature = 0;

                if (rbtnCtoF.Checked)
                {
                    convertedTemperature = (inputTemperature * 9 / 5) + 32;

                    lblResult.Text = $"Sonuç: {convertedTemperature} °F";
                }
                else if (rbtnFtoC.Checked) {
                    convertedTemperature = (inputTemperature - 32) * 5 / 9;

                    lblResult.Text = $"Sonuç: {convertedTemperature} °C";
                } else
                {
                    MessageBox.Show("Lütfen bir dönüþüm türü seçin!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Hata oluþtu: {ex.Message}");
            }
        }
    }
}
