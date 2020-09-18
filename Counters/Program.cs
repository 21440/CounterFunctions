using System;

namespace Counters
{
    class Program
    {
        static void Main(string[] args)
        {

            int end = 1;

            while (end == 1)
            {

                Console.Clear();
                Console.WriteLine("Counters Menu!\n===============");
                Console.WriteLine("A) Natural Counter");
                Console.WriteLine("B) Prime Counter");
                Console.WriteLine("C) Fibonacci Counter");
                Console.WriteLine("D) Exit.\n");

                string select = Console.ReadLine();

                switch (select.ToLower())
                {

                    case "a":

                        Console.Clear();
                        Console.WriteLine("Enter the maximum value of the counter: ");
                        int maxn = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        
                        var ncounter = NaturalCounter();
                        
                        for (int a = 0; a <= maxn; a++)
                        {

                            Console.WriteLine(ncounter());

                        }

                        Console.ReadLine();

                        break;

                    case "b":

                        Console.Clear();
                        Console.WriteLine("Enter the maximum value of the counter: ");
                        int maxp = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        var primeCounter = PrimeCounter(maxp);
                        
                        while(true){
                            
                            int pCounter = primeCounter();
                            
                            if(pCounter == 1){
                                
                                break;
                                
                            }
                            
                            Console.WriteLine(pCounter);
                            
                        }

                        Console.ReadLine();

                        break;

                    case "c":

                        Console.Clear();
                        Console.WriteLine("Enter the length of the sequence: ");
                        int maxf = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        var fCounter = FiboCounter();
            
                        for (int i = 0; i < maxf; i++)
                            {

                                Console.WriteLine(fCounter());
                                
                            }

                        Console.ReadLine();
                        
                        break;

                    case "d":

                        Console.Clear();
                        Environment.Exit(0);

                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine("That option is invalid, try again.");

                        Console.ReadLine();

                        break;

                }

            }

            
        }

        static Func<int> NaturalCounter()
        {
            
            int n = 0;

            return() => n++;

        }

        static Func<int> PrimeCounter(int final)
        {

            int start = 1;
            bool[] not = new bool [final];
            
            return() => {
                
                if(start >=  final - 3) return 1;
            
                while(start < final && not[++start]);
                    
                    int counter = 1;
                    
                    while(start * counter < final){
                        
                        not[start * counter] = true;
                        counter++;
                        
                    }
                    
            return start;
                    
            };
            
        }

        static Func<int> FiboCounter()
        {

            int n1 = 0;
            int n2 = 1;
            
            return() =>{
                
            int temp = n1;
            n1 = n2;
            n2 = temp + n2;
                
            
            return n1;
                
            };
            
        }

    }
}
