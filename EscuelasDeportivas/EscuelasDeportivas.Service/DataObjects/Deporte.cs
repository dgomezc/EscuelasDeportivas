using Microsoft.Azure.Mobile.Server;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscuelasDeportivas.Service.DataObjects
{
    public class Deporte : EntityData
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Logotipo { get; set; }
    }
}