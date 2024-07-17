using System;
using System.Collections.Generic;

namespace PrototipoDos.Models;

public partial class GestionPersonalEmpleado
{
    public int EmpleadoId { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public int? StatusId { get; set; }

    public string? Sexo { get; set; }

    public string? CorreoEletronico { get; set; }

    public string? NumeroCelular { get; set; }

    public string? NombreCompleto { get; set; }

    public virtual ICollection<Administradore> Administradores { get; set; } = new List<Administradore>();

    public virtual ICollection<GestionPersonalEmpleadoDireccion> GestionPersonalEmpleadoDireccions { get; set; } = new List<GestionPersonalEmpleadoDireccion>();
}
