using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared
{

    public class Carrinho
    {
        public Usuario Usuarios { get; set; }
        public int UsuarioId { get; set; }
        public Produto Produtos { get; set; }
        public int ProdutoId { get; set; }
    }
}