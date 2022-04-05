using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: CalculadoraController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CalculadoraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculadoraController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculaSoma(int a, int b)
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.soma(a, b);
            ViewBag.CalculaSoma = num;
            return View("Index");
        }

        [HttpPost]
        public ActionResult CalculaDiferenca(int a, int b)
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.subtrair(a, b);
            ViewBag.CalculaDiferenca = num;
            return View("Index");
        }


        [HttpPost]
        public ActionResult CalculaProduto(int a, int b)
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.multiplicar(a, b);
            ViewBag.CalculaProduto = num;        
            return View("Index");
        }

        [HttpPost]
        public ActionResult CalculaDivisao(int a, int b)
        {
            Calculadora calculadora = new Calculadora();
            int num = calculadora.dividir(a, b);
            ViewBag.CalculaDivisao = num;
            return View("Index");
        }


        // POST: CalculadoraController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculadoraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculadoraController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculadoraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculadoraController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
