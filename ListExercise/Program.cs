namespace ListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "John", 5000);
            Employee emp2 = new Employee(102, "Anne", 7000);
            Employee emp3 = new Employee(103, "Mark", 3000);

            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);

            empList.Insert(1, emp3);
            empList.Remove(emp3);
            //empList.Clear();

            foreach (var e in empList)
                Console.WriteLine(e);


            // Searching

            // IndexOf

            int index = empList.IndexOf(emp2);

            if (index >= 0)
                Console.WriteLine("Item exists at index " + index);
            else
                Console.WriteLine("Item doesn't exist");


            // Contains

            if (empList.Contains(emp2))
                Console.WriteLine("Item exists");
            else
                Console.WriteLine("Item doesn't exist");


            // Exists

            if (empList.Exists(e => e.Name.StartsWith("A")))
                Console.WriteLine("Item exists");
            else
                Console.WriteLine("Item doesn't exist");


            // Find

            Employee? emp = empList.Find(e => e.Salary > 6000);

            if (emp != null)
                Console.WriteLine(emp);
            else
                Console.WriteLine("Item not found");
        }
    }
}
