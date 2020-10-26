using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared
{

    public class Pedido
    {
        [Required]
        public int Id { get; set; }
        public int Id_usuario { get; set; }
        public decimal total { get; set; }
        [DataType(DataType.Date)]
        public DateTime data { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public Usuario Usuario { get; set; }
        public List<ProdutoPedido> ProdutoPedido { get; set; }

    }
}