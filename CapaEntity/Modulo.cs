using System;
using System.Collections.Generic;

namespace CapaEntity
{
    public partial class Modulo
    {
        public Modulo()
        {
            Grupos = new HashSet<Grupo>();
        }

        public int IdModulo { get; set; }
        public string? Programa { get; set; }
        public string? NombreModulo { get; set; }
        public int? Creditos { get; set; }
        public int? Precio { get; set; }

        public virtual ICollection<Grupo> Grupos { get; set; }
    }
}
