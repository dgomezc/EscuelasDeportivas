using EscuelasDeportivas.Models;
using EscuelasDeportivas.Services;
using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Deporte> Deportes { get; set; }

        public override async void Init(object initData)
        {
            base.Init(initData);


            var result = await DeportesService.Instance.ReadDeportesAsync();

            if (result != null)
            {
                Deportes = new ObservableCollection<Deporte>(result);
            }
        }



        public Deporte SelectedDeporte
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
