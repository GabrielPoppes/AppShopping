using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShopping
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : Shell
    {
        public Menu()
        {
            InitializeComponent();

            /* Aqui registramos uma rota que leva para a tela de detalhes dos estabelecimentos
             * A rota ficou: establishment/detail
             * E a página é a "EstablishmentDetail" que fica na pasta "Views"
             */
            Routing.RegisterRoute("establishment/detail", typeof(Views.EstablishmentDetail));
        }
    }
}