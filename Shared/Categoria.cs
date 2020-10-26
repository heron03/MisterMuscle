using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared {
    
    public class Categoria{
        
        public int Id { get; set; }
        
        [Required(ErrorMessage="O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Informe uma descrição para a categoria")]
        public string Descricao { get; set; }  
        
    }
}