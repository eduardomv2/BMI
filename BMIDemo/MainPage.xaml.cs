namespace BMIDemo
{
    public partial class MainPage : ContentPage
    {
        const double UnderweightThreshold = 18.5;
        const double NormalweightThreshold = 24.9;
        const double OverweightThreshold = 29.9;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var weight = double.Parse(Weight.Text);
            var height = double.Parse(Height.Text) / 100;
            var bmi = weight / (height * height);

            BMI.Text = bmi.ToString("F2");

             
            string result = GetBmiResultMessage(bmi);
            DisplayAlert("Result", result, "Ok");

        }

        private string GetBmiResultMessage(double bmi)
        {
            if (bmi < UnderweightThreshold)
            {
                return "You have low Weight";
            }
            else if (bmi <= NormalweightThreshold)
            {
                return "Your weight is normal";
            }
            else if (bmi <= OverweightThreshold)
            {
                return "You are overweight";
            }
            else
            {
                return "You have obesity";
            }
        }
    }

}
