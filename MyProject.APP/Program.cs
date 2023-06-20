
using MyProject.BLL;
using MyProject.MODEL;

public class Program
{

    private static List<Livro> meuslivros = new List<Livro>();

    public static void Main(string[] args)
    {

        // Testando Inclusão
        Livro ObjLivro = new Livro();
        ObjLivro.Titulo = "Cem Anos De Solidão";
        ObjLivro.Autor = "Gabriel García Marques";
        ObjLivro.Ano = 1977;
        ObjLivro.Editora = "Record";
        ObjLivro.Resumo = "Neste clássico de Gabriel García Marques, conheça as fabulosas aventuras dos Buendía-Iguarán, com seus milagres, fantasias e dramas que representam famílias do mundo inteiro.";
        InserirLivro(ObjLivro);

        ObjLivro = new Livro();
        ObjLivro.Titulo = "Sapiens – Uma Breve História da Humanidade";
        ObjLivro.Autor = "Yuval Harari";
        ObjLivro.Ano = 2015;
        ObjLivro.Editora = "Record";
        ObjLivro.Resumo = "O que possibilitou ao Homo sapiens subjugar as demais espécies? O que nos torna capazes das mais belas obras de arte, dos avanços científicos mais impensáveis e das mais horripilantes guerras? Nossa capacidade imaginativa.";
        InserirLivro(ObjLivro);

        ObjLivro = new Livro();
        ObjLivro.Titulo = "Os irmãos Karamázov";
        ObjLivro.Autor = "Fiódor Dostoiévski, Traduçao de Paulo Bezerra";
        ObjLivro.Ano = 2012;
        ObjLivro.Editora = "Editora 34";
        ObjLivro.Resumo = "Último romance de Dostoiévski, Os irmãos Karamázov representa uma síntese de toda sua produção e é tido por muitos como sua obra-prima. Um marco da literatura universal, influenciou pensadores como Nietzsche e Freud.";
        InserirLivro(ObjLivro);


        ListarTodosOsLivro();

    }

    public static void InserirLivro(Livro _livro)
    {
        LivroRepository.Insert(_livro);
    }

    public static void ListarTodosOsLivro()
    {
        meuslivros = LivroRepository.GetAll();

        foreach (var m in meuslivros)
        {
            Console.WriteLine($"ID: {m.Id} \n" + $"Titulo: {m.Titulo} \n" + $"Autor: {m.Autor} \n" + $"Ano: {m.Ano} \n" + $"Resumo: {m.Resumo} \n" + $"");
        }
    }

    public static void AlterarLivro(Livro _livro)
    {
        LivroRepository.Update(_livro); 
    }

    public static void ExcluirLivro(Livro _livro)
    {
        LivroRepository.Excluir(_livro);
    }

}