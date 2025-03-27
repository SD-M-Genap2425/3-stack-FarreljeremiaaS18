using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        var historyManager = new HistoryManager();

        historyManager.KunjungiHalaman("google.com");
        Console.WriteLine("Mengunjungi halaman: google.com");

        historyManager.KunjungiHalaman("example.com");
        Console.WriteLine("Mengunjungi halaman: example.com");

        historyManager.KunjungiHalaman("stackoverflow.com");
        Console.WriteLine("Mengunjungi halaman: stackoverflow.com");

        Console.WriteLine($"Halaman saat ini: {historyManager.LihatHalamanSaatIni()}");

        Console.WriteLine("Kembali ke halaman sebelumnya...");
        historyManager.Kembali();
        Console.WriteLine($"Halaman saat ini: {historyManager.LihatHalamanSaatIni()}");

        Console.WriteLine("History:");
        historyManager.TampilkanHistory();


        // Bracket validator
        var validator = new BracketValidator();

        string ekspresiValid = "{[()]}";
        string ekspresiInvalid = "{[(])}";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {validator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {validator.ValidasiEkspresi(ekspresiInvalid)}");


        //Palindrome Checker
        string[] testStrings = { "Kasur ini rusak", "Ibu Ratna antar ubi", "Hello World" };

        foreach (string test in testStrings)
        {
            Console.WriteLine($"'{test}' -> {PalindromeChecker.CekPalindrom(test)}");
        }
    }
}
