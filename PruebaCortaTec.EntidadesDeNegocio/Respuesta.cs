using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCortaTec.EntidadesDeNegocio
{
    public class Respuesta
    {
        public int Id { get; set; }
        public DateOnly FechaCreacion { get; set; }
        public string Texto { get; set; }
        public int PreguntaId { get; set; }
        public int UsuarioId { get; set; }
        public Pregunta Pregunta { get; set; }
        public Usuario Usuario { get; set; }
    }
}
