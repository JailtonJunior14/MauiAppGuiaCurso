namespace MauiAppGuiaCurso.Disciplinas;

public partial class Analise : ContentPage
{
	public Analise()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {

        base.OnAppearing();

        if (BindingContext is string[] conteudoA)
        {

            lblTitulo.Text = conteudoA[0];
            lblConteudo.Text = conteudoA[1];
        }
    }
}