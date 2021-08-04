using AppShopping.Libraries.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppShopping.Libraries.Converters
{
    // Deixei a classe pública, e herdou de IValueConverter (implementando a interface)
    public class EstablishmentTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            EstablishmentType type = (EstablishmentType)value;

            // se o tipo for loja (store) retorna a palavra loja, do contrário, retorna restaurante
            return (type == EstablishmentType.Store) ? "Loja" : "Restaurante";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
