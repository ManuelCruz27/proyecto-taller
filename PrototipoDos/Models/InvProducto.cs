using System;
using System.Collections.Generic;

namespace PrototipoDos.Models;

public partial class InvProducto
{
    public int ProductoId { get; set; }

    public string? NombreProducto { get; set; }

    public string? ModeloONumero { get; set; }

    public string? TipoMetal { get; set; }

    public decimal? PrecioPorPar { get; set; }

    public string? NombreCompletoProducto { get; set; }

    public decimal? Existencias { get; set; }

    public DateTime? Fecha { get; set; }

    public int? StatusProductoId { get; set; }

    public string? CodigoRelacionado { get; set; }

    public string? Kilataje {  get; set; }

    public int MetalID { get; set; }


}
