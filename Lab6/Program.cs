namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {

        Stack<Employee> employees = new Stack<Employee>();


        Employee employee1 = new Employee(1, "Adam", "Male", 70000);
        Employee employee2 = new Employee(2, "Alax", "Male", 100000);
        Employee employee3 = new Employee(3, "Lara", "Female", 50000);
        Employee employee4 = new Employee(4, "Lada", "Female", 90000);
        Employee employee5 = new Employee(5, "Adelina", "Female", 80000);

        employees.Push(employee1);
        employees.Push(employee2);
        employees.Push(employee3);
        employees.Push(employee4);
        employees.Push(employee5);

        foreach (Employee employe in employees)
        {
            Console.WriteLine($"{employe.Id} - {employe.Name} - {employe.Gender} - {employe.Salary}");
            Console.WriteLine($"Items left in the Stack = {employees.Count}");
        }


        Console.WriteLine("----------------------------");
        Console.WriteLine("Retrieve Using Pop Method");

        while (employees.Count > 0)
        {
            Employee employe = employees.Pop();

            Console.WriteLine($"{employe.Id} - {employe.Name} - {employe.Gender} - {employe.Salary}");

            Console.WriteLine($"Items left in the Stack = {employees.Count}");
        }

        employees.Push(employee1);
        employees.Push(employee2);
        employees.Push(employee3);
        employees.Push(employee4);
        employees.Push(employee5);

        Console.WriteLine("----------------------------");
        Console.WriteLine("Retrieve Using Peek Method");


        for (int i = 0; i < 2; i++)
        {

            Employee employe = employees.Peek();

            Console.WriteLine($"{employe.Id} - {employe.Name} - {employe.Gender} - {employe.Salary}");

            Console.WriteLine($"Items left in the Stack = {employees.Count}");
        }

        // Check if employee number 3 is in the stack
        if (employees.Contains(employee3))
        {
            Console.WriteLine("Emp3 is in stack");
        }
        else
        {
            Console.WriteLine("Emp3 is not in stack");
        }

        Console.WriteLine();

        List<Employee> employes = new List<Employee>();

        employes.Add(employee1);
        employes.Add(employee2);
        employes.Add(employee3);
        employes.Add(employee4);
        employes.Add(employee5);

        if (employes.Contains(employee2))
        {
            Console.WriteLine("Employee2 object exists in the list");
        }
        else
        {
            Console.WriteLine("Employee2 object does not exists in the list");
        }

        Employee? FirstMale = employes.Find(e => e.Gender == "Male");
        Console.WriteLine($"{FirstMale.Id} - {FirstMale.Name} - {FirstMale.Gender} - {FirstMale.Salary}");

        Console.WriteLine();

        List<Employee> allMales = employes.FindAll(b => b.Gender == "Male");

        foreach (Employee emp in allMales)
        {
            Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
        }

    }
}
