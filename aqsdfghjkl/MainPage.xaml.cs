namespace aqsdfghjkl;

public partial class MainPage : ContentPage
{
    private bool IsRunning = false;

    public MainPage()
    {
        InitializeComponent();
    }

    

    
    public void UpdateColor()
    {
        string RedHex = Convert.ToInt32(Red.Value).ToString("X");
        string GreenHex = Convert.ToInt32(Green.Value).ToString("X");
        string BlueHex = Convert.ToInt32(Blue.Value).ToString("X");


        Color clr = Color.FromRgb(Convert.ToByte(Red.Value),
        Convert.ToByte(Green.Value), Convert.ToByte(Blue.Value));
        Rect.Fill = new SolidColorBrush(clr);
        RGBLBL.Text = $"#{RedHex}{GreenHex}{BlueHex}";
        LBL.Text = $"{Convert.ToInt32(Red.Value)}, {Convert.ToInt32(Green.Value)}, {Convert.ToInt32(Blue.Value)}";
    }

    private void Blue_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateColor();
    }

    private void Green_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateColor();
    }

    private void Red_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateColor();
    }

    private void BTN_Clicked(object sender, EventArgs e)
    {
        int RedInt = Convert.ToInt32(Red.Value);
        int GreenInt = Convert.ToInt32(Green.Value);
        int BlueInt = Convert.ToInt32(Blue.Value);

        BTN.BackgroundColor = Color.FromRgb(RedInt, GreenInt, BlueInt);
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

