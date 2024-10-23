namespace MauiAppGuiaCurso.Disciplinas;

public partial class Algoritimos : ContentPage
{
    public Algoritimos()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {

        base.OnAppearing();

        if (BindingContext is string[] conteudoAlg)
        {

            lblTitulo.Text = conteudoAlg[0];
            lblConteudo.Text = conteudoAlg[1];
        }
    }
}