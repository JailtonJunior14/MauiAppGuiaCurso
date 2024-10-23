namespace MauiAppGuiaCurso.Disciplinas;

public partial class ProgramacaoW : ContentPage
{
	public ProgramacaoW()
	{
		InitializeComponent();

    }

	protected override void OnAppearing()
    {

        base.OnAppearing();

        if (BindingContext is string[] conteudoWeb)
        {
            lblTitulo.Text = conteudoWeb[0];
            lblConteudo.Text = conteudoWeb[1];
        } 
    }
}