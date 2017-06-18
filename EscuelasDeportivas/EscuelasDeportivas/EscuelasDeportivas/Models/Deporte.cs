using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelasDeportivas.Models
{
    public class Deporte
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Logotipo { get; set; }
    }
}
