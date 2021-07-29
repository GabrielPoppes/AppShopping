using System;
using System.Collections.Generic;
using System.Text;
using AppShopping.Libraries.Enums;

namespace AppShopping.Models
{
    // Classe adicionada como pública
    public class Estabilishment
    {
        public int Id { get; set; } // ID
        public EstablishmentType Tipo { get; set; } // Classe do tipo do ENUM que criamos (EstablishmentType)
        public string Logo { get; set; }
        public string Name { get; set; } // Nome
        public string Description { get; set; } // Descrição
        public string Address { get; set; } // Endereço
        public string Phone { get; set; } // Telefone
    }
}
