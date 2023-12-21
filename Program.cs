using DesafioPOO.Models;

//instanciado as classes

Iphone iphone14 = new Iphone("223","modelo1","1232223",128);

Nokia nokia = new Nokia("333","modelo2","123233",32);

bool exibirMenu = true;
bool exibirCell = true;
//menu
while(exibirMenu == true){
    Console.Clear();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - para Iphone ");
    Console.WriteLine("2 - para Nokia \n");
    string opcao = Console.ReadLine();

    if(opcao == "1"){
        Console.WriteLine("Iphone:");

        while(exibirCell == true){

            Console.Clear();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - para Ligar");
            Console.WriteLine("2 - para Receber ligação ");
            Console.WriteLine("3 - para instalar um app");
            Console.WriteLine("4 - para listar log de  chamadas");
            Console.WriteLine("5 - para listar os apps intalados");
            Console.WriteLine("6 - para desinstalar um app");
            Console.WriteLine("7 - para sair\n");
            opcao = Console.ReadLine();
            
            switch(opcao){
                case "1": 
                    iphone14.Ligar();
                    break;
                case "2":
                    iphone14.ReceberLigacao();
                    break;
                case "3":
                    Console.WriteLine("Digite o nome do aplicativo:\n");
                    string app = Console.ReadLine();
                    iphone14.InstalarAplicativo(app);
                    break;
                case "4":
                    iphone14.ListarLogChamadas();
                    break;
                case "5":
                    iphone14.AppsInstalados();
                    break;
                case "6":
                    iphone14.DesinstalarApp();
                    break;
                case "7":
                    Console.WriteLine("Saindo...\n");
                    exibirCell= false;
                    break;
            }

            Console.WriteLine("Digite qualquer tecla para continuar");
            Console.ReadLine();
        }
    }

    else if(opcao == "2"){
        Console.WriteLine("nokia");

        while(exibirCell == true){

            Console.Clear();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - para Ligar");
            Console.WriteLine("2 - para Receber ligação ");
            Console.WriteLine("3 - para instalar um app");
            Console.WriteLine("4 - para listar log de chamada");
            Console.WriteLine("5 - para listar os apps intalados");
            Console.WriteLine("6 - para desinstalar um app");
            Console.WriteLine("7 - para sair\n");
            opcao = Console.ReadLine();
            
            switch(opcao){
                case "1": 
                    nokia.Ligar();
                    break;
                case "2":
                    nokia.ReceberLigacao();
                    break;
                case "3":
                    Console.WriteLine("Digite o nome do aplicativo:\n");
                    string app = Console.ReadLine();
                    nokia.InstalarAplicativo(app);
                    break;
                case "4":
                    nokia.ListarLogChamadas();
                    break;
                case "5":
                    nokia.AppsInstalados();
                    break;
                case "6":
                    nokia.DesinstalarApp();
                    break;
                case "7":
                    Console.WriteLine("Saindo...\n");
                    exibirCell= false;
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }

            Console.WriteLine("Digite qualquer tecla para continuar");
            Console.ReadLine();
        }
    }
}
