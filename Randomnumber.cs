using System;
using System.Security.Cryptography;

class Randomnumber
{
    public static void Main()
    {
        Random random = new Random();

        /*string  value = "qwertyuioplkjhgfdsazxcvbnm0987654321";

        char []otp = new char [6];

        int ind;

        for(int i =0; i<6; i++)
        {
            ind = RandomNumberGenerator.GetInt32(otp.Length);

            otp[i] = value[ind]; 
        }

        Console.WriteLine(otp);*/

        int otp = random.Next(10000,100000);

        Console.WriteLine(otp);

        

    }
    
}