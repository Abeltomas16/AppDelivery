using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppDelivery.View.Controls
{
    public static class faz
    {
        public static ObservableCollection<Produtos> Produtos { get; set; } = new ObservableCollection<Produtos>()
        {
            new Produtos { nome = "Iphone ProMax", imgSrc = "f1.png"} ,
            new Produtos { nome = "Iphone 6S+", imgSrc = "f2.png" }   ,
            new Produtos { nome = "Iphone 7S+", imgSrc = "f3.png" }   ,
            new Produtos { nome = "Iphone 5S", imgSrc = "f4.png" }    ,
            new Produtos { nome = "Iphone 7S", imgSrc = "f5.png" }    ,
            new Produtos { nome = "Samsung S8", imgSrc = "f6.png" }   ,
        };
        public static void novo(List<Produtos> produtos)
        {
            Produtos = new ObservableCollection<Produtos>(produtos);
        }
    }
}
