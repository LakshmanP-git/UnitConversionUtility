namespace UnitConversionUtility
{
    public partial class Form1 : Form
    {
        bool dontRunHandler = true;
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
            catch (FormatException)
            {
                MessageBox.Show("Wrong input in txt file conversionData.txt");
            }
        }
        public Form1()
        {
            InitializeComponent();
            dontRunHandler = true;
            readFile();
            switch (typeOfConversion)
            {
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
            dontRunHandler = false;
        }

        string Calculation(string textOperatedOn, double numberToUse, char symbol) {
            try
            {
                double divisionCalculation = double.Parse(textOperatedOn) / numberToUse;
                double multiplicationCalculation = (double.Parse(textOperatedOn) * numberToUse);
                switch (symbol)
                {
                    case '*':
                        return multiplicationCalculation.ToString();
                    case '/':
                        return divisionCalculation.ToString();
                    default:
                        return "Error throwing text.";
                }
            }
            catch {
                return "";
            }
        }
        private void txt_Kilos_TextChanged(object sender, EventArgs e)
        {
            if (dontRunHandler) { return; }
            else
            {
                dontRunHandler = true;
                txt_Pounds.Text = Calculation(txt_Kilos.Text, 2.205, '*');
                txt_Tons.Text = Calculation(txt_Kilos.Text, 907.2, '/');
                dontRunHandler = false;
            }
        }

        private void txt_Pounds_TextChanged(object sender, EventArgs e)
        {
            if (dontRunHandler) { return; }
            else
            {
                dontRunHandler = true;
                txt_Kilos.Text = Calculation(txt_Pounds.Text, 2.205, '/');
                txt_Tons.Text = Calculation(txt_Pounds.Text, 2000, '/');
                dontRunHandler = false;
            }
        }

        private void txt_Tons_TextChanged(object sender, EventArgs e)
        {
            if (dontRunHandler) { return; } 
            else
            {
                txt_Pounds.Text = Calculation(txt_Tons.Text, 2000, '*');
                txt_Kilos.Text = Calculation(txt_Tons.Text, 907.2, '*');
            }
        }
    }
}
