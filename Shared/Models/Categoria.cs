using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared {
    
    public class Categoria{
        [Required]
        public int Id { get; set; }
        
        public string descricao_categoria { get; set; }

        public ICollection<Produto> Produtos { get; set;}
    }
}