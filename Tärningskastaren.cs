using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tärningssimulator
{
    class Program
    {
        private static int sum;
        private static int randomNumber;
        private static int counter = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("Mitt namn: Oscar Forss");
            Console.WriteLine("Datum för färdigställade: 2020-04-24");
            Console.WriteLine();
            Console.WriteLine("Tryck Enter för att start programmet.");
            Console.ReadLine();
            Console.Clear();

            //Används om man vill spela igen eller matat in fel värde av antal kast
            Start:
            //Här startar själva "Tärningsspelet"
            Console.WriteLine("*** VÄLKOMMEN TILL TÄRNINGSKASTAREN ***");
            Console.WriteLine();
            
            Console.Write("Börja med att ange hur många tärning du vill kasta? (välj mellan 1 och 4 st): ");
            bool status = int.TryParse(Console.ReadLine(), out int antalKast);


                //Här kollar vi om användaren har valt mellan 1 och 4 kast
                if (antalKast >=1 && antalKast <=4 )
                {
                    provaIgen:
                    
                    for (int i = 0; i < antalKast; i++)
                    {
                        //Detta är för att generera ett random nummer mellan 1-6
                        Random random = new Random();
                        randomNumber = random.Next(1, 7);
                        
                        //Om nummret blir ett så får man slå 2 tärningar till
                        if (randomNumber == 1)
                        {
                            Console.WriteLine("Du slog en 1, varje gång du slår en 1 kommer du få kasta 2 tärningar till");
                            int tal1 = 2;
                            antalKast += tal1;
                            Console.WriteLine("Tryck enter för att kasta nästa");
                            Console.ReadLine();
                            goto provaIgen;
                           
                        }
                        //Om man matat in felaktigt värde i hur många kast man vill göra
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Du slog nummer {0} på tärningen", randomNumber);
                            Console.WriteLine("Tryck enter för att kasta nästa");
                            Console.ReadLine();
                        }
                        
                    //Här skriver vi ut summan av de slagna tärningarna
                    sum += randomNumber;
                    
                    Console.WriteLine("Summan av tärningarna du kastat är: {0}", sum);

                    //Här räknar vi hur många gånger vi kör loopen för att få fram hur många tärningskast som görs
                    counter++;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Du är nu klar med kasten, tryck Enter för resultat");
                    Console.ReadLine();
                    Console.Clear();
                    //Valde att ta bort alla tärningsslag för att bara visa resultatet här
                    Console.WriteLine();
                    Console.WriteLine("Antal slagna tärningar: {0}", counter);
                    Console.WriteLine();
                    Console.WriteLine("Totala summan av alla slag är: {0}", sum);
                }
                //Hit skickas användaren då den ej valt mellan 1 och 4 kast
                else
                {
                    Console.WriteLine("Du har matat in fel antal kast!");
                    Console.WriteLine();
                    Console.WriteLine("Tryck enter för att testa igen...");
                    Console.ReadLine();
                    Console.Clear();
                
                    goto Start;
                }
            //Alternativ om man vill spela igen eller avsluta
            Console.WriteLine("Vill du spela igen eller vill du avsluta programmet? \" Ja/Avsluta \" ");
            string spelaIgen = Console.ReadLine().ToLower();

            switch (spelaIgen)
            {
                case "ja":
                    sum = 0;
                    counter = 0; // Dessa 2 är för att nollställa "Antal slagna tärningar" och "Totala summan av alla slag är"
                    goto Start;
                default:
                    break;
            }
                 
            

            
        }


    }
}
