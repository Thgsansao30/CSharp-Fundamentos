using CSharpFundamentos.Dados.Repositorio;
using CSharpFundamentos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpFundamentos.AppWeb.Controllers
{
    public class UsuarioController : Controller
    {
        RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            List<Usuario> model = repositorio.ListaTodos();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            repositorio.Inserir(model);
            ModelState.Clear();
            ViewBag.Mensagem = "Usuario " +model.Nome +" cadastrado com sucesso";
            return View();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Usuario model = repositorio.ListarPorId(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Usuario model)
        {
            repositorio.Alterar(model);
            ViewBag.Mensagem = "Usuario " + model.Nome + " alterado com sucesso";
            return View();
        }

        public ActionResult Delete(int id)
        {
            repositorio.Deletar(id);
            TempData["Delete"] = true;
            return RedirectToAction("Index");
        }

    }
}