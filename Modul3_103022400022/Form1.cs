namespace Modul3_103022400022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cmbSatuanAwal.SelectedItem == null || cmbSatuanAkhir.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan Terlebih dahulu!");
                return;
            }
            if (!double.TryParse(txtNilaiAwal.Text, out double nilaiAwal))
            {
                MessageBox.Show("Masukan Angka yang valid!");
                return;
            }
            string satuanAwal = cmbSatuanAwal.SelectedItem.ToString();
            string satuanAkhir = cmbSatuanAkhir.SelectedItem.ToString();
            double celsius;
            switch (satuanAwal)
            {
                case "Celsius": celsius = nilaiAwal; break;
                case "Fahrenheit": celsius = (nilaiAwal - 32) * 5 / 9; break;
                case "Kelvin": celsius = nilaiAwal - 273.15; break;
                case "Reamur": celsius = nilaiAwal * 5 / 4; break;
               


            }
            double hasil;
            switch (satuanAkhir)
            {
                case "Celsius": hasil = celsius; break;
                case "Fahrenheit": hasil = (celsius - 32) * 5 / 9; break;
                case "Kelvin": hasil = celsius - 273.15; break;
                case "Reamur": hasil = celsius * 5 / 4; break;
                default: hasil = celsius; break;

            }
            txtNilaiAkhir.Text = hasil.ToString("F2");
        }
    }
}
