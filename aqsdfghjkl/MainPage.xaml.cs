namespace aqsdfghjkl;

public partial class MainPage : ContentPage
{
    private bool IsRunning = false;

    public MainPage()
    {
        InitializeComponent();
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateColor();
    }

    private void Slider_ValueChanged_1(object sender, ValueChangedEventArgs e)
    {
        UpdateColor();
    }

    private void Slider_ValueChanged_2(object sender, ValueChangedEventArgs e)
    {
        UpdateColor();
    }
    public void UpdateColor()
    {
        Color clr = Color.FromHsv(Convert.ToByte(Red.Value),
        Convert.ToByte(Green.Value), Convert.ToByte(Blue.Value));
        Rect.Fill = new SolidColorBrush(clr);
    }

























    //private async void Button_Clicked(object sender, EventArgs e)
    //{

    //    if (!IsRunning)
    //    {
    //        PB.Progress = 0d;
    //        IsRunning = true;
    //        for (int i = 0; i <= 100; i++)
    //        {
    //            PB.Progress = i / 100.0;
    //            await Task.Delay(1);
    //            if (i == 100)
    //            {
    //                await DisplayAlert("Info", "Stahování dokončeno!", "Finish");

    //            }
    //        }
    //        IsRunning = !IsRunning;
    //    }

    //}



    //private void Button_Clicked(object sender, EventArgs e)
    //{
    //   // DisplayAlert($"Jméno je: ", $"{LBL.Text}", "OK");

    //    if(AI.IsRunning == true) 
    //    {
    //        AI.IsRunning = false;
    //    }
    //    else
    //    {
    //        AI.IsRunning = true;
    //    }
    //}

    //private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    LBL.Text = e.NewTextValue;
    //}


}

