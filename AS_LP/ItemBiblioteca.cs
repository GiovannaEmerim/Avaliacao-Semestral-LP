using System;
using System.Collections.Generic;

// Classe base abstrata ItemBiblioteca
public abstract class ItemBiblioteca
{
    public int Id { get; }
    public string Titulo { get; }
    protected string DescricaoInterna { get; set; }

    // Construtor
    public ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Descrição padrão";
    }

    public abstract void ExibirDescricaoInterna();
}
