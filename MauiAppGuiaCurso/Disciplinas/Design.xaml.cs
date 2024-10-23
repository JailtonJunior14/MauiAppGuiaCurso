namespace MauiAppGuiaCurso.Disciplinas;

public partial class Design : ContentPage
{
	public Design()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {

        base.OnAppearing();

        if (BindingContext is string[] conteudoD)
        {

            lblTitulo.Text = conteudoD[0];
            lblConteudo.Text = conteudoD[1];
        }
    }
}