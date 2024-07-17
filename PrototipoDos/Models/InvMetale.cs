using System;
using System.Collections.Generic;

namespace PrototipoDos.Models;

public partial class InvMetale
{
    public int MetalId { get; set; }

    public string? NombreMetal { get; set; }

    public string? Kilataje { get; set; }

    public decimal? Gramos { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? NombreCompleto { get; set; }

    public int? StatusId { get; set; }
}
