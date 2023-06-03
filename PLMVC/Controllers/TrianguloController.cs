using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLMVC.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form(int valor)
        {
          
            for (int c = valor; c >= valor; c--)
            {
                string l = new string(' ', c);

                for (int a = 1; a <= valor; a++)
                {
                    string d = new string('*', a);
                    Console.Write(d);

                    //for (int i = a; i == a; i++)
                    //{
                    //    Console.Write("\n");
                    //}
                    if (a != 0)
                    {
                        Console.Write("\n");
                    }
                    Console.WriteLine();
                }
                Console.Write(l);
            }
            return View();
        }
    }
}