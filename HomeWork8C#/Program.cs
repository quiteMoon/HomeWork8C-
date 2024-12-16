using System.Text;

namespace HomeWork8C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = UTF8Encoding.UTF8;
            Console.OutputEncoding = UTF8Encoding.UTF8;

            // Task 1
            //EmployeePasswordLogin manager = new EmployeePasswordLogin();

            //while (true)
            //{
            //    Console.WriteLine("\nВиберіть дію:");
            //    Console.WriteLine("1. Додати співробітника");
            //    Console.WriteLine("2. Видалити співробітника");
            //    Console.WriteLine("3. Оновити пароль співробітника");
            //    Console.WriteLine("4. Отримати пароль співробітника");
            //    Console.WriteLine("5. Переглянути список співробітників");
            //    Console.WriteLine("6. Вийти");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Введіть логін: ");
            //            string loginToAdd = Console.ReadLine();
            //            Console.Write("Введіть пароль: ");
            //            string passwordToAdd = Console.ReadLine();
            //            manager.AddEmployee(loginToAdd, passwordToAdd);
            //            break;

            //        case "2":
            //            Console.Write("Введіть логін для видалення: ");
            //            string loginToRemove = Console.ReadLine();
            //            manager.RemoveEmployee(loginToRemove);
            //            break;

            //        case "3":
            //            Console.Write("Введіть логін для оновлення: ");
            //            string loginToUpdate = Console.ReadLine();
            //            Console.Write("Введіть новий пароль: ");
            //            string newPassword = Console.ReadLine();
            //            manager.UpdateEmployee(loginToUpdate, newPassword);
            //            break;

            //        case "4":
            //            Console.Write("Введіть логін для отримання пароля: ");
            //            string loginToGet = Console.ReadLine();
            //            manager.GetPassword(loginToGet);
            //            break;

            //        case "5":
            //            manager.ListEmployees();
            //            break;

            //        case "6":
            //            Console.WriteLine("Завершення програми.");
            //            return;

            //        default:
            //            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
            //            break;
            //    }
            //}

            //Task 2
            //EnglishFrenchDictionary dictionary = new EnglishFrenchDictionary();

            //while (true)
            //{
            //    Console.WriteLine("\nВиберіть дію:");
            //    Console.WriteLine("1. Додати слово і переклади");
            //    Console.WriteLine("2. Видалити слово");
            //    Console.WriteLine("3. Видалити переклад");
            //    Console.WriteLine("4. Оновити слово");
            //    Console.WriteLine("5. Оновити переклад");
            //    Console.WriteLine("6. Пошук перекладу");
            //    Console.WriteLine("7. Вийти");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Введіть слово англійською: ");
            //            string englishWord = Console.ReadLine();
            //            Console.Write("Введіть переклади французькою (через кому): ");
            //            List<string> frenchTranslations = new List<string>(Console.ReadLine().Split(", "));
            //            dictionary.AddWord(englishWord, frenchTranslations);
            //            break;

            //        case "2":
            //            Console.Write("Введіть слово для видалення: ");
            //            string wordToRemove = Console.ReadLine();
            //            dictionary.RemoveWord(wordToRemove);
            //            break;

            //        case "3":
            //            Console.Write("Введіть слово англійською: ");
            //            string wordForTranslationRemoval = Console.ReadLine();
            //            Console.Write("Введіть переклад для видалення: ");
            //            string translationToRemove = Console.ReadLine();
            //            dictionary.RemoveTranslation(wordForTranslationRemoval, translationToRemove);
            //            break;

            //        case "4":
            //            Console.Write("Введіть старе слово: ");
            //            string oldWord = Console.ReadLine();
            //            Console.Write("Введіть нове слово: ");
            //            string newWord = Console.ReadLine();
            //            dictionary.UpdateWord(oldWord, newWord);
            //            break;

            //        case "5":
            //            Console.Write("Введіть слово англійською: ");
            //            string wordForTranslationUpdate = Console.ReadLine();
            //            Console.Write("Введіть старий переклад: ");
            //            string oldTranslation = Console.ReadLine();
            //            Console.Write("Введіть новий переклад: ");
            //            string newTranslation = Console.ReadLine();
            //            dictionary.UpdateTranslation(wordForTranslationUpdate, oldTranslation, newTranslation);
            //            break;

            //        case "6":
            //            Console.Write("Введіть слово для пошуку: ");
            //            string wordToSearch = Console.ReadLine();
            //            dictionary.GetTranslations(wordToSearch);
            //            break;

            //        case "7":
            //            Console.WriteLine("Завершення програми.");
            //            return;

            //        default:
            //            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
            //            break;
            //    }
            //}

            //Task 3
            //Console.Write("Введіть кількість столиків у кафе: ");
            //int tableCount = int.Parse(Console.ReadLine());

            //CafeQueue cafeQueue = new CafeQueue(tableCount);

            //while (true)
            //{
            //    Console.WriteLine("\nОберіть дію:");
            //    Console.WriteLine("1. Додати відвідувача у чергу");
            //    Console.WriteLine("2. Додати відвідувача до резерву");
            //    Console.WriteLine("3. Звільнити столик");
            //    Console.WriteLine("4. Зайняти столик");
            //    Console.WriteLine("5. Вийти");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Введіть ім'я відвідувача: ");
            //            string visitorName = Console.ReadLine();
            //            cafeQueue.AddVisitor(visitorName);
            //            break;

            //        case "2":
            //            Console.Write("Введіть ім'я відвідувача: ");
            //            string reservedVisitorName = Console.ReadLine();
            //            Console.Write("Введіть час резерву (у форматі HH:mm): ");
            //            DateTime reservationTime = DateTime.Parse(Console.ReadLine());
            //            cafeQueue.AddVisitor(reservedVisitorName, reservationTime);
            //            break;

            //        case "3":
            //            cafeQueue.FreeTable();
            //            break;

            //        case "4":
            //            cafeQueue.OccupyTable();
            //            break;

            //        case "5":
            //            Console.WriteLine("Завершення роботи програми.");
            //            return;

            //        default:
            //            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
            //            break;
            //    }
            //}
        }
    }
}
