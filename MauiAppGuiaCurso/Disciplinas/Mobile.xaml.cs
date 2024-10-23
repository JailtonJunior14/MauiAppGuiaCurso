namespace MauiAppGuiaCurso.Disciplinas;

public partial class Mobile : ContentPage
{
	public Mobile()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is string[] conteudoM)
        {

            lblTitulo.Text = conteudoM[0];
            lblConteudo.Text = conteudoM[1];
        }
    }
}