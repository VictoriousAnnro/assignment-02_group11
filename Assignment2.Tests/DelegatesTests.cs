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



        public delegate void Reverse(string line);
}
