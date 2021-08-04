using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Models;
using AppShopping.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShopping.ViewModels
{
    public class StoresViewModel : BaseViewModel // Herdando de BaseViewModel
    {
        public string SearchWord { get; set; } // Propriedade para reconhecer qual dado foi digitado pelo usuário no campo de buscaa
        public ICommand SearchCommand { get; set; } // Propriedade do evento de comando (botão OK)
        private List<Estabilishment> _establishments;

        // Propriedade para exibir a lista de estabelecimentos
        public List<Estabilishment> Establishments { 
            get {
                return _establishments;
            }
            set {
                SetProperty(ref _establishments, value);
            }
        } 
        private List<Estabilishment> _allEstablishments; // Lista para receber todas as lojas

        public ICommand DetailCommand { get; set; } // Propriedade do tipo ICommand chamada DetailCommand

        private void Detail(Estabilishment estabilishment) // Método que vai nos levar até a tela de Detalhes
        {
            string establishmentSerialized = JsonConvert.SerializeObject(estabilishment); // Criamos uma string para receber o estabelecimento
            Shell.Current.GoToAsync($"establishment/detail?establishmentSerialized={Uri.EscapeDataString(establishmentSerialized)}"); // rota de navegação que criamos

        }

        public StoresViewModel()
        {
            SearchCommand = new Command(Search); // Quando clicar no botão, chama o método Search
            DetailCommand = new Command<Estabilishment>(Detail); // Chamar a tela de detalhe

            var allEstablishment = new EstablishmentService().GetEstabilishments(); // Var recebendo todos os estabelecimentos
            var allStores = allEstablishment.Where(a => a.Tipo == Libraries.Enums.EstablishmentType.Store).ToList(); // Var filtrando somente os estabelecimentos do tipo Store (loja)
            Establishments = allStores;            
            _allEstablishments = allStores; // Variável que criamos acima que recebe todas as lojas
        }

        // Lógica para filtrar a lista de lojas
        private void Search()
        {
            // Filtrando os estabelecimentos da lista que contém a palavra digitada no SearchWord (método)
            // ToLower = para converter tudo em letra minúscula
            Establishments = _allEstablishments.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
    }
}
