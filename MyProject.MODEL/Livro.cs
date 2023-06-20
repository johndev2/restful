using System;
using System.Collections.Generic;

namespace MyProject.MODEL;

public partial class Livro
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public string? Autor { get; set; }

    public int? Ano { get; set; }

    public string? Editora { get; set; }

    public string? Resumo { get; set; }
}
