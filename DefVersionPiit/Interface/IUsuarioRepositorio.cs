using DefVersionPiit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefVersionPiit.Interface
{
    public interface IUsuarioRepositorio
    {
        List <Usuario> Listar();
        Usuario ProcurarPorId(int id);
        Usuario Adicionar(Usuario user);
        Usuario Atualizar(Usuario user);
        void Deletar(int id);
        Usuario BuscarInformacoes(int id);
        Usuario Login(Usuario user);
    }
}
