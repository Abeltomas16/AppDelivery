using System;
using System.Collections.Generic;
using System.Text;

namespace AppDelivery.Models
{
    public class BairroDto : BaseModelo

    {
        public int IdBairro { get; set; }
        public RuaDto Rua { get; set; }

    }
}
