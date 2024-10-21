class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the path of the student file: ");
        string filePath = Console.ReadLine();
        try
        {
            List<Student> students = FileOperations.ReadStudents(filePath);

            foreach (var student in students)
            {
                student.Print();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ex: {ex.Message}");
        }
    }
}
