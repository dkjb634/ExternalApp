namespace ExternalApp;

public class Printer
{
    public void Print(string text)
    {
        int i = new Random().Next(1, 6);
        for(int k = 0; k<i;k++)
            Console.WriteLine($"Hello {k}");
    }
}