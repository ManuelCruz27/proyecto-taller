using System;
using System.Collections.Generic;

namespace PrototipoDos.Models;

public partial class GestionPersonalEmpleadoDireccion
{
    public int DireccionId { get; set; }

    public int EmpleadoId { get; set; }

    public string? Calle { get; set; }

    public string? NoExterior { get; set; }

    public string? NoInterior { get; set; }

    public string? Estado { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Municipio { get; set; }

    public string? Ciudad { get; set; }

    public string? Colonia { get; set; }

    public int? StatusId { get; set; }

    public virtual GestionPersonalEmpleado Empleado { get; set; } = null!;
}
