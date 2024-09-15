namespace MyZodiacApp.Models
{
    public class Utils
    {
        public static string GetZodiac(int year)
        {
            string[] zodiac = new string[12]
            {
                "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", 
                "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"
            };

            int remainder = year % 12;
            return zodiac[remainder];
        }
    }
}
