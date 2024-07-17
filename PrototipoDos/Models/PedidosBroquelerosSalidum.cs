using System;
using System.Collections.Generic;

namespace PrototipoDos.Models;

public partial class PedidosBroquelerosSalidum
{
    public int PedidoDetalleId { get; set; }

    public int? PedidoId { get; set; }

    public int? EmpleadoId { get; set; }

    public int? ProductoId { get; set; }

    public int? KilateId { get; set; }

    public string? Empleado { get; set; }

    public string? Producto { get; set; }

    public string? Kilate { get; set; }

    public int? StatusPedidoDetalleId { get; set; }

    public decimal? CientoCasquilla { get; set; }

    public decimal? CientoPernos { get; set; }

    public decimal? CientoTuerca { get; set; }

    public decimal? ParesCasquilla { get; set; }

    public decimal? ParesPernos { get; set; }

    public decimal? ParesTuerca { get; set; }

    public decimal? GramosCasquilla { get; set; }

    public decimal? GramosPernos { get; set; }

    public decimal? GramosTuerca { get; set; }

    public decimal? GramosSoldadura { get; set; }

    public decimal? ParesEstimados { get; set; }

    public decimal? GramosTotal { get; set; }

    public DateTime? FechaSalida { get; set; }

    public virtual InvPedidosBroquelero? Pedido { get; set; }

    public virtual ICollection<PedidosBroquelerosEntrada> PedidosBroquelerosEntrada { get; set; } = new List<PedidosBroquelerosEntrada>();
}
