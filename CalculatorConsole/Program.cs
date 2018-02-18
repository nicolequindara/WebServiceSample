using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Program
    {
        enum OPERATION
        {
            ADD = 1,
            SUBTRACT = 2,
            MULTIPLY = 3,
            DIVIDE = 4
        }

        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    String input;
                    int a, b;
                    int type;

                    write("Enter first integer argument:\t ");
                    input = Console.ReadLine();
                    int.TryParse(input, out a);


                    write("Enter second integer argument:\t ");
                    input = Console.ReadLine();
                    int.TryParse(input, out b);

                    write("Enter type of operation:\n");
                    write("\t 1: ADD\n");
                    write("\t 2: SUBTRACT\n");
                    write("\t 3: MULTIPLY\n");
                    write("\t 4: DIVIDE\n");
                    input = Console.ReadLine();
                    int.TryParse(input, out type);

                    Calculate(a, b, (OPERATION)type);

                }
                catch(Exception ex)
                {
                    printError(ex.Message);
                }
            }
        }

        static void Calculate(int a, int b, OPERATION type)
        {
            localhost.CalculatorService calculatorService = new localhost.CalculatorService();
            int result;

            switch (type)
            {
                case OPERATION.ADD:
                    result = calculatorService.Add(a, b);
                    printSuccess(string.Format("{0} + {1} = {2}", a, b, result));
                    break;
                case OPERATION.SUBTRACT:
                    result = calculatorService.Subtract(a, b);
                    printSuccess(string.Format("{0} - {1} = {2}", a, b, result));
                    break;
                case OPERATION.MULTIPLY:
                    result = calculatorService.Multiply(a, b);
                    printSuccess(string.Format("{0} * {1} = {2}", a, b, result));
                    break;
                case OPERATION.DIVIDE:
                    result = calculatorService.Divide(a, b);
                    printSuccess(string.Format("{0} / {1} = {2}", a, b, result));

                    break;
                default:
                    printError("Unknown operation: " + type);
                    break;
            }
        }

        static void write(string message)
        {
            Console.Write(message);
        }

        static void printError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void printSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
