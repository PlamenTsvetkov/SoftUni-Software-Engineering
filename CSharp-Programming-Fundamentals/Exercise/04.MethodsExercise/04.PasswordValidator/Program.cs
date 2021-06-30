using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;
            string password = Console.ReadLine();
            if (CharacterChek(password) < 6 || CharacterChek(password) > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            ;
            if (LetterAndDigitChek(password)==false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;

            }
            ;
            if (Diggit2Chek(password) < 2)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            ;
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static int Diggit2Chek(string password)
        {
            int diggitCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if ((int)password[i] > 48 && (int)password[i] < 57)
                {
                    diggitCount++;
                }
                
            }
            return diggitCount;
        }

        static bool LetterAndDigitChek(string password)
        {
            for (int i = 0; i < password.Length; i++) //48 57 65-90 97-122
            {
                if (!((password[i] >= 48 && password[i] <= 57)
                    ||(password[i] >=65 && password[i] <= 90 )
                    || (password[i] >=97 && password[i] <= 122)))
                {
                    
                    return false;

                }
            }
            return true;
        }

        static int CharacterChek(string password)
        {
            int characterCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                characterCount++;
            }
            return characterCount;
        }
    }
}
