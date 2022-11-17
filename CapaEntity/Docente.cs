using System;
using System.Collections.Generic;

namespace CapaEntity
{
    public partial class Docente
    {
        public Docente()
        {
            Grupos = new HashSet<Grupo>();
        }

        public string IdDocente { get; set; } = null!;
        public string? Apellidos { get; set; }
        public string? Nombres { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }
        public string? Celular { get; set; }
        public string? Municipio { get; set; }

        public virtual ICollection<Grupo> Grupos { get; set; }
    }
}
