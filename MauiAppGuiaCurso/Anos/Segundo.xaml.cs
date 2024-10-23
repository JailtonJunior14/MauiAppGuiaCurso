using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso.Anos;

public partial class Segundo : ContentPage
{
    string[][] conteudosWeb = new string[3][];
    string[][] conteudosBD = new string[2][];

    public Segundo()
	{
		InitializeComponent();


        conteudosWeb[0] = new string[] { "web 1", "a" };
        conteudosWeb[1] = new string[] { "Programação WEB II", "Desenvolvimento Dinâmico: " +
            "Esta etapa envolve o uso mais aprofundado de JavaScript para construir sites interativos. Além disso, os alunos podem ser introduzidos a bibliotecas populares como jQuery ou frameworks modernos de JavaScript, como React ou Vue.js." +
            "\r\nIntegração com Back-End: Também pode ser introduzido o conceito de integração front-end com back-end, utilizando métodos de requisição como AJAX para buscar ou enviar dados sem recarregar a página. Essa fase foca em tornar os sites mais dinâmicos e conectados a bancos de dados." };
        conteudosWeb[2] = new string[] { "web 3", "c" };

        conteudosBD[0] = new string[] { "", ""};
        conteudosBD[1] = new string[] { "Banco de Dados II ", "Otimização de consultas SQL: Uso de índices e técnicas para melhorar o desempenho das consultas." +
            "\r\nTransações e controle de concorrência: Garantia de operações seguras e consistentes com transações ACID." +
            "\r\nBackup e recuperação de dados: Estratégias para proteger e restaurar dados em caso de falhas." +
            "\r\nSegurança: Controle de acesso e criptografia para proteger os dados." +
            "\r\nProcedimentos armazenados e triggers: Automação de tarefas e respostas automáticas a eventos." };

    }

    private void DesenvolvimentoS_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new DesenvolvimentoDS());
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
            Navigation.PushAsync(new Mobile());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!!", ex.Message, "OK");
        }
    }
}
