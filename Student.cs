public class Student
{
    public string Name { get; private set; }
    public int Id { get; private set; }
    public double MidTerm { get; private set; }
    public double Final { get; private set; }

    public Student(string name, int id, double midTerm, double final)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty", nameof(name));
        if (id <= 0)
            throw new ArgumentException("Id should be bigger than 0", nameof(id));
        if (midTerm < 0 || midTerm > 100)
            throw new ArgumentException("The midterm grade must be between 0 and 100.", nameof(midTerm));
        if (final < 0 || final > 100)
            throw new ArgumentException("The final grade must be between 0 and 100.", nameof(final));

        Name = name;
        Id = id;
        MidTerm = midTerm;
        Final = final;
    }

    private double Calculate()
    {
        return (MidTerm * 0.4) + (Final * 0.6);
    }

    public void Print()
    {
        double ortalama = Calculate();
        Console.WriteLine($"Student information: {Name}, with ID number {Id}, has a GPA of {ortalama:F1}.");
    }
}
