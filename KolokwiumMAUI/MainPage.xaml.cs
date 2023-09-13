namespace KolokwiumMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	public void ZmianaSuwaka(object sender, ValueChangedEventArgs e)
	{
		double wartosc = e.NewValue;
		etykietaWartosc.Text = ((int)wartosc).ToString();

        if (wartosc < 128)
        {
            etykietaWartosc.TextColor = Color.FromRgb(255, 0, 0);
        }
        else
        {
            etykietaWartosc.TextColor = Color.FromRgb(0, 0, 128);
        }
	}
	public void NacisnieciePrzycisku(object sender, EventArgs e)
	{
		suwak.Value = 0;
	}
}

