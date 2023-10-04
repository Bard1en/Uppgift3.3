using System;
 namespace Uppgift3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            string Hyra = Console.ReadLine();
            int timmar = int.Parse(Hyra);
            switch (timmar)
            {
                case 0:
                    {
                        Console.WriteLine("du kan inte hyra en bil i 0 timmar.....");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Det kommer kosta 80kr");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Det kommer kosta 160kr");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Det kommer kosta 240kr");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Det kommer kosta 320kr");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Det kommer kosta 400kr");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Det kommer kosta 480kr");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Det kommer kosta 560kr");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Det kommer kosta 640kr");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Det kommer kosta 720kr");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Det kommer kosta 800kr");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Det kommer kosta 880kr");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Det kommer kosta 950kr");
                        break;  
                    }
            }



            }
    }
}