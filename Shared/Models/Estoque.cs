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

        public int qtd_entrada { get; set; }
        public int qtd_saida { get; set; }
        public int qtd_estoque_atual { get; set; }
    }
}