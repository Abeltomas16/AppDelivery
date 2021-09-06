using AppDelivery.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppDelivery.ViewModel
{
    public class HomeUsuario : BaseViewModel
    {
        ObservableCollection<ProdutoDto> Produtos { get; set; }
        ProdutoDto ProdutoSelecionado;
        public ProdutoDto SelectedProduto
        {
            get { return ProdutoSelecionado; }
            set
            {
                if (ProdutoSelecionado != value)
                {
                    ProdutoSelecionado = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
