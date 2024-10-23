using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso.Anos;

public partial class Terceiro : ContentPage
{
    string[][] conteudosWeb = new string[3][];
    string[][] conteudosM = new string[3][];
    string[][] conteudosQTS = new string[3][];
    string[][] conteudosTCC = new string[3][];
    string[][] conteudosIP = new string[3][];
    public Terceiro()
	{
		InitializeComponent();
        conteudosWeb[0] = new string[] { "web 1", "a" };
        conteudosWeb[1] = new string[] { "web 2", "a"};
        conteudosWeb[2] = new string[] { "Programa��o WEB III", "Aplica��es Web Completas: Nesta �ltima fase, o aluno aprende a construir aplica��es web mais completas, que envolvem n�o apenas o front-end, mas tamb�m o back-end. A integra��o com APIs externas e a seguran�a de dados s�o t�picos chave." +
            "\r\nFrameworks e Ferramentas Avan�adas: � prov�vel que frameworks de back-end como Node.js ou linguagens de programa��o para back-end como PHP ou Python sejam apresentados. Al�m disso, a disciplina pode cobrir o uso de frameworks de desenvolvimento web full-stack, como MEAN/MERN (MongoDB, Express, Angular/React, Node.js)." +
            "\r\nBanco de Dados e Persist�ncia de Dados: Outra �rea de foco � a persist�ncia de dados em bancos de dados relacionais ou n�o relacionais (ex: MySQL, MongoDB), com foco em seguran�a e escalabilidade de sistemas web." };
        conteudosM[0] = new string[] {"",""};
        conteudosQTS[0] = new string[] { "", "" };
        conteudosTCC[0] = new string[] { "", "" };
        conteudosIP[0] = new string[] { "", "" };

    }

    private void Qualidade_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new QaulidadeTS());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void Protocolo_Clicked(object sender, EventArgs e)
    {
        try
        {
            string[] conteudoWeb = new string[] { }
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void WEBIII_Clicked(object sender, EventArgs e)
    {
        try
        {
            string[] conteudoWeb = conteudosWeb[2];



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

    private void MobileII_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Mobile());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void Embarcados_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new SistemasEmb());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void TCC_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new TCC());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }
}