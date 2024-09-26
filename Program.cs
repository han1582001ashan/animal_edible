﻿using System;
namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
                if(animal is Chicken){
                Edible edible = (Chicken)animal;

                Console.WriteLine(edible.HowToEat());
                }
                if(animal is Tiger){
                Edible edible = (Tiger)animal;

                Console.WriteLine(edible.HowToEat());
                }
            }
            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();
            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }
        }
    }
}