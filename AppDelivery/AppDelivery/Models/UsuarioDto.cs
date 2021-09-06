using System;
using System.Collections.Generic;
using System.Text;

namespace AppDelivery.Models
{
    public class UsuarioDto : BaseModelo
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }
    }
}
