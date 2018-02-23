using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DefVersionPiit.Models
{
    public class Usuario
    {
        public Usuario()
        {
            this.Endereco = new List<Endereco>();
        }
        public int IdUsuario { get; set; }
        public int IdEndereco { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime UltimoLogin { get; set; }
        public int NumeroRegistro { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Observacoes { get; set; }
        public List<Endereco> Endereco { get; set; }
    }
}