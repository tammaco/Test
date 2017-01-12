using System;
using System.Collections.Generic;
using System.Linq;

namespace Routing
{
    public class Program
    {
        static List<Card> cards;
        static void Main(string[] args)
        {
            cards = new List<Card>();
            FillCards();
            Console.WriteLine("Original card list: ");
            Console.WriteLine(String.Join(", ", cards.Select(c => c.ToString()).ToArray()));

            Console.WriteLine();
            Console.WriteLine("Press ENTER to order cards.");
            Console.ReadLine();

            OrderCards();
            Console.WriteLine("Cards sorted, result card list: ");
            Console.WriteLine(String.Join(", ", cards.Select(c => c.ToString()).ToArray()));

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }

        public static void FillCards()
        {
            if (cards == null)
                cards = new List<Card>();

            cards.Add(new Card("Париж", "Пекин"));
            cards.Add(new Card("Мельбурн", "Кельн"));
            cards.Add(new Card("Лондон", "Нью-Йорк"));
            cards.Add(new Card("Москва", "Париж"));
            cards.Add(new Card("Пекин", "Копенгаген"));
            cards.Add(new Card("Иерусалим", "София"));
            cards.Add(new Card("Копенгаген", "Иерусалим"));
            cards.Add(new Card("София", "Лондон"));
            cards.Add(new Card("Кельн", "Москва"));
            cards.Add(new Card("Нью-Йорк", "Мадрид"));
        }

        public static void TestProgram(List<Card> testCards)
        {
            cards = testCards;
            Console.WriteLine("Original card list: ");
            Console.WriteLine(String.Join(", ", cards.Select(c => c.ToString()).ToArray()));
            OrderCards();
            Console.WriteLine("Cards sorted, result card list: ");
            Console.WriteLine(String.Join(", ", cards.Select(c => c.ToString()).ToArray()));
        }

        public static void OrderCards()
        {
            List<Card> orderedCards = null;

            if (cards != null && cards.Count > 1)
            {
                List<string> departures = cards.Select(d => d.Departure).ToList();
                List<string> destinations = cards.Select(d => d.Destination).ToList();
                string start = departures.FirstOrDefault(c => !destinations.Contains(c));

                if (!string.IsNullOrEmpty(start))
                {
                    orderedCards = new List<Card>();

                    while (start != null)
                    {
                        if (cards.Any(c => c.Departure == start))
                        {
                            Card currentRoute = cards.First(c => c.Departure == start);
                            orderedCards.Add(currentRoute);
                            start = currentRoute.Destination;
                        }
                        else
                            start = null;
                    }

                }
            }

            if (orderedCards != null && orderedCards.Count > 0)
                cards = orderedCards;
        }
    }
}
