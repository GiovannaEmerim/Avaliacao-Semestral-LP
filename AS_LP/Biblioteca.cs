using System.Collections;
public class Biblioteca
{
    List<ItemBiblioteca> Colecao;

    public Biblioteca()
    {
        Colecao = new List<ItemBiblioteca>();
    }

    // Método para adicionar um item à coleção
    public void AdicionarItem(ItemBiblioteca item)
    {
        Colecao.Add(item);
    }

    // Método para remover um item da coleção
    public void RemoverItem(ItemBiblioteca item)
    {
        Colecao.Remove(item);
    }

    // Método de busca por título
    public ItemBiblioteca BuscarLivroPorTitulo(string titulo)
    {
        return Colecao.Find(item => item.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
    }

    // Método de busca por ID
    public ItemBiblioteca BuscarItemPorId(int id)
    {
        return Colecao.Find(item => item.Id == id);
    }
}

