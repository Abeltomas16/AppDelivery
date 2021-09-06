using System;
using System.Collections.Generic;
using System.Text;

namespace AppDelivery.Models
{
    public class BaseModelo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
