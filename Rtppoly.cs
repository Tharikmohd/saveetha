using System;

class Rtppoly
{
    public static void Main()
    {
        Vinoth v = new Admission();
        v.Action();
       

        
    }
}

class Vinoth
{
    public virtual void Action()
    {
        Console.WriteLine("Vinoth Train the students in Robotics");
    }
}

class Dept : Vinoth
{
    public override void Action()
    {
        base.Action();
        Console.WriteLine("Vinoth will handle Automation Principle subject for final year MCT students ");
    }
}

class Placement : Dept
{
    public override void Action()
    {
        base.Action();
        Console.WriteLine("Vinoth will handle Placement work and coordinate with final yr students");
    }
}

class Admission : Placement
{
    public sealed override void Action()
    {
        base.Action();
        Console.WriteLine("Vinoth will handle Admission duty");
    }
}