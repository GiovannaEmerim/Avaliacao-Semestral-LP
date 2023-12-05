public class Livro : ItemBiblioteca
{
    public string Autor { get; }

    // Construtor
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
    }
       public Livro(int id, string titulo, string autor, string descricaoInterna) : base(id, titulo)
    {
        DescricaoInterna = descricaoInterna;
    }

    // Implementação do método ExibirDescricaoInterna da classe base
    public override void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição Interna do Livro '{Titulo}', {Autor}");
    }
}
