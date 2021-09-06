using AppDelivery.View.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppDelivery.ViewModel
{
    public class Produt
    {
        public ObservableCollection<Produtos> Produtos { get => faz.Produtos; }
        public List<string> Actions { get; set; }

        public ICommand MenuCommand => new Command(chama);
        public Produt()
        {
            Actions = new List<string>()
            {
                "Ver carrinho",
                "Apagar tudo"
            };
        }
         void chama()
        {
            Console.WriteLine("Oi");
        }
    }
}
