using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCortaTec.EntidadesDeNegocio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }

        public IList<Pregunta> Preguntas { get; set; }

        public IList<Respuesta> Respuestas { get; set; }
    }
}
