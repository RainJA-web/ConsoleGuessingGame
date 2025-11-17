using System;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Chào mừng đến với Trò chơi Đoán Số!");
        Console.WriteLine("Tôi đã chọn một số bí mật từ 1 đến 100. Hãy thử đoán xem!");
        Console.WriteLine("-----------------------------------------------------");

        int secretNumber = new Random().Next(1, 101);
        bool isGuessedCorrectly = false;
        int guessCount = 0;

        while (!isGuessedCorrectly)
        {
            Console.Write("Lần đoán #{0}: Nhập số của bạn (1-100): ", guessCount + 1);
            string? inputString = Console.ReadLine();
            int userGuess = 0;

            if (string.IsNullOrWhiteSpace(inputString) ||
                !int.TryParse(inputString, out userGuess) ||
                userGuess < 1 || userGuess > 100)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ trong phạm vi từ 1 đến 100.");
                continue; 
            }

            guessCount++;

            if (userGuess == secretNumber)
            {
                Console.WriteLine($"\nCHÚC MỪNG! Bạn đã đoán đúng số bí mật ({secretNumber})!");
                Console.WriteLine($"Bạn đã hoàn thành trò chơi trong {guessCount} lần đoán.");
                isGuessedCorrectly = true;
            }
            else if (userGuess > secretNumber)
            {
                Console.WriteLine("⬇️ Số bạn đoán quá lớn. Hãy thử lại.");
            }
            else
            {
                Console.WriteLine("⬆️ Số bạn đoán quá nhỏ. Hãy thử lại.");
            }
            Console.WriteLine("-----------------------------------------------------");
        }

        Console.WriteLine("Nhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}