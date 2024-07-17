using System;
using System.Collections.Generic;

namespace PrototipoDos.Models;

public partial class PedidosBroquelerosEntrada
{
    public int PedidoEntradaId { get; set; }

    public int? PedidoId { get; set; }

    public int? PedidoDetalleId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? ProductoId { get; set; }

    public int? KilateId { get; set; }

    public string? Empleado { get; set; }

    public string? Producto { get; set; }

    public string? Kilate { get; set; }

    public decimal? ParesBroqueles { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Tuerca { get; set; }

    public decimal? Malo { get; set; }

    public decimal? MermaG { get; set; }

    public decimal? TotalPagar { get; set; }

    public virtual InvPedidosBroquelero? Pedido { get; set; }

    public virtual PedidosBroquelerosSalidum? PedidoDetalle { get; set; }
}
