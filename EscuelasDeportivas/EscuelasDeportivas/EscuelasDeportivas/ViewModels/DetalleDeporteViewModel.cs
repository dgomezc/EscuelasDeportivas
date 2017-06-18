using EscuelasDeportivas.Models;
using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EscuelasDeportivas.ViewModels
{
    [ImplementPropertyChanged]
    public class DetalleDeporteViewModel : FreshBasePageModel
    {
        public Deporte Deporte { get; set; }

        public DetalleDeporteViewModel()
        {
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Deporte = initData as Deporte;
        }
        public ICommand EditCommand
        {
            get
            {
                return new Command(async () => {
                    await CoreMethods.PushPageModel<EditarDeporteViewModel>(Deporte);
                });
            }
        }

    }
}
