using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle
{
  public abstract void Go();
}

public class Car : Vehicle
{
  public override void Go()
  {
    Debug.Log("VroomVroom");
  }
}

public class Ship : Vehicle
{
  public override void Go()
  {
    Debug.Log("DooDoo");
  }
}

public class Plane : Vehicle, IFly
{
  public override void Go()
  {
    Debug.Log("Whoooooosh");
  }
  public void Fly()
  {
    Debug.Log("Flyyyyyyyyyy");
  }
}

public interface IFly
{
  void Fly();
}