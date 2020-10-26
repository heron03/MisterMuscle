using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared
{

    public class ProdutoPedido
    {
        [Required]
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }

        public decimal preco_unitario_produto { get; set; }
        public decimal preco_total_produto { get; set; }
        public decimal quantidade_produto { get; set; }
    }
}