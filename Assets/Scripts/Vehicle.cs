public abstract class Vehicle
{
  public string Go();
}

public class Car : Vehicle
{
  public override string Go()
  {
    console.WriteLine("VroomVroom");
  }
}

public class Ship : Vehicle
{
  public override string Go()
  {
    console.WriteLine("DooDoo");
  }
}

public class Plane : Vehicle, IFly
{
  public override string Go()
  {
    console.WriteLine("Whoooooosh");
  }
  public string Fly()
  {
    console.WriteLine("Flyyyyyyyyyy");
  }
}

public interface IFly
{
  string Fly();
}