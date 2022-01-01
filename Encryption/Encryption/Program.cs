using Encryption;

class Program
{
    static void Main(string[] args)
    {
        Cipher cpr = new Cipher();
        Console.WriteLine("Please enter the characters you want to be encrypted:");
        string response = cpr.encode(Console.ReadLine());
        Console.WriteLine("Encrypted version with first class: " + response);
        string response2 = cpr.decode(response);
        Console.WriteLine("Decrypted version with first class: " + response2);

        Cipher64 cpr64 = new Cipher64();
        Console.WriteLine("Please enter the characters you want to be encrypted:");
        response = cpr64.encode(Console.ReadLine());
        Console.WriteLine("Encrypted version with second class: " + response);
        response2 = cpr64.decode(response);
        Console.WriteLine("Decrypted version with second class: " + response2);

        Console.WriteLine("Please enter a character to stop the program");
        Console.ReadKey();
    }
}


