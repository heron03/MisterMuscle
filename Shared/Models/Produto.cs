using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared
{

    public class Produto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe uma descrição para o produto")]
        public string Descricao { get; set; }

        [Required]
        [RegularExpression("(.*[1-9].*)|(.*[.].*[1-9].*)", ErrorMessage = "Informe o preço do produto")]

        public decimal Preco { get; set; }
        public byte[] ImagemProduto { get; set; }

        [Required]
        [RegularExpression("(.*[1-9].*)|(.*[.].*[1-9].*)", ErrorMessage = "Informe a quantidade do produto que será inserida")]
        public int Quantidade { get; set; }

        
        public int FornecedorId { get; set;}
        
        public int CategoriaId { get; set; }



        public ICollection<ProdutoPedido> ProdutoPedido { get; set; }

        public ICollection<Estoque> Estoques { get; set;}
        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }

        
    }
}