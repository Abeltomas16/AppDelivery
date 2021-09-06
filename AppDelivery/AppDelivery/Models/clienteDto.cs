using System;
using System.Collections.Generic;
using System.Text;

namespace AppDelivery.Models
{
    public class ClienteDto : BaseModelo
    {
        public string telefone { get; set; }
        public enderecoDto endereco { get; set; }
        public string email { get; set; }
    }
}
