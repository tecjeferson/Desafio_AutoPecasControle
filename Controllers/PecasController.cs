using lojaDePecasDeCarro.Data;
using lojaDePecasDeCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lojaDePecasDeCarro.Controllers
{
    public class PecasController : Controller
    {
        private PecasBO pbo = new PecasBO();
        public PecasController()
        {
            
        }

        // GET: Pecas
        public ActionResult Index(PecasBO model)
        {

            var ListItem = pbo.GetPecas().ToList();
            return View(ListItem);
        }

        // GET: Pecas/Details/5
        
        [HttpGet]
        public ActionResult FindById()
        {
           return View();
        }

        [HttpPost]
        public ActionResult FindById(int? id)
        {
            var ListById = pbo.GetById(id);

            if(ListById != null)
            {
                return View(ListById);
            }
            return View();

        }
                              

        public ActionResult Create(Pecas pecas)
        {
            var result = 0;

            try
            {
                pbo.Create(pecas);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }

           
        }


        [HttpGet]// GET: Pecas/Create
        public ActionResult Create()
        {

            return View();
        }

      
        // GET: Pecas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pecas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pecas/Delete/5
        public ActionResult Delete(int? id)
        {
            var ListById = pbo.GetById(id);

            if (ListById != null)
            {
                return View(ListById);
            }
            return View();
        }

        // POST: Pecas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                pbo.Delete(id);

               return RedirectToAction("Index");
           }
            catch
            {
                return View();
            }
        }
    }
}
