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
        conteudosBD[1] = new string[] { "Analise e Projetos de Sistemas", "A disciplina de Análise e Projeto de Sistemas ensina os alunos a planejar, projetar e documentar sistemas de informação. Ela cobre:" +
            "\nAnálise de Requisitos: Coleta e interpretação das necessidades do cliente/usuário." +
            "\r\nModelagem de Sistemas: Uso de diagramas UML para representar o sistema (casos de uso, classes, etc.).\r\nProjeto de Sistemas: Definição da arquitetura, interfaces e tecnologias." +
            "\r\nDocumentação: Criação de especificações técnicas e manuais.\r\nAnálise Estrutural e Orientada a Objetos: Métodos para decompor e organizar o sistema.\r\nCiclo de Vida de Software: Estudo de modelos como Cascata, Ágil e Iterativo." +
            "\r\nValidação e Verificação: Garantir que o sistema atende aos requisitos.\r\nMetodologias: Introdução ao Scrum, Kanban e XP.\r\nGerenciamento de Projetos: Planejamento, organização e controle do desenvolvimento." };
        
        
        conteudosA[0] = new string[] {"Analise e Projetos de Sistemas", "A disciplina de Análise e Projeto de Sistemas ensina os alunos a planejar, projetar e documentar sistemas de informação. Ela cobre:" +
            "\r\nAnálise de Requisitos: Coleta e interpretação das necessidades do cliente/usuário." +
            "\r\nModelagem de Sistemas: Uso de diagramas UML para representar o sistema (casos de uso, classes, etc.)." +
            "\r\nProjeto de Sistemas: Definição da arquitetura, interfaces e tecnologias.\r\nDocumentação: Criação de especificações técnicas e manuais." +
            "\r\nAnálise Estrutural e Orientada a Objetos: Métodos para decompor e organizar o sistema.\r\nCiclo de Vida de Software: Estudo de modelos como Cascata, Ágil e Iterativo." +
            "\r\nValidação e Verificação: Garantir que o sistema atende aos requisitos.\r\nMetodologias: Introdução ao Scrum, Kanban e XP.\r\nGerenciamento de Projetos: Planejamento, organização e controle do desenvolvimento." };
        conteudosD[0] = new string[] { "Design Digital", "Princípios de Design: Harmonia, contraste, hierarquia visual e equilíbrio nos layouts." +
            "\r\nTipografia e Cores: Escolha adequada de fontes e esquemas de cores para melhorar a legibilidade e a estética." +
            "\r\nUsabilidade (UX): Criação de interfaces fáceis de usar e acessíveis a todos os tipos de usuários." +
            "\r\nFerramentas de Design: Uso de ferramentas como Adobe XD e Figma para prototipar e testar interfaces." +
            "\r\nDesign Responsivo: Adaptação de layouts para diferentes dispositivos, como smartphones e tablets." +
            "\r\nInteração e Animação: Implementação de transições e feedback visual para melhorar a experiência do usuário." +
            "\r\nDesign Thinking: Abordagem centrada no usuário, com prototipagem e testes iterativos." +
            "\r\nTrabalho Colaborativo: Comunicação entre designers e desenvolvedores para criar soluções eficazes." };
        conteudosFI[0] = new string[] { "Fundamentos da Informatica", "" };
        conteudosALG[0] = new string[] { "Técnicas de Programção e Algoritmos", "Lógica de Programação: Estruturação do pensamento lógico para resolver problemas." +
            "\r\nAlgoritmos: Criação de soluções passo a passo para problemas, usando pseudo-código e fluxogramas." +
            "\r\nEstruturas de Dados: Manipulação de vetores, listas, pilhas, filas, árvores e grafos." +
            "\r\nComplexidade de Algoritmos: Avaliação da eficiência de algoritmos com a notação Big O." +
            "\r\nTécnicas de Resolução: Métodos como recursão, busca e ordenação." +
            "\r\nProgramação Estruturada e Orientada a Objetos: Uso de funções, modularidade, classes e objetos." +
            "\r\nLinguagens de Programação: Implementação prática em linguagens como Python e C." +
            "\r\nTestes e Depuração: Verificação e correção de erros em algoritmos." };

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