using System.Text;

namespace ChessBoard
{ 
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            string e1 = "◻";
            string e2 = "◼";
            Console.WriteLine("hur stor brädda? ");
            
            int number = Int32.Parse(Console.ReadLine());

            int rows = number;
            int columns = number;
            
            

            

            for(int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < columns; j++) 
                {
                    if ((j + i) % 2 == 0) 
                    {
                        Console.Write(e1);
                        Console.Write(" ");


                    }
                    else 
                    {
                        Console.Write(e2);
                        Console.Write(" ");

                    }    
                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            




        }
    }
}