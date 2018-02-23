using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefVersionPiit.Models
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
        public string Municipio { get; set; }
    }
}