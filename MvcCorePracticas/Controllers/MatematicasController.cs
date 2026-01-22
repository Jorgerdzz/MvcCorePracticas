using Microsoft.AspNetCore.Mvc;

namespace MvcCorePracticas.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SumarNumerosGet(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["MENSAJE"] = numero1 + " + " + numero2 + " = " + suma;
            return View();
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost(int cajanumero1, int cajanumero2)
        {
            int suma = cajanumero1 + cajanumero2;
            ViewData["MENSAJE"] = cajanumero1 + " + " + cajanumero2 + " = " + suma;
            return View();
        }

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            int resultado = 0;
            List<int> resultados = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    resultado = numero / 2;
                }
                else
                {
                    resultado = (numero * 3) + 1;
                }
                numero = resultado;
                resultados.Add(resultado);
            }
            string numerosCollatz = "";
            foreach(int result in resultados)
            {
                numerosCollatz += result + ", ";
            }
            ViewData["RESULTADO"] = numerosCollatz;
            return View();
        }

    }
}
