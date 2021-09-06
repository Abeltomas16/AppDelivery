using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDelivery.View.Controls
{
    public class AnimalSearchHandler : SearchHandler
    { 

      
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);


            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = faz.Produtos
                    .Where(p => p.nome.ToLower().Contains(newValue.ToLower()))
                    .ToList<Produtos>();
            }
        }
        protected override  void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            List<Produtos> produtos = new List<Produtos>();
            produtos.Add((item as Produtos));
            faz.novo(produtos);

        }
    }
}