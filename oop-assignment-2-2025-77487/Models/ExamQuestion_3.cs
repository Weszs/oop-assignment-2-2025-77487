using System;
using System.Collections.Generic;
using System.Text;

namespace oop_assignment_2_2025_000000.Models
{
    public static class ExamQuestion_3
{
    public static void Run()
    {
        Console.WriteLine("Exam Question 3 executed.");
        ProductRatings();
    }

    public static void ProductRatings()
    {
        
    }

    public static (string Summary, string BestProductInfo) ProcessRatings(
        List<(string ProductName, List<int> Scores)> items)
    {
        string bestProduct = "";
        double bestAverage = -1;
        List<string> summaries = new List<string>();

        foreach (var item in items)
        {
            if (item.Scores == null || item.Scores.Count == 0)
            {
                summaries.Add($"{item.ProductName}: No ratings available");
                continue;
            }

            double avgScore = item.Scores.Sum() / (double)item.Scores.Count;
            avgScore = Math.Round(avgScore, 1);

            summaries.Add($"{item.ProductName}: Average Rating = {avgScore}");

            if (avgScore > bestAverage)
            {
                bestAverage = avgScore;
                bestProduct = item.ProductName;
            }
        }

        string bestProductMessage =
            bestAverage >= 0
                ? $"The top-rated product is {bestProduct} with an average rating of {bestAverage}"
                : "No products were rated.";

        return (string.Join(Environment.NewLine, summaries), bestProductMessage);
    }
}

}