using System;

namespace DogThing
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Molly";
            int dogAge = 5;
            char firstInitial = 'M';
            bool genderFemale = true;
            double pawPads = 16;
            decimal weight = 73.6m;

            //string interpolation with the $

            Console.WriteLine($"My dog's name is {dogName} \nShe is {dogAge} and her name, obviously, starts with {firstInitial}. \n" +
                $"As her name suggests, it is {genderFemale} that she is a lady \nShe has {pawPads} toes and weighs {weight}");


        }
    }
}
