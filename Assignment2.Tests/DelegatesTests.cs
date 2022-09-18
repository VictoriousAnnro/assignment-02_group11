namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void reverseString_tester()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        
        Reverse r = delegate(string line){
            foreach(char c in line.Reverse()){
                Console.Write(c);
            }
        };
        r("hello this is a test!");
        
        string reversed = "!tset a si siht olleh";

        Assert.Equal(reversed, stringWriter.ToString());
    }

    [Fact]
    public void Number_product_tester()
    {
        var product = (double n1, double n2) => n1*n2;

        var expected37 = 3.5*7.01;
        var expected35 = 3.1*5.9;

        Assert.Equal(expected37, product(3.5, 7.01));
        Assert.Equal(expected35, product(3.1, 5.9));

    }

    [Fact]
    public void Number_and_string_equal_tester()
    {
        var areEqual = (string line, int number) => {
            int lineNumber = int.Parse(line);
            if(lineNumber == number){
                return true;
            } return false;
        };

        Assert.True(areEqual("42", 42));
        Assert.True(areEqual(" 0042", 42));
        Assert.False(areEqual("13", 3));

    }



        public delegate void Reverse(string line);
}
