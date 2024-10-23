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
        conteudosWeb[2] = new string[] { "Programação WEB III", "Aplicações Web Completas: Nesta última fase, o aluno aprende a construir aplicações web mais completas, que envolvem não apenas o front-end, mas também o back-end. A integração com APIs externas e a segurança de dados são tópicos chave." +
            "\r\nFrameworks e Ferramentas Avançadas: É provável que frameworks de back-end como Node.js ou linguagens de programação para back-end como PHP ou Python sejam apresentados. Além disso, a disciplina pode cobrir o uso de frameworks de desenvolvimento web full-stack, como MEAN/MERN (MongoDB, Express, Angular/React, Node.js)." +
            "\r\nBanco de Dados e Persistência de Dados: Outra área de foco é a persistência de dados em bancos de dados relacionais ou não relacionais (ex: MySQL, MongoDB), com foco em segurança e escalabilidade de sistemas web." };
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