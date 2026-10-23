using System;

class Multipleinherit
{
    public static void Main()
    {
        Chairman chairman = new Chairman();

        chairman.Teaching();
        chairman.Listening();
        chairman.Managing();
        chairman.Coordinate();
        chairman.Overall();
        chairman.Collection();
        chairman.Meeting();
        
    }
}

interface IStudent
{
    public void Listening();
}
interface IStaff
{
    public void Teaching();
}

interface IHod
{
    public void Managing();
}
interface IDean
{
    public void Coordinate();
}

interface IPrincipal
{
    public void Overall();
}

interface IFinance
{
    public void Collection();
}

class Chairman : IStudent, IStaff, IHod, IDean, IPrincipal, IFinance
{
    public void Listening()
    {
        Console.WriteLine("Students are ready to examination...");
    }

    public void Teaching()
    {
        Console.WriteLine("Staff's are completed the portion");
    }

    public void Managing()
    {
        Console.WriteLine("Hod allocate the staff's to exam duty");
    }

    public void Coordinate()
    {
        Console.WriteLine("Dean verified the question papers and place arranagements");
    }

    public void Overall()
    {
        Console.WriteLine("Pricipal confirm the timetable and exam date");
    }

    public void Collection()
    {
        Console.WriteLine("Finance team collected the exam fee from students");
    }

    public void Meeting()
    {
        Console.WriteLine("Chairman conduct the meeting with Dean, Principal and HOD for get the information about exam preparation and expected results");
    }
}