using DefVersionPiit.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DefVersionPiit.Controllers
{
    public class UsuarioController : Controller
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
        // GET: Usuario
        public ActionResult Index()
        {
            return View("Index", Repo.Listar());
        }

    }
}