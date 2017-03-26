using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelasDeportivas.ViewModels
{
    public class ListaDeportesViewModel : FreshBasePageModel
    {
        public ListaDeportesViewModel()
        {
        }

        public List<DeporteViewModel> Deportes { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            Deportes = new List<DeporteViewModel>
            {
                new DeporteViewModel{Nombre="Futbol", Descripcion="Detalle fútbol"},
                new DeporteViewModel{Nombre="Futbol sala", Descripcion="Detalle fútbol sala"}
            };
        }



        public DeporteViewModel SelectedDeporte
        {
            get { return null; }
            set
            {
                CoreMethods.PushPageModel<DetalleDeporteViewModel>(value);
                RaisePropertyChanged();
            }
        }

    }
}
