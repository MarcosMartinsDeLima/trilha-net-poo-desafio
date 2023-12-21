

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp) 
        {
            Apps.Add(nomeApp);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
            Console.WriteLine("...");
            Console.WriteLine("Instalado");
            Console.ResetColor();
        }

        
    }
}