using System;
using System.Collections.Generic;

namespace PrototipoDos.Models;

public partial class InvPedidosBroquelero
{
    public int PedidoId { get; set; }

    public int? StatusId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? EmpleadoId { get; set; }

    public virtual ICollection<PedidosBroquelerosEntrada> PedidosBroquelerosEntrada { get; set; } = new List<PedidosBroquelerosEntrada>();

    public virtual ICollection<PedidosBroquelerosSalidum> PedidosBroquelerosSalida { get; set; } = new List<PedidosBroquelerosSalidum>();
}
