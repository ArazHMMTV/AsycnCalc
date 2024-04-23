using System;

namespace OptionalCalc
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            AddandSubtract addandSubtract = new AddandSubtract();
            MultiandDivide multiandDivide = new MultiandDivide();
            while (true)
            {
                Console.WriteLine("Her hansi birini secin.");
                Console.WriteLine("1.Toplama\n 2.Cixma\n 3.Vurma\n 4.Bolme\n 0.Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Ilk ededi daxil edin");
                        double num1=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ikinci ededi daxil edin");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = await  addandSubtract.Add(num1, num2);
                        Console.WriteLine($"Cem {result}");
                        break;

                        case "2":
                        Console.WriteLine("Ilk ededi daxil edin");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ikinci ededi daxil edin");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = await addandSubtract.Subtract(num1, num2);
                        Console.WriteLine($"Ferq {result}");
                        break;
                        case "3":
                        Console.WriteLine("Ilk ededi daxil edin");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ikinci ededi daxil edin");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = await multiandDivide.Multi(num1, num2);
                        Console.WriteLine($"Hasil {result}");
                        break;
                        case "4":
                        Console.WriteLine("Ilk ededi daxil edin");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ikinci ededi daxil edin");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = await multiandDivide.Divide(num1, num2);
                        Console.WriteLine($"Boluk {result}");
                        break;
                        break;
                        case "0":
                        Console.WriteLine("Programdan cixildi");
                        break;
                }
            }
        }
    }
}
