using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared {
    
    public class Produto{
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage="O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Informe uma descrição para o produto")]
        public string Descricao { get; set; }

        [Required]
        [RegularExpression("(.*[1-9].*)|(.*[.].*[1-9].*)", ErrorMessage="Informe o preço do produto")]

        public decimal Preco { get; set; }

        [Required(ErrorMessage="Selecione uma categoria")]
        public string Categoria { get; set; }

        [Required(ErrorMessage="Selecione o fornecedor")]
        public string Fornecedor { get; set; }
        
        [Required]
        [RegularExpression("(.*[1-9].*)|(.*[.].*[1-9].*)", ErrorMessage="Informe a quantidade do produto no estoque") ]
        public int Quantidade { get; set; }
    }
}