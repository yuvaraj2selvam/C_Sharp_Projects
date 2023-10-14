
using Atm;

internal class Program
{
    public static List<account> accounts = new List<account>();

    private static void Main(string[] args)
    {
        Program.accounts.Add(new account("yuvaraj", "123456", 1223445));
        new Display();
    }

}