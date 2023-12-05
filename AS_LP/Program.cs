
Biblioteca minhaBiblioteca = new Biblioteca();

// Criando instâncias de livros
Livro livro1 = new Livro(1, "O Conto da Aia", "Margaret Atwood");
Livro livro2 = new Livro(2, "A Selecao", "Kiera Cass");
Livro livro3 = new Livro(3, "É Assim Que Acaba", "Colleen Hoover");

// Add livros na biblioteca
minhaBiblioteca.AdicionarItem(livro1);
minhaBiblioteca.AdicionarItem(livro2);
minhaBiblioteca.AdicionarItem(livro3);


Console.WriteLine("Digite o titulo do livro");
string buscarTitulo = Console.ReadLine();
ItemBiblioteca livroEncontrado = minhaBiblioteca.BuscarLivroPorTitulo(buscarTitulo); // Buscar livro pelo título

if (livroEncontrado != null)
{
    Console.WriteLine($"Livro '{buscarTitulo}' encontrado na biblioteca.");
    livroEncontrado.ExibirDescricaoInterna(); // Exibindo a descrição interna do livro encontrado
}
else
{
    Console.WriteLine($"Livro '{buscarTitulo}' não encontrado na biblioteca.");
}

// Removendo um livro da biblioteca
minhaBiblioteca.RemoverItem(livro2);

