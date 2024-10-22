using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso.Anos;

public partial class Segundo : ContentPage
{
	public Segundo()
	{
		InitializeComponent();
	}

    private void DesenvolvimentoS_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new DesenvolvimentoDS());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void BancoII_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Banco());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void WEBII_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ProgramacaoW());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void Mobile_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Mobile());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }
}
