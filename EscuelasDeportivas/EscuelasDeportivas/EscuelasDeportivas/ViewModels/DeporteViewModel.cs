using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelasDeportivas.ViewModels
{
    [ImplementPropertyChanged]
    public class DeporteViewModel
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}
