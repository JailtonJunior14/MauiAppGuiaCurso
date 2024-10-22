using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso.Anos;

public partial class Primeiro : ContentPage
{
	public Primeiro()
	{
		InitializeComponent();
	}

    private void Algoritimo_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Algoritimos());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void Analise_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Analise());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void WEB_Clicked(object sender, EventArgs e)
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

    private void Banco_Clicked(object sender, EventArgs e)
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

    private void Design_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Design());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void Fundamentos_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Fundamentos());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }
}