using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EmployeeBook
    {
        Employee employee = new Employee();
        List<Employee> employees = new List<Employee>()
            {
                new("Петрова Лариса Генадевна", 3, 12300),
                new("Лысеков Иван Дмитреевич", 1, 9000),
                new("Охоткина Марина Евгенева", 5, 17990),
                new("Фузубов Никита Романович", 2, 21000),
                new("Лесопал Родион Алксандрович", 3, 14200),
                new("Ухова Анна Олеговна", 3, 25000),
                new("Минин Евгений Прокофьев", 1, 19000),
                new("Крысов Антон Владимирович", 3, 16000),
                new("Бешумов Степан Иванов", 4, 23000),
                new("Остров Михаил Сергеевич", 2, 20000),
            };
        public void EmployDataList()
        {
            employee.IdUpdate();
            foreach (var emp in employees)
            {
                Console.WriteLine($"#{employee.Id()} | ФИО: {emp.Fio} | Отделение: {emp.Department} | Зарплата: {emp.Salary}");
            }
        }
        public void SummSalaryMonyh()
        {
            double summ = 0;
            foreach (var emp in employees)
            {
                summ += emp.Salary;
            }
            Console.WriteLine($"Сумма затрат на зарплаты в месяц: {summ}");
        }
        public void MinWage()
        {
            string fioMinWage = string.Empty;
            double valueMinWage = 200000;
            foreach (var emp in employees)
            {
                if (valueMinWage > emp.Salary)
                {
                    fioMinWage = emp.Fio;
                    valueMinWage = emp.Salary;
                }
            }
            Console.WriteLine($"Минимальная зарплата у {fioMinWage}, она состовляет {valueMinWage}");
        }
        public void MaksWage()
        {
            string fioMaxWage = string.Empty;
            double valueMaxWage = 0;
            foreach (var emp in employees)
            {
                if (valueMaxWage < emp.Salary)
                {
                    fioMaxWage = emp.Fio;
                    valueMaxWage = emp.Salary;
                }
            }
            Console.WriteLine($"Максимальня зарплата у {fioMaxWage}, она состовляет {valueMaxWage}");
        }
        public void AverageSalary()
        {
            int counter = 0;
            double summ = 0;
            foreach (var emp in employees)
            {
                summ += emp.Salary;
                counter++;
            }
            Console.WriteLine($"Среднее значение зарплаты состовляет {summ / counter}");
        }
        public void FioPerson()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.Fio);
            }
        }
        public void IndexWage()
        {
            double index = 1.5;
            foreach (var emp in employees)
            {
                Console.WriteLine($"Зарплата уввеиченная на 50%: {emp.Salary * index}");
            }
        }
        public void FindDepartment()
        {
            Console.Write("Введите номер отдела: ");
            int nuberDepartment = int.Parse(Console.ReadLine());
            void MinWage()
            {
                double minWage = 200000;
                foreach (var emp in employees)
                {
                    if (emp.Department == nuberDepartment)
                    {
                        if (minWage > emp.Salary)
                        {
                            minWage = emp.Salary;
                        }
                    }
                }
                Console.WriteLine($"Отдел: {nuberDepartment} миниммальная зарплата: {minWage}");

            }
            void MaxWage()
            {
                double maxWage = 0;
                foreach (var emp in employees)
                {
                    if (emp.Department == nuberDepartment)
                    {
                        if (maxWage < emp.Salary)
                        {
                            maxWage = emp.Salary;
                        }
                    }
                }
                Console.WriteLine($"Отдел: {nuberDepartment} Максимальная зарплата: {maxWage}");

            }
            void MiddleWage()
            {
                int count = 0;
                double wage = 0;
                foreach (var emp in employees)
                {
                    if (emp.Department == nuberDepartment)
                    {
                        wage += emp.Salary;
                        count++;
                    }
                }
                Console.WriteLine($" Средняя зарплата{wage = wage / count}");
            }
            void IndexWage()
            {
                foreach (var emp in employees)
                {
                    if (emp.Department == nuberDepartment)
                    {
                        Console.WriteLine($"На 30% {emp.Salary * 1.3}");
                    }
                }
            }
            void AllPerson()
            {
                foreach (var emp in employees)
                {
                    if (emp.Department == nuberDepartment)
                    {
                        Console.WriteLine($"{emp.Fio} {emp.Salary}");
                    }
                }
            }
            MinWage();
            MaxWage();
            MiddleWage();
            IndexWage();
            AllPerson();
        }
        public void GetNumber()
        {
            Console.Write("Введите число: ");
            double userNumber = double.Parse(Console.ReadLine());
            void MinWageNumber()
            {
                employee.IdUpdate();
                foreach (var emp in employees)
                {
                    if (userNumber > emp.Salary)
                    {
                        Console.WriteLine($"{employee.Id()} {emp.Fio} {emp.Salary}");
                    }
                }
            }
            void MaxWageumber()
            {
                employee.IdUpdate();
                foreach (var emp in employees)
                {
                    if (userNumber <= emp.Salary)
                    {
                        Console.WriteLine($"{employee.Id()} {emp.Fio} {emp.Salary}");
                    }
                }
            }
            MinWageNumber();
            Console.WriteLine();
            MaxWageumber();
        }
        public void AddNewPerson()
        {
              Employee newPerson = new Employee();
              Console.WriteLine("Введите ФИО:");
              newPerson.Fio = Console.ReadLine();
              Console.WriteLine("Введите номер отдела");
              newPerson.Department = int.Parse(Console.ReadLine());
              Console.WriteLine("Введите зарплату");
              newPerson.Salary = double.Parse((Console.ReadLine()));
              employees.Add(newPerson);
            foreach (var emp in employees)
            {
                Console.WriteLine($"#{employee.Id()} | ФИО: {emp.Fio} | Отделение: {emp.Department} | Зарплата: {emp.Salary}");
            }
        }
        public void DelPerson()
        {
            Console.Write("Введите Id сотрудника: ");
            int id = int.Parse((Console.ReadLine()));
            employees.RemoveAt(id - 1);
            employee.IdUpdate();
            foreach (var emp in employees)
            {
                Console.WriteLine($"#{employee.Id()} | ФИО: {emp.Fio} | Отделение: {emp.Department} | Зарплата: {emp.Salary}");
            }
        }
        public void UpdateSalary()
        {
            Console.WriteLine("Изменение зарплаты");
            Console.WriteLine("Напишите ФИО сотрудника");
            string UpdateSalaryPerson = Console.ReadLine();
            Console.WriteLine("Напишите зарплату:");
            double UpdateSP = double.Parse(Console.ReadLine());
            foreach (var i in employee.Fio)
            {
                if (employee.Fio == UpdateSalaryPerson)
                {
                    employee.Salary = UpdateSP;
                }
            }
        }
        public void UpdateDepartment()
        {
            Console.WriteLine("Изменение отдела");
            Console.WriteLine("Напишите ФИО сотрудника");
            string UpdateDepartmenPerson = Console.ReadLine();
            Console.WriteLine("Напишите отдел:");
            int UpdateDP = int.Parse(Console.ReadLine());
            foreach (var i in employee.Fio)
            {
                if (employee.Fio == UpdateDepartmenPerson)
                {
                    employee.Department = UpdateDP;
                }
            }
        }
    }
}
