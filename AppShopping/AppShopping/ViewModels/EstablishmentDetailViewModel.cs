using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Models;
using AppShopping.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AppShopping.ViewModels
{
    [QueryProperty("establishmentSerialized", "establishmentSerialized")]
    // Classe pública e herdando de BaseViewModel
    public class EstablishmentDetailViewModel : BaseViewModel
    {
        public Estabilishment Establishment { get; set; }
        public string establishmentSerialized { set
            {
                Establishment = JsonConvert.DeserializeObject<Estabilishment>(Uri.UnescapeDataString(value));
                OnPropertyChanged(nameof(Establishment)); // nameof já pega o nome de Estabilishment
            } 
        }
        public EstablishmentDetailViewModel()
        {
        }
    }
}
