namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone(String numero,string modelo, string imei,int memoria ) : base(numero,modelo,imei,memoria){}
       
        public override void InstalarAplicativo(string nomeApp)
        {   
            Apps.Add(nomeApp);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
            Console.WriteLine("...");
            Console.WriteLine("Instalado");
            Console.ResetColor();
        }
    }
}