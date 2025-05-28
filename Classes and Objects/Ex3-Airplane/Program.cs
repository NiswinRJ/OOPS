using System;

public class Airplane
{
    public string FlightNumber { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public TimeSpan Delay { get; set; }

    public Airplane(string flightNumber, string destination, DateTime departureTime)
    {
        FlightNumber = flightNumber;
        Destination = destination;
        DepartureTime = departureTime;
        Delay = TimeSpan.Zero;
    }

    public void CheckFlightStatus()
    {
        if (Delay == TimeSpan.Zero)
        {
            Console.WriteLine($"Flight {FlightNumber} to {Destination} is on time.");
        }
        else
        {
            Console.WriteLine($"Flight {FlightNumber} to {Destination} is delayed by {Delay.Hours} hours and {Delay.Minutes} minutes.");
        }
    }

    public void AddDelay(TimeSpan delay)
    {
        Delay += delay;
        DepartureTime += delay;
        Console.WriteLine($"Flight {FlightNumber} to {Destination} has been delayed by {delay.Hours} hours and {delay.Minutes} minutes.");
    }
}

public class Program
{
    public static void Main()
    {
        // Example: create an Airplane object
        Airplane airplane = new Airplane("AI123", "New York", DateTime.Parse("2025-02-10 15:00:00"));

        // Check flight status
        airplane.CheckFlightStatus();

        // Add delay to the flight
        airplane.AddDelay(TimeSpan.FromHours(2));

        // Check flight status again
        airplane.CheckFlightStatus();
    }
}
