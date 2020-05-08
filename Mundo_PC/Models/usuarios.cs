using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mundo_PC.Models
{
    public class usuarios
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string direccion { get; set; }
        public string colonia { get; set; }
        public string region { get; set; }
        public string cp {get; set;}
        public string telefono {get; set;}
    }

}