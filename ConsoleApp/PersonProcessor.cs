using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class PersonProcessor
    {
        public static string GetTotalGoodPersonPoints(List<Person> people)
        {
            var totalPeoplePoints = people.Select(x => x.GoodPersonPoints).Sum();
            return totalPeoplePoints.ToString();
        }

        public static List<Person> PeopleBuilder()
        {
            Random random = new Random();
            var people = new List<Person>();
            var numberOfPeople = 100;

            for (int i = 0; i < numberOfPeople; i++)
            {
                if (i % 10 == 0) 
                {
                    people.Add(new Person
                    {
                        FullName = $"john smith{i}",
                        GoodPersonPoints = 514748005
                    });
                }

                people.Add(new Person
                {
                    FullName = $"john smith{i}",
                    GoodPersonPoints = random.Next(1, 100)
                });
            }

            return people;
        }
    }
}
