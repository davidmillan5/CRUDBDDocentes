using System;
using System.Collections.Generic;

namespace CapaEntity
{
    public partial class Grupo
    {
        public int IdGrupos { get; set; }
        public DateTime? FechaInicio { get; set; }
        public int? NroEstudiantes { get; set; }
        public string? Jornada { get; set; }
        public int? IdModulo1 { get; set; }
        public string? IdDocente1 { get; set; }

        public virtual Docente? IdDocente1Navigation { get; set; }
        public virtual Modulo? IdModulo1Navigation { get; set; }
    }
}
