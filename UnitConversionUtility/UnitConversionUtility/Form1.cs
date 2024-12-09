namespace UnitConversionUtility
{
    public partial class Form1 : Form
    {
        int weight = 0;
        int volume = 0;
        string typeOfConversion = string.Empty;
        void readFile()
        {
            try
            {
                StreamReader convertData = new StreamReader("conversionData.txt");
                string firstLine = convertData.ReadLine();
                string secondLine = convertData.ReadLine();
                weight = Convert.ToInt32(firstLine.Substring(7, firstLine.Length - 7));
                volume = Convert.ToInt32(secondLine.Substring(7, secondLine.Length - 7));
                if (firstLine.Substring(0, 7).Contains("Pounds"))
                {
                    txt_Pounds.Text = weight.ToString();
                    typeOfConversion = "Pounds";
                }
                else if (firstLine.Substring(0, 7).Contains("Kilo"))
                {
                    txt_Kilos.Text = weight.ToString();
                    typeOfConversion = "Kilos";
                }
                else if (firstLine.Substring(0, 7).Contains("Ton"))
                {
                    txt_Tons.Text = weight.ToString();
                    typeOfConversion = "Tons";
                }
            }
            catch(FormatException) {
                MessageBox.Show("Wrong input in txt file conversionData.txt");
            }
        }
        public Form1()
        {
            InitializeComponent();
            readFile();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            switch (typeOfConversion) { 
                case "Pounds":
                    txt_Kilos.Text = (double.Parse(txt_Pounds.Text) / 2.205).ToString();
                    txt_Tons.Text = (double.Parse(txt_Pounds.Text) / 2000).ToString();
                    break;
                case "Kilos":
                    txt_Pounds.Text = (double.Parse(txt_Kilos.Text) * 2.205).ToString();
                    txt_Tons.Text = (double.Parse(txt_Kilos.Text) / 907.2).ToString();
                    break;
                case "Tons":
                    txt_Pounds.Text = (double.Parse(txt_Tons.Text) * 2000).ToString();
                    txt_Kilos.Text = (double.Parse(txt_Tons.Text) * 907.2).ToString();
                    break;
            }
        }
    }
}
