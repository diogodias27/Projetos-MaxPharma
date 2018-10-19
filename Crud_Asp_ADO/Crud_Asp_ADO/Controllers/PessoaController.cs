using Crud_Asp_ADO.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Asp_ADO.Controllers
{
    public class PessoaController : Controller
    {
        private PessoaRepository respository = new PessoaRepository();
        // GET: Pessoa
        public ActionResult Index()
        {
            return View(respository.GetAll()); 
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
            if(ModelState.IsValid)
            {
                respository.Save(pessoa);
                return RedirectToAction("Index");
            }
            else
            {
                return View(pessoa);
            }
        }

        public ActionResult Edit(int id)
        {
            var pessoa = respository.GetById(id);

            if(pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Edit(Pessoa pessoa)
        {
            if(ModelState.IsValid)
            {
                respository.Update(pessoa);
                return RedirectToAction("Index");
            }
            else
            {
                return View(pessoa);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            respository.DeleteById(id);
            return Json(respository.GetAll());
        }
    }
}