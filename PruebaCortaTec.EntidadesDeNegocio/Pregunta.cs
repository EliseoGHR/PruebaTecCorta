using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCortaTec.EntidadesDeNegocio
{
    public class Pregunta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public byte Estatus { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public IList<Respuesta> Respuestas { get; set; }
    }
}
