using System;

namespace ConsoleApp3
{

    // class fabricio{
    //    public static string name = "name :coffeeffee";
    //    public static string favoriteDrink = "coffee";
    //    private static string lastname = "last name :I Don't Have One";
    //    public static int age =  22;
    //}

        //color u do Console.ForegroundColor = ConsoleColor.white
        // alert in c# console is like
        //Console.write("Ask aquestion:")
        // kinda like a prompt
        //Console.ReadLine();
    class Program
    {
        static void Main(string[] args)
        {
            
            
            while(true){
                Console.Write("Ask a question:");

                //question string stores the line that I am on. 
                string questionString = Console.ReadLine();

               // Console.Write("Ask a question:");
                Console.Write(questionString);


            }

        }
    }
}
