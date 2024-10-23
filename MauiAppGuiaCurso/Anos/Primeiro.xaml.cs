using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso.Anos;

public partial class Primeiro : ContentPage
{

    string[][] conteudosWeb = new string[3][];
    string[][] conteudosBD = new string[2][];
    string[][] conteudosA = new string[2][];
    string[][] conteudosD = new string[2][];
    string[][] conteudosFI = new string[2][];
    string[][] conteudosALG = new string[2][];

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
        conteudosBD[1] = new string[] { "Analise e Projetos de Sistemas", "A disciplina de An�lise e Projeto de Sistemas ensina os alunos a planejar, projetar e documentar sistemas de informa��o. Ela cobre:" +
            "\nAn�lise de Requisitos: Coleta e interpreta��o das necessidades do cliente/usu�rio." +
            "\r\nModelagem de Sistemas: Uso de diagramas UML para representar o sistema (casos de uso, classes, etc.).\r\nProjeto de Sistemas: Defini��o da arquitetura, interfaces e tecnologias." +
            "\r\nDocumenta��o: Cria��o de especifica��es t�cnicas e manuais.\r\nAn�lise Estrutural e Orientada a Objetos: M�todos para decompor e organizar o sistema.\r\nCiclo de Vida de Software: Estudo de modelos como Cascata, �gil e Iterativo." +
            "\r\nValida��o e Verifica��o: Garantir que o sistema atende aos requisitos.\r\nMetodologias: Introdu��o ao Scrum, Kanban e XP.\r\nGerenciamento de Projetos: Planejamento, organiza��o e controle do desenvolvimento." };
        
        
        conteudosA[0] = new string[] {"Analise e Projetos de Sistemas", "A disciplina de An�lise e Projeto de Sistemas ensina os alunos a planejar, projetar e documentar sistemas de informa��o. Ela cobre:" +
            "\r\nAn�lise de Requisitos: Coleta e interpreta��o das necessidades do cliente/usu�rio." +
            "\r\nModelagem de Sistemas: Uso de diagramas UML para representar o sistema (casos de uso, classes, etc.)." +
            "\r\nProjeto de Sistemas: Defini��o da arquitetura, interfaces e tecnologias.\r\nDocumenta��o: Cria��o de especifica��es t�cnicas e manuais." +
            "\r\nAn�lise Estrutural e Orientada a Objetos: M�todos para decompor e organizar o sistema.\r\nCiclo de Vida de Software: Estudo de modelos como Cascata, �gil e Iterativo." +
            "\r\nValida��o e Verifica��o: Garantir que o sistema atende aos requisitos.\r\nMetodologias: Introdu��o ao Scrum, Kanban e XP.\r\nGerenciamento de Projetos: Planejamento, organiza��o e controle do desenvolvimento." };
        conteudosD[0] = new string[] { "Design Digital", "Princ�pios de Design: Harmonia, contraste, hierarquia visual e equil�brio nos layouts." +
            "\r\nTipografia e Cores: Escolha adequada de fontes e esquemas de cores para melhorar a legibilidade e a est�tica." +
            "\r\nUsabilidade (UX): Cria��o de interfaces f�ceis de usar e acess�veis a todos os tipos de usu�rios." +
            "\r\nFerramentas de Design: Uso de ferramentas como Adobe XD e Figma para prototipar e testar interfaces." +
            "\r\nDesign Responsivo: Adapta��o de layouts para diferentes dispositivos, como smartphones e tablets." +
            "\r\nIntera��o e Anima��o: Implementa��o de transi��es e feedback visual para melhorar a experi�ncia do usu�rio." +
            "\r\nDesign Thinking: Abordagem centrada no usu�rio, com prototipagem e testes iterativos." +
            "\r\nTrabalho Colaborativo: Comunica��o entre designers e desenvolvedores para criar solu��es eficazes." };
        conteudosFI[0] = new string[] { "Fundamentos da Informatica", "" };
        conteudosALG[0] = new string[] { "T�cnicas de Program��o e Algoritmos", "L�gica de Programa��o: Estrutura��o do pensamento l�gico para resolver problemas." +
            "\r\nAlgoritmos: Cria��o de solu��es passo a passo para problemas, usando pseudo-c�digo e fluxogramas." +
            "\r\nEstruturas de Dados: Manipula��o de vetores, listas, pilhas, filas, �rvores e grafos." +
            "\r\nComplexidade de Algoritmos: Avalia��o da efici�ncia de algoritmos com a nota��o Big O." +
            "\r\nT�cnicas de Resolu��o: M�todos como recurs�o, busca e ordena��o." +
            "\r\nPrograma��o Estruturada e Orientada a Objetos: Uso de fun��es, modularidade, classes e objetos." +
            "\r\nLinguagens de Programa��o: Implementa��o pr�tica em linguagens como Python e C." +
            "\r\nTestes e Depura��o: Verifica��o e corre��o de erros em algoritmos." };

    }

    

    private void Algoritimo_Clicked(object sender, EventArgs e)
    {
        try
        {
            string[] conteudoAlg = conteudosALG[0];



            Navigation.PushAsync(new Algoritimos
            {
                BindingContext = conteudoAlg
            });
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
            string[] conteudoAna = conteudosA[0];



            Navigation.PushAsync(new Analise
            {
                BindingContext = conteudoAna
            });
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
        string[] conteudoD = conteudosD[0];
        try
        {
            Navigation.PushAsync(new Design
            {
                BindingContext = conteudoD
            });
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