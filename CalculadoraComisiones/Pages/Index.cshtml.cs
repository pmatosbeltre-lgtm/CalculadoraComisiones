using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalculadoraComisiones.Services;

namespace CalculadoraComisiones.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ComisionService _service;

        public IndexModel()
        {
            _service = new ComisionService();
        }

        [BindProperty]
        public string Pais { get; set; } = string.Empty;

        [BindProperty]
        public decimal Ventas { get; set; }

        [BindProperty]
        public decimal Descuentos { get; set; }

        public decimal Resultado { get; set; }

        public void OnPost()
        {
            if (Pais == string.Empty)
                {
                ModelState.AddModelError("Pais", "El país es requerido.");
            }

            if (Ventas <= 0)
            {
                ModelState.AddModelError("Ventas", "Las ventas deben ser mayores a cero.");
            }

            if (Descuentos <= 0)
                {
                ModelState.AddModelError("Descuentos", "Los descuentos deben ser mayores a cero.");
            }
            if (Descuentos > Ventas)
            {
                ModelState.AddModelError("Descuentos", "Los descuentos no pueden ser mayores que las ventas.");
            }
            if (!ModelState.IsValid)
            {
                return;
            }

            Resultado = _service.Calculate(Pais, Ventas, Descuentos);
        }
    }
}