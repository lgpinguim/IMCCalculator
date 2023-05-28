namespace IMCCalculator.Models
{
    public class IMC
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Resultado { get; set; }

        public void CalculaIMC()
        {
            if (Peso ==0 || Altura ==0)
            {
                Resultado = 0;
            }

            Resultado = Math.Round(Peso / Math.Pow(Altura, 2),2);

        }
    }
}
