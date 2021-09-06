using System;
using System.Collections.Generic;
using System.Text;

namespace AppDelivery.Models
{
    public class MunicipioDto : BaseMod­elo
    {
        public int IdMunicipio { get; set; }
        public BairroDto BairroMunicipio { get; set; }
    }
}
