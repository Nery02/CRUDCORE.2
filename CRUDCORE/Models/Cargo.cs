using System;
using System.Collections.Generic;

namespace CRUDCORE.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdCargo { get; set; }

        public string? Descripcion { get; set; } // Mantener solo esta propiedad

        public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
    }
}
