using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8C_
{
    internal class EmployeePasswordLogin
    {
        private Dictionary<string, string> employeeData = new Dictionary<string, string>();

        public void AddEmployee(string login, string password)
        {
            if (employeeData.ContainsKey(login))
            {
                Console.WriteLine("Цей логін вже існує.");
            }
            else
            {
                employeeData[login] = password;
                Console.WriteLine("Співробітника успішно додано.");
            }
        }

        public void RemoveEmployee(string login)
        {
            if (employeeData.Remove(login))
            {
                Console.WriteLine("Співробітника успішно видалено.");
            }
            else
            {
                Console.WriteLine("Логін не знайдено.");
            }
        }

        public void UpdateEmployee(string login, string newPassword)
        {
            if (employeeData.ContainsKey(login))
            {
                employeeData[login] = newPassword;
                Console.WriteLine("Інформацію оновлено.");
            }
            else
            {
                Console.WriteLine("Логін не знайдено.");
            }
        }

        public void GetPassword(string login)
        {
            if (employeeData.TryGetValue(login, out string password))
            {
                Console.WriteLine($"Пароль для логіна {login}: {password}");
            }
            else
            {
                Console.WriteLine("Логін не знайдено.");
            }
        }

        public void ListEmployees()
        {
            if (employeeData.Count > 0)
            {
                Console.WriteLine("Список логінів співробітників:");
                foreach (var login in employeeData.Keys)
                {
                    Console.WriteLine(login);
                }
            }
            else
            {
                Console.WriteLine("База даних порожня.");
            }
        }
    }
}
