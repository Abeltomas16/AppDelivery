using System;
using System.Collections.Generic;
using System.Text;

namespace AppDelivery.Models
{
    public class BaseModelo
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Senha { get; set; }
        public TelefoneDto Telefone { get; set; }
        public EmaialDto EnderecoEmail { get; set; }
        public MunicipioDto Municipio { get; set; }
        public BairroDto Bairro { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
