using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso.Anos;

public partial class Segundo : ContentPage
{
    string[][] conteudosWeb = new string[3][];
    string[][] conteudosBD = new string[2][];
    string[][] conteudosDS = new string[2][];
    string[][] conteudosM = new string[2][];

    public Segundo()
	{
		InitializeComponent();


        conteudosWeb[0] = new string[] { "web 1", "a" };
        conteudosWeb[1] = new string[] { "Programa��o WEB II", "Desenvolvimento Din�mico: " +
            "Esta etapa envolve o uso mais aprofundado de JavaScript para construir sites interativos. Al�m disso, os alunos podem ser introduzidos a bibliotecas populares como jQuery ou frameworks modernos de JavaScript, como React ou Vue.js." +
            "\r\nIntegra��o com Back-End: Tamb�m pode ser introduzido o conceito de integra��o front-end com back-end, utilizando m�todos de requisi��o como AJAX para buscar ou enviar dados sem recarregar a p�gina. Essa fase foca em tornar os sites mais din�micos e conectados a bancos de dados." };
        conteudosWeb[2] = new string[] { "web 3", "c" };

        conteudosBD[0] = new string[] { "", ""};
        conteudosBD[1] = new string[] { "Banco de Dados II ", "Otimiza��o de consultas SQL: Uso de �ndices e t�cnicas para melhorar o desempenho das consultas." +
            "\r\nTransa��es e controle de concorr�ncia: Garantia de opera��es seguras e consistentes com transa��es ACID." +
            "\r\nBackup e recupera��o de dados: Estrat�gias para proteger e restaurar dados em caso de falhas." +
            "\r\nSeguran�a: Controle de acesso e criptografia para proteger os dados." +
            "\r\nProcedimentos armazenados e triggers: Automa��o de tarefas e respostas autom�ticas a eventos." };
        conteudosDS[0] = new string[] {"Desenvolvimento de Sistemas",""};
        conteudosM[0] = new string[] { "Programa��o de Aplicativos Mobile I", "" };


    }

    private void DesenvolvimentoS_Clicked(object sender, EventArgs e)
    {
        try
        {
            string[] conteudoDS = conteudosDS[0];
            Navigation.PushAsync(new DesenvolvimentoDS
            {
                BindingContext = conteudoDS
            });
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }

    private void BancoII_Clicked(object sender, EventArgs e)
    {
        try
        {
            string[] conteudoBD = conteudosBD[1];
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

    private void WEBII_Clicked(object sender, EventArgs e)
    {
        try
        {
            string[] conteudoWeb = conteudosWeb[1];



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

    private void Mobile_Clicked(object sender, EventArgs e)
    {
        try
        {
            string[] conteudoM = conteudosM[0];
            Navigation.PushAsync(new Mobile
            {
                BindingContext = conteudoM
            });
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }
}
