namespace bmiCalculator;

public partial class MainPage : ContentPage
{
    double height;
    double weight;
    double bmi;
    string bmiText;


    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.height = Height.Value;
        this.weight = Weight.Value;
        this.bmi = weight / Math.Pow(height / 100, 2);
        bmiresult.Text = bmi.ToString();

        if (bmi < 18.5)
        {
            bmiText = "Under weight";
        }
        else if (bmi < 25 && bmi > 18.5)
        {
            bmiText = "Proper weight";
        }
        else if (bmi < 25 && bmi < 29.9)
        {
            bmiText = "Over weight";
        }
        else if (bmi > 30)
        {
            bmiText = "obesity";
        }

        bmitext.Text = bmiText.ToString();

    }

}

