using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelasDeportivas.ViewModels
{
    public class DetalleDeporteViewModel : FreshBasePageModel
    {
        public DeporteViewModel Deporte { get; set; }

        public DetalleDeporteViewModel()
        {
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Deporte = initData as DeporteViewModel;
        }

    }
}
