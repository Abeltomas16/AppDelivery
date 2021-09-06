using AppDelivery.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppDelivery.View.Controls
{
    public static class faz
    {
        public static ObservableCollection<ProdutoDto> Produtos { get; set; } = new ObservableCollection<ProdutoDto>()
        {
            new ProdutoDto { Descricao = "Iphone ProMax", ImgSrc = "f1.png"} ,
            new ProdutoDto { Descricao = "Iphone 6S+", ImgSrc = "f2.png" }   ,
            new ProdutoDto { Descricao = "Iphone 7S+", ImgSrc = "f3.png" }   ,
            new ProdutoDto { Descricao = "Iphone 5S", ImgSrc = "f4.png" }    ,
            new ProdutoDto { Descricao = "Iphone 7S", ImgSrc = "f5.png" }    ,
            new ProdutoDto { Descricao = "Samsung S8", ImgSrc = "f6.png" }   ,
        };
        public static void novo(List<ProdutoDto> produtos)
        {
            Produtos = new ObservableCollection<ProdutoDto>(produtos);
        }
    }
}
