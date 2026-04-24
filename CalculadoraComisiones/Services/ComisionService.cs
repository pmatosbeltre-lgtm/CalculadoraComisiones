namespace CalculadoraComisiones.Services
{
    public class ComisionService
    {
        public decimal Calculate(string pais, decimal ventas, decimal descuento)
        {
            decimal net = ventas - descuento;

            return pais switch
            {
                "India" => net * 0.10m,
                "US" => net * 0.15m,
                "UK" => net * 0.12m,
                "Germany" => net * 0.08m,
                "Brazil" => net * 0.05m,
                "Mexico" => net * 0.07m,
                "Republica Dominicana" => net * 0.09m,
                _ => 0
            };
        }
    }
}
