namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;

        }
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 3, 2, 4, };
            int[] sortedNumbers = ProceduralSort(numbers);
            listBoxResult.DataSource = sortedNumbers;
        }

       
    }
}
