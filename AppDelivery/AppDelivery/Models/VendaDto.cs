using System;
using System.Collections.Generic;
using System.Text;

namespace AppDelivery.Models
{
    public class VendaDto
    {
        public ClienteDto IDCliente { get; set; }
        public ICollection<ProdutoDto> produtos { get; set; }
    }
}
