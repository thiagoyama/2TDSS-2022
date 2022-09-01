using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //Abrir a página com o formulário
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(int n1, int n2, string operacao)
        {
            int resultado;
            switch (operacao)
            {
                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    try
                    {
                        resultado = n1 / n2;
                    }
                    catch (Exception)
                    {
                        resultado = 0;
                    }
                    break;
                default:
                    resultado = 0;
                    break;
            }
            //Enviar o resultado para a view, tempData -> funciona com redirect
            TempData["resultado"] = resultado;
            return RedirectToAction("Calcular"); //Redireciona para um método
        }
    }
}
