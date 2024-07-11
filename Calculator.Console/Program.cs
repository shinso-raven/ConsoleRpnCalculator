// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Net.Http.Headers;
using Optional;
using RPNCalculator;

string menu =
@"
1. Solve a rpn operation.
99. Exit
";


Console.WriteLine("------------------Reverse Polish Notatino calculator---------------");

System.Console.WriteLine("\nSelect an option on the menu");


bool exit = false;
string input = "";

string output = "";

while (!exit)
{
    PrintMenu();

    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            DoOperation();
            Console.ReadLine();
            Console.Clear();
            break;
        case "99":
            exit = true;
            break;
        default:
            break;
    }


}

void DoOperation()
{

    Calculator_rpn _calculator = new Calculator_rpn();

    //Create input

    System.Console.WriteLine("-->Write the RPN operation to solve: ");
    string rpn_notation = Console.ReadLine();

    Option<RpnNotation, string> rpn = RpnNotation.From(rpn_notation);

    string result = _calculator.Calculate(rpn);

    //print result
    System.Console.WriteLine("\nYour result: " + result);

}

void PrintMenu()
{

    System.Console.WriteLine(menu);
}

public class Calculator_rpn
{
    public string Calculate(Option<RpnNotation, string> rpn)
    {

        RpnCalculation calculator = new RpnCalculation(rpn);
        string result = calculator.ResultOrError();

        return result;
    }
}


