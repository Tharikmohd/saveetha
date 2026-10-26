using System;

class Interfacess
{
    public static void Main()
    {
        University university = new University();
        university.Dept();
        university.Exam();
        university.lib();
        university.Studying();
        university.Teach();
        university.ConductResearch();
        university.Graduation();
    }
}

interface ITeaching
{
   public void Teach();
}

interface IStd
{
    void Studying();
}

interface IResearch
{
    void ConductResearch();
}

interface IExam
{
    void Exam();
}

interface IDept
{
    void Dept();
}

interface ILibrary
{
    void lib();
}

class University : ITeaching, IStd, IResearch, ILibrary,IExam, IDept
{
    public void Teach()
    {
        Console.WriteLine("Staff's are completed their syllabus");
    }

    public void Studying()
    {
        Console.WriteLine("Students are Ready for examination");
    }

    public void ConductResearch()
    {
        Console.WriteLine("Final Year Students are participating Research Program");
    }

    public void lib()
    {
        Console.WriteLine("Librarian release the non returned book details");
    }

    public void Exam()
    {
        Console.WriteLine("Exam will start at Dec 5");
    }

    public void Dept()
    {
        Console.WriteLine("All Departments HOD are instruct to their dept staff to conduct Model practical");
    }

    public void Graduation()
    {
        Console.WriteLine("Graduation day will be announced soon..");
    }
}