using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjetoIntegrador.Shared
{

    public class NotaFiscal
    {
        [Required]
        public int Id { get; set; }

        public DateTime data { get; set; }
        public string cpf_comprador { get; set; }
    }
}