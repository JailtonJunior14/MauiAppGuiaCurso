namespace MauiAppGuiaCurso.Disciplinas;

public partial class Banco : ContentPage
{
    public Banco()
    {
        InitializeComponent();
    }
    protected override void OnAppearing()
    {

        base.OnAppearing();

        if (BindingContext is string[] conteudoBD)
        {

            lblTitulo.Text = conteudoBD[0];
            lblConteudo.Text = conteudoBD[1];
        }
    }
}