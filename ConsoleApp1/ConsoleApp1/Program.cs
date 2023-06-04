using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBook EB = new EmployeeBook();
            Console.WriteLine("Введите команду операции:");
            string userCommand;
            while (true)
            {
                userCommand = Console.ReadLine();
                switch (userCommand)
                {
                    case "ListCommand":
                        Console.WriteLine("listCommand - выводит список команд\n" +
                            "Info - выводит всю информацию о штате сотрудников\n" +
                            "SummSalaryMonth - Сумма зарплаты в месяц\n" +
                            "MinWage - минимальная зарплата\n" +
                            "MaksWage - Масимальня зарплата\n" +
                            "AverageSalary - Средняя зарплата\n" +
                            "FioPerson - Краткая информация сотрудников\n" +
                            "IndexWage - Индексация зарплаты\n" +
                            "FindDepartment - Поиск сотрудника по определенному отделу\n" +
                            "GetNumber - получение информации о зарплате\n" +
                            "AddNewPerson - Добавление нового сотрудника\n" +
                            "DelPerson - удаление сотрудника");
                        break;
                    case "Info":
                        EB.EmployDataList();
                            break;
                    case "SummSalaryMonth":
                        EB.SummSalaryMonyh();
                        break;
                    case "MinWage":
                        EB.MinWage();
                        break;
                    case "MaksWage":
                        EB.MaksWage();
                        break;
                    case "AverageSalary":
                        EB.AverageSalary();
                        break;
                    case "FioPerson":
                        EB.FioPerson();
                        break;
                    case "IndexWage":
                        EB.IndexWage();
                        break;
                    case "FindDepartment":
                        EB.FindDepartment();
                        break;
                    case "GetNumber":
                        EB.GetNumber();
                        break;
                    case "AddNewPerson":
                        EB.AddNewPerson();
                        break;
                    case "DelPerson":
                        EB.DelPerson();
                        break;
                    case "UpdateSalary":
                        EB.EmployDataList();
                        break;
                    case "UpdateDepartment":
                        EB.EmployDataList();
                        break;

                        default:
                        Console.WriteLine("ListCommand - список команд");
                        break;
                }
            }
        }
    }
}