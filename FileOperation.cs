public static class FileOperations
{
    public static List<Student> ReadStudents(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("Student file not found.", filePath);

        string[] lines = File.ReadAllLines(filePath);
        var students = new List<Student>();

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 4)
                throw new FormatException("File format error: " + line);

            try
            {
                string name = parts[0];
                int id = int.Parse(parts[1]);
                double midterm = double.Parse(parts[2]);
                double final = double.Parse(parts[3]);

                Student student = new Student(name, id, midterm, final);
                students.Add(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: Data on line {line} could not be processed. {ex.Message}");
            }
        }

        return students;
    }
}