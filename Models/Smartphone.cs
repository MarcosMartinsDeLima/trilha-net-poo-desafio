using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get;set;}
        private string IMEI { get; set; }
        private int Memoria {get;set;}
        protected Stack<string> LogsChamada = new Stack<string>();
        protected List<string> Apps = new List<string>();



        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            DateTime dateTime = DateTime.Now;
            string dados = $"Chamada realizada em {dateTime}";
            LogsChamada.Push(dados);
        }


        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            DateTime dateTime = DateTime.Now;
            string dados = $"Chamada recebida em {dateTime}";
            LogsChamada.Push(dados);
        }

        public abstract void InstalarAplicativo(string nomeApp);

         public void ListarLogChamadas(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach(var Item in LogsChamada){
                Console.WriteLine(Item);
            }
            Console.ResetColor();
        }

        public void AppsInstalados (){
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach(var iten in Apps){
                Console.WriteLine(iten);
            }
            Console.ResetColor();
        }

        public void DesinstalarApp(){
            Console.WriteLine("Qual app deseja desinstalar");
            string nomeApp = Console.ReadLine();
            if(Apps.Any(x => x == nomeApp)){
                Apps.Remove(nomeApp);
                Console.WriteLine("App removido!");
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("App não encontrado!");
                Console.ResetColor();
            }

        
    }

   
    }}