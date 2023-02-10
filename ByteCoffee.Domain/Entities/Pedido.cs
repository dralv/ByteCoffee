using ByteCoffee.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteCoffee.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int NumeroDaComanda { get; set; }
        public int QuantidadeDeProdutos { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime HorarioRecebimento { get; set; }
        public DateTime HorarioEntrega { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
