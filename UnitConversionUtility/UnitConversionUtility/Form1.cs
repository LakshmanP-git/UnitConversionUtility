namespace UnitConversionUtility
{
    public partial class Form1 : Form
    {
        int weight = 0;
        int volume = 0;
        void readLine() {
            using (StreamReader convertData = new StreamReader("conversionData.txt")) {
                string firstLine = convertData.ReadLine();
                string secondLine = convertData.ReadLine();
                weight = Convert.ToInt32(firstLine.Substring(7, firstLine.Length - 7));
                volume = Convert.ToInt32(secondLine.Substring(7, secondLine.Length - 7));
            }
        }
        public Form1()
        {
            InitializeComponent();
            readLine();
        }
    }
}
