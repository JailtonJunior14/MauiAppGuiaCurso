namespace MauiAppGuiaCurso.Disciplinas;

public partial class DesenvolvimentoDS : ContentPage
{
	public DesenvolvimentoDS()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {

        base.OnAppearing();

        if (BindingContext is string[] conteudoDS)
        {

            lblTitulo.Text = conteudoDS[0];
            lblConteudo.Text = conteudoDS[1];
        }
    }
}