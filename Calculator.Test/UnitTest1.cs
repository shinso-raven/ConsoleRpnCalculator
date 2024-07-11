using Optional;
using RPNCalculator;

namespace Calculator.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("20 5 /", "4")]
    [TestCase("20 5 +", "25")]
    [TestCase("20 5 -", "15")]
    [TestCase("20 5 *", "100")]
    [TestCase("100 5 /", "20")]
    [TestCase("20 4 / ", "5")]
    public void Calculator_solves_basic_Operations(string input, string expectResult)
    {
        Calculator_rpn _calculator = new Calculator_rpn();

        Option<RpnNotation, string> rpn = RpnNotation.From(input);
        string result = _calculator.Calculate(rpn);


        Assert.That(result, Is.EqualTo(expectResult));
    }


    // 20 5 /
    // result o error

    /*
    rpnnotation rpn = new RPnnotation(string input);

RpnCalculator calcultator = new RPncalcultor(rpn);
    string result =  obj.ResultOrErro() 


Calculator 

    CalculateAnswer



    */



    // 
}
