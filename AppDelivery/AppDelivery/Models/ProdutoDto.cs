using System;
using System.Collections.Generic;
using System.Text;

namespace AppDelivery.Models
{
    public class ProdutoDto : BaseModelo
    {
        public int Qtde { get; set; }
        public decimal Preco { get; set; }
        public CategoriaDto Categoria { get; set; }
        public string ImgSrc { get; set; }
    }
}
