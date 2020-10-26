using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared
{

    public class Fornecedor
    {
        [Required]
        public int Id { get; set; }
        public string nome { get; set; }
        public string razao_social { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string rua { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }

    }
}