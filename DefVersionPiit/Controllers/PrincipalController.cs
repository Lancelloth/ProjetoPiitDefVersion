using DefVersionPiit.Interface;
using DefVersionPiit.Models;
using System.Web.Mvc;

namespace DefVersionPiit.Controllers
{
    public class PrincipalController : Controller
    {
        private UsuarioRepositorio _usuarioRepositorio;
        private UsuarioRepositorio Repo
        {
            get
            {
                if (_usuarioRepositorio == null)
                {
                    _usuarioRepositorio = new UsuarioRepositorio();
                }
                return _usuarioRepositorio;
            }

        }

        public ActionResult Principal()
        {
            return View("Principal");
        }

        public ActionResult Logout()
        {
            Session["usuarioLogado"] = null;
            return RedirectToAction("Principal", "Principal");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(Usuario user)
        {
            string senha;
            if(ModelState.IsValid)
            {
               /* senha = Criptografia.Encrypt(user.Senha);
                user.Senha = senha;*/
                Repo.Adicionar(user);
                Session["usuarioLogado"] = user.Nome;
                Session["UserId"] = user.IdUsuario;
                return RedirectToAction("Principal", "Principal");
            }
            else
            {
                return View("Principal", user);
            }            

        }

        [HttpGet]
        public ActionResult Login(Usuario user)
        {
           /* string senha;
            senha = Criptografia.trataHashGenerica(user.Senha);
            user.Senha = senha;*/
            Usuario usuario = new Usuario();
            usuario = user;
            /*if(Repo.Login(user))
            {
                Session["usuarioLogado"] = usuario.Nome;
                return RedirectToAction("Principal", "Principal");
            }
            else
            {
                Console.Write("Usuário ou senha incorretos!");
                return View("Principal", user);
            }*/
            usuario = Repo.Login(user);
            Session["usuarioLogado"] = usuario.Nome;
            Session["UserId"] = usuario.IdUsuario;
            return RedirectToAction("Principal", "Principal", usuario);
        }
    }
}