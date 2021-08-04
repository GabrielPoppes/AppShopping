using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Models;
using AppShopping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppShopping.ViewModels
{
    // Classe pública e herdando de BaseViewModel
    public class EstablishmentDetailViewModel : BaseViewModel
    {
        public Estabilishment Establishment { get; set; }
        public EstablishmentDetailViewModel()
        {
            Establishment = new EstablishmentService().GetEstabilishments().First();
        }
    }
}
