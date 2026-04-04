using System;

namespace SmartMealPlanner
{
    // Meal contract
    public interface IMeal
    {
        string Title { get; }
        int Energy { get; }
        void ShowDetails();
    }

    // Vegetarian implementation
    public class VegMeal : IMeal
    {
        public string Title => "Vegetarian Diet";
        public int Energy => 600;

        public void ShowDetails()
        {
            Console.WriteLine("Includes: Rice, Dal, Seasonal Vegetables");
        }
    }

    // Protein-rich implementation
    public class ProteinMeal : IMeal
    {
        public string Title => "Protein Rich Diet";
        public int Energy => 800;

        public void ShowDetails()
        {
            Console.WriteLine("Includes: Fish, Brown Rice, Beans");
        }
    }

    // Generic meal creator
    public class MealBuilder<T> where T : IMeal, new()
    {
        public T Build()
        {
            return new T();
        }
    }

    // Utility class for output
    public static class MealPlanService
    {
        public static void PrintMeal<T>() where T : IMeal, new()
        {
            T meal = new T();

            Console.WriteLine("\n--- Generated Meal Plan ---");
            Console.WriteLine($"Meal Name : {meal.Title}");
            Console.WriteLine($"Calories  : {meal.Energy}");
            meal.ShowDetails();
        }
    }

    class Program
    {
        static void Main()
        {
            var vegBuilder = new MealBuilder<VegMeal>();
            var proteinBuilder = new MealBuilder<ProteinMeal>();

            MealPlanService.PrintMeal<VegMeal>();
            MealPlanService.PrintMeal<ProteinMeal>();
        }
    }
}
