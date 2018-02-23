using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DefVersionPiit.Models
{
    public class Imagem
    {
        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] files { get; set; }
        public int Id { get; set; }
        public string NomeImagem { get; set; }
        public string descricao { get; set; }
        public int longitude { get; set; }
        public int latitude { get; set; }
        public int id_usuario { get; set; }
        public int pais { get; set; }
        public string uf { get; set; }
        public string municipio { get; set; }
        public int tamanho { get; set; }
        public string tipo { get; set; }
        public string caminho { get; set; }
    }
}