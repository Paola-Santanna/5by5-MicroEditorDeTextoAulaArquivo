using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_editor_de_texto___Arquivo
{
    internal class Product
    {
        /*
         * Declaração das propriedades, com o get e o set
         */
        public int id { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }


        /*
         * No método construtor tem as informações das propriedades;
         */
        public Product(int id, string description, double price, int quantity)
        {
            this.id = id;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }

        public override string? ToString()
        {
            return id + "; " + description + "; " + price + "; " + quantity;
        }
    }
}
