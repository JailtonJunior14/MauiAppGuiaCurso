using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso.Anos;

public partial class Primeiro : ContentPage
{

    string[][] conteudosWeb = new string[3][];
    string[][] conteudosBD = new string[2][];

    public Primeiro()
    {
        InitializeComponent();

        conteudosWeb[0] = new string[] { "Programa��o WEB I", "Introdu��o ao Desenvolvimento Web: \r\n " +
            "Nesta primeira fase, os alunos s�o apresentados aos fundamentos do desenvolvimento de p�ginas web. Isso inclui o estudo de HTML (para a estrutura��o de conte�do), CSS (para a estiliza��o e layout das p�ginas) e o b�sico de JavaScript (para a intera��o com o usu�rio).\r\n" +
            "Conceitos b�sicos de Front-End: O foco � garantir que os alunos compreendam como construir interfaces b�sicas, criar p�ginas responsivas, e entender como os navegadores processam e exibem p�ginas da web." };
        conteudosWeb[1] = new string[] { "Programa��o WEB I", "b" };
        conteudosWeb[2] = new string[] { "web 3", "c" };

        conteudosBD[0] = new string[] { "Banco de Dados I", "Modelagem de dados: Cria��o de diagramas entidade-relacionamento (DER) para representar dados." +
            "\r\nSQL (Structured Query Language): Manipula��o de dados com comandos como SELECT, INSERT, UPDATE, DELETE." +
            "\r\nNormaliza��o de dados: Organiza��o para eliminar redund�ncias e garantir a integridade dos dados." +
            "\r\nCria��o de tabelas e rela��es: Implementa��o de estruturas relacionais e uso de chaves prim�rias e estrangeiras." +
            "\r\nFerramentas: MySQL Workbench e PostgreSQL." +
            "\r\nO objetivo � capacitar os alunos a planejar, criar e manipular bancos de dados de forma eficiente, formando a base para projetos futuros."};
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