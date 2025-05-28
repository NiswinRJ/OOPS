using System;
using System.Collections.Generic;

// Step 1: Define the Movie class
public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public List<string> Actors { get; set; }
    public List<string> Reviews { get; set; }

    // Constructor to initialize the attributes
    public Movie(string title, string director, List<string> actors)
    {
        Title = title;
        Director = director;
        Actors = actors;
        Reviews = new List<string>();
    }

    // Method to add a review
    public void AddReview(string review)
    {
        Reviews.Add(review);
        Console.WriteLine($"Added review: {review}");
    }

    // Method to retrieve all reviews
    public void GetReviews()
    {
        Console.WriteLine($"Reviews for {Title}:");
        foreach (string review in Reviews)
        {
            Console.WriteLine($"- {review}");
        }
    }
}

// Main method to test the Movie class
class Program
{
    static void Main()
    {
        List<string> actors = new List<string> { "Actor 1", "Actor 2", "Actor 3" };
        Movie movie = new Movie("Sample Movie", "Sample Director", actors);

        movie.AddReview("Great movie!");
        movie.AddReview("Loved the acting.");
        movie.AddReview("Could have been better.");

        movie.GetReviews();
    }
}
