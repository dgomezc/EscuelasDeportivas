using EscuelasDeportivas.Models;
using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelasDeportivas.ViewModels
{
    [ImplementPropertyChanged]
    public class EditarDeporteViewModel : DetalleDeporteViewModel
    {

        public string Title
        {
            get
            {
                if (string.IsNullOrEmpty(this.Deporte.Id))
                    return "Crear nuevo deporte";

                return "Editar " + Deporte.Nombre;
            }
        }
    }
}
