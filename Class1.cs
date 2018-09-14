using System;

namespace Dog_Challenge
{
    public class Dog
    {
        public enum Gender
        {
            Male,Female,
        }

        public string name;
        public string owner;
        public int age;
        public Gender gender;

        public Dog(string n, string o, int a, Gender g)
        {
            name = n;
            owner = o;
            age = a;
            gender = g;
        }

        public void bark(int num)
        {
            for (int i = 0; i < num;i++)
            {
                Console.Write("Woof!");
            }
            Console.WriteLine();
        }

        public static string checkGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "His";
            }
            else
            {
                return "Hers";
            }
        }

        public string getTag()
        {
            string check = checkGender(gender).ToString();

            if(check=="His")
            {
                check = "he";
            }
            else
            {
                check = "she";
            }

            return "If lost, call " + owner + "." + check + "name is" + name + "and" + check + "is" + age + "old.";

        }

    }

}
