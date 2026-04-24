namespace CalculadoraComisiones.Models
{
    public class ComisionRequest
    {
        public decimal Ventas { get; set; }
        public decimal Descuento { get; set; }
        public string Pais { get; set; } = string.Empty;
    }
}
