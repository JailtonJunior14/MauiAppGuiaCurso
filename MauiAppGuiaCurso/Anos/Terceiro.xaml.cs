using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso.Anos;

public partial class Terceiro : ContentPage
{
	public Terceiro()
	{
		InitializeComponent();
	}

    private void Qualidade_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new QaulidadeTS());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void Protocolo_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new InternetP());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void WEBIII_Clicked(object sender, EventArgs e)
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

    private void MobileII_Clicked(object sender, EventArgs e)
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

    private void Embarcados_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new SistemasEmb());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void TCC_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new TCC());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }
}