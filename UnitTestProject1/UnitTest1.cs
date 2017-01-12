using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Routing.Card> testCards = new List<Routing.Card>();
            testCards.Add(new Routing.Card("Мельбурн", "Кельн"));
            testCards.Add(new Routing.Card("Москва", "Париж"));
            testCards.Add(new Routing.Card("Кельн", "Москва"));

            Routing.Program.TestProgram(testCards);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<Routing.Card> testCards = new List<Routing.Card>();
            testCards.Add(new Routing.Card("Париж", "Пекин"));
            testCards.Add(new Routing.Card("Мельбурн", "Кельн"));
            testCards.Add(new Routing.Card("Лондон", "Нью-Йорк"));
            testCards.Add(new Routing.Card("Москва", "Париж"));
            testCards.Add(new Routing.Card("Пекин", "Копенгаген"));
            testCards.Add(new Routing.Card("Иерусалим", "София"));
            testCards.Add(new Routing.Card("Копенгаген", "Иерусалим"));
            testCards.Add(new Routing.Card("София", "Лондон"));
            testCards.Add(new Routing.Card("Кельн", "Москва"));
            testCards.Add(new Routing.Card("Нью-Йорк", "Мадрид"));

            Routing.Program.TestProgram(testCards);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<Routing.Card> testCards = new List<Routing.Card>();
            testCards.Add(new Routing.Card("Нью-Дели", "Абу-Даби"));
            testCards.Add(new Routing.Card("Мельбурн", "Кельн"));
            testCards.Add(new Routing.Card("Пекин", "Копенгаген"));
            testCards.Add(new Routing.Card("Копенгаген", "Иерусалим"));
            testCards.Add(new Routing.Card("Минск", "Тбилиси"));
            testCards.Add(new Routing.Card("Париж", "Пекин"));
            testCards.Add(new Routing.Card("Лондон", "Нью-Йорк"));
            testCards.Add(new Routing.Card("Иерусалим", "София"));
            testCards.Add(new Routing.Card("Нью-Йорк", "Мадрид"));
            testCards.Add(new Routing.Card("Москва", "Париж"));
            testCards.Add(new Routing.Card("София", "Лондон"));
            testCards.Add(new Routing.Card("Кельн", "Москва"));
            testCards.Add(new Routing.Card("Тбилиси", "Нью-Дели"));
            testCards.Add(new Routing.Card("Мадрид", "Минск"));
            testCards.Add(new Routing.Card("Абу-Даби", "Бангкок"));

            Routing.Program.TestProgram(testCards);
        }
    }
}
