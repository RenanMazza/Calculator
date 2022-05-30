
namespace calculator 
{
    class program
    {
        static void Main (string[] args)
        {
           Menu();
        }
        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Digite o Número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Será somado por:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            
            Console.ReadKey();
            Menu();

        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o Número:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Será diminuido por:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o Número:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Será dividido por:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            var divisao = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {divisao}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
           Console.Clear();

            Console.WriteLine("Digite o Número:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Será multiplicado por:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            var multiplicacao = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
            Console.ReadKey();
            Menu();

        }

        static void Menu()
        {
            

            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Fechar aplicação");
            Console.WriteLine("-----------------------");

            short resultado = short.Parse(Console.ReadLine());


            switch(resultado)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break; 
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Insira uma opção valida:"); break;

                

                
            }
              
               Menu();
               
                

             
        }
    }
}