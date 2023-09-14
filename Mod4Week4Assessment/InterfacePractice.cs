﻿using System;
using System.Collections.Generic;

// Define the interface
public interface IVehicle 
{
    public string Manufacturer { get; set; }
    void Start();
    void Accelerate();
    void Brake();
    void Stop();
}

// Implement the interface in different vehicle classes
public class Car : IVehicle
{
    public string Manufacturer { get; set; }
    public int Year { get; private set; }

    public Car(string manufacturer, int year)
    {
        Manufacturer = manufacturer;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine("Car: Starting the engine...");
    }

    public void Accelerate()
    {
        Console.WriteLine("Car: Accelerating...");
    }

    public void Brake()
    {
        Console.WriteLine("Car: Applying brakes...");
    }

    public void Stop()
    {
        Console.WriteLine("Car: Stopping the engine.");
    }
}

public class Bicycle : IVehicle
{
    public string Manufacturer { get; set; }
    public bool HasBasket { get; private set; }

    public Bicycle(string manufacturer, bool hasBasket)
    {
        Manufacturer = manufacturer;
        HasBasket = hasBasket;
    }

    public void Start()
    {
        Console.WriteLine("Bicycle: Pedaling...");
    }

    public void Accelerate()
    {
        Console.WriteLine("Bicycle: Pedaling faster...");
    }

    public void Brake()
    {
        Console.WriteLine("Bicycle: Applying brakes...");
    }

    public void Stop()
    {
        Console.WriteLine("Bicycle: Coming to a stop.");
    }
}
