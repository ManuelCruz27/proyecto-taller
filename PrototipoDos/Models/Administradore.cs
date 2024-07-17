using System;
using System.Collections.Generic;

namespace PrototipoDos.Models;

public partial class Administradore
{
    public int AdminId { get; set; }

    public int? EmpleadoId { get; set; }

    public string? Usuario { get; set; }

    public string? Password { get; set; }

    public int? StatusAdmin { get; set; }

    public virtual GestionPersonalEmpleado? Empleado { get; set; }
}
