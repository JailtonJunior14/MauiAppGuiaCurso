using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso.Anos;

public partial class Primeiro : ContentPage
{

    string[][] conteudosWeb = new string[3][];
    string[][] conteudosBD = new string[2][];

    public Primeiro()
    {
        InitializeComponent();

        conteudosWeb[0] = new string[] { "Programação WEB I", "Introdução ao Desenvolvimento Web: \r\n " +
            "Nesta primeira fase, os alunos são apresentados aos fundamentos do desenvolvimento de páginas web. Isso inclui o estudo de HTML (para a estruturação de conteúdo), CSS (para a estilização e layout das páginas) e o básico de JavaScript (para a interação com o usuário).\r\n" +
            "Conceitos básicos de Front-End: O foco é garantir que os alunos compreendam como construir interfaces básicas, criar páginas responsivas, e entender como os navegadores processam e exibem páginas da web." };
        conteudosWeb[1] = new string[] { "Programação WEB I", "b" };
        conteudosWeb[2] = new string[] { "web 3", "c" };

        conteudosBD[0] = new string[] { "Banco de Dados I", "Modelagem de dados: Criação de diagramas entidade-relacionamento (DER) para representar dados." +
            "\r\nSQL (Structured Query Language): Manipulação de dados com comandos como SELECT, INSERT, UPDATE, DELETE." +
            "\r\nNormalização de dados: Organização para eliminar redundâncias e garantir a integridade dos dados." +
            "\r\nCriação de tabelas e relações: Implementação de estruturas relacionais e uso de chaves primárias e estrangeiras." +
            "\r\nFerramentas: MySQL Workbench e PostgreSQL." +
            "\r\nO objetivo é capacitar os alunos a planejar, criar e manipular bancos de dados de forma eficiente, formando a base para projetos futuros."};
        conteudosBD[1] = new string[] { "", "" };
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

    public void WEB_Clicked(object sender, EventArgs e)
    {
        try
        {
            string[] conteudoWeb = conteudosWeb[0];



            Navigation.PushAsync(new ProgramacaoW
            {
                BindingContext = conteudoWeb
            });
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
            string[] conteudoBD = conteudosBD[0];



            Navigation.PushAsync(new Banco
            {
                BindingContext = conteudoBD
            });
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