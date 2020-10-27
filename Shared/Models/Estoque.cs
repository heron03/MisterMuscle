using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared
{

    public class Estoque
    {
        [Required]
        public int Id { get; set; }
        public int tipo_transacao { get; set; }
        public int Quantidade { get; set; }

        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}