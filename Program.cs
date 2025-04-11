using System;

namespace BankAccountApp
{
    // Клас Банківський рахунок
    public class BankAccount
    {
        // Властивості
        public string AccountNumber { get; set; }   // Номер рахунку
        public double Balance { get; private set; } // Баланс (тільки для читання ззовні)

        // Конструктор
        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        // Метод поповнення рахунку
        public void PopovnitiRahunok(double suma)
        {
            if (suma > 0)
            {
                Balance += suma;
                Console.WriteLine($"Рахунок поповнено на {suma} грн.");
            }
            else
            {
                Console.WriteLine("Сума для поповнення має бути більшою за 0.");
            }
        }

        // Метод зняття грошей
        public void ZnyatyHroshi(double suma)
        {
            if (suma <= 0)
            {
                Console.WriteLine("Сума має бути більшою за 0.");
            }
            else if (suma > Balance)
            {
                Console.WriteLine("Недостатньо коштів на рахунку.");
            }
            else
            {
                Balance -= suma;
                Console.WriteLine($"Знято {suma} грн з рахунку.");
            }
        }

        // Метод показу інформації
        public void PokazatyInformatsiyu()
        {
            Console.WriteLine($"Номер рахунку: {AccountNumber}");
            Console.WriteLine($"Поточний баланс: {Balance} грн");
        }
    }

    // Основна програма
    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єкта рахунку
            BankAccount myAccount = new BankAccount("UA1234567890", 1000.0);

            // Вивід початкової інформації
            Console.WriteLine("Початковий стан рахунку:");
            myAccount.PokazatyInformatsiyu();

            Console.WriteLine("\nПоповнення на 500 грн...");
            myAccount.PopovnitiRahunok(500);

            Console.WriteLine("\nСпроба зняти 200 грн...");
            myAccount.ZnyatyHroshi(200);

            Console.WriteLine("\nСпроба зняти 2000 грн (забагато)...");
            myAccount.ZnyatyHroshi(2000);

            Console.WriteLine("\nкінцева інформація про рахунок:");
            myAccount.PokazatyInformatsiyu();

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}

