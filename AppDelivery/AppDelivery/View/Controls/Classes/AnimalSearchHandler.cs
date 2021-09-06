using AppDelivery.Models;
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
                    .Where(p => p.Descricao.ToLower().Contains(newValue.ToLower()))
                    .ToList<ProdutoDto>();
            }
        }
        protected override  void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            List<ProdutoDto> produtos = new List<ProdutoDto>();
            produtos.Add((item as ProdutoDto));
            faz.novo(produtos);
        }
    }
}