using System;
using System.Collections.Generic;

namespace SmartHiringSystem
{
    // Abstract base role
    public abstract class RoleProfile
    {
        public string Name { get; private set; }
        public int YearsOfExperience { get; private set; }

        protected RoleProfile(string name, int experience)
        {
            Name = name;
            YearsOfExperience = experience;
        }

        public abstract void Evaluate();
    }

    // Software Engineer role
    public class DeveloperProfile : RoleProfile
    {
        public DeveloperProfile(string name, int experience)
            : base(name, experience) { }

        public override void Evaluate()
        {
            Console.WriteLine(
                $"Candidate: {Name} | Role: Software Engineer | Experience: {YearsOfExperience} yrs | Skills: C#, DSA, OOP"
            );
        }
    }

    // Data Scientist role
    public class AnalystProfile : RoleProfile
    {
        public AnalystProfile(string name, int experience)
            : base(name, experience) { }

        public override void Evaluate()
        {
            Console.WriteLine(
                $"Candidate: {Name} | Role: Data Scientist | Experience: {YearsOfExperience} yrs | Skills: Python, ML, SQL"
            );
        }
    }

    // Generic resume collection
    public class ResumeCollection<T> where T : RoleProfile
    {
        private readonly List<T> profiles = new List<T>();

        public void AddProfile(T profile)
        {
            profiles.Add(profile);
        }

        public void RunScreening()
        {
            Console.WriteLine("\n--- Screening In Progress ---");

            foreach (var profile in profiles)
            {
                profile.Evaluate();
            }
        }

        public List<T> GetAll()
        {
            return profiles;
        }
    }

    // Static processing utility
    public static class ScreeningEngine
    {
        public static void Start<T>(IEnumerable<T> profiles)
            where T : RoleProfile
        {
            Console.WriteLine("\n=== Automated Screening Engine ===");

            foreach (var profile in profiles)
            {
                profile.Evaluate();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var devResumes = new ResumeCollection<DeveloperProfile>();
            devResumes.AddProfile(new DeveloperProfile("Alice", 4));
            devResumes.AddProfile(new DeveloperProfile("Bob", 2));

            var dataResumes = new ResumeCollection<AnalystProfile>();
            dataResumes.AddProfile(new AnalystProfile("Charlie", 3));
            dataResumes.AddProfile(new AnalystProfile("Diana", 5));

            devResumes.RunScreening();
            dataResumes.RunScreening();

            ScreeningEngine.Start(
                new List<DeveloperProfile>
                {
                    new DeveloperProfile("Ethan", 6),
                    new DeveloperProfile("Fiona", 1)
                }
            );
        }
    }
}
