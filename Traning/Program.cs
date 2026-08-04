<<<<<<< HEAD
﻿using Traning;

//Constructor C =new Constructor(8, 12);
Constructor C2 =new Constructor("ka haal ba ho");
Constructor C3 = new Constructor(C2);
Constructor C4 = new Constructor(C3);


=======
﻿    class Training
{
    static void Main(string[] args)
    {

        ReverseString obg = new ReverseString();
        //obg.StringReverse();
        //obg.palindrome();
        obg.Findvowel();
    }
    class ReverseString:Training
    {
        public void StringReverse()
        {
            string str = "Hello World";
            int length = str.Length;
            Console.WriteLine(str);
            Console.WriteLine(length);
            for(int i=length-1;i>=0;i-- )
            {
                Console.Write(str[i]);
            }

        }
        public void palindrome()
        {
            string str = "madam";
            int left = 0;
            int right = str.Length - 1;
            while (left<right)
            {
                if (str[left] != str[right])
                {
                    Console.WriteLine("The string is not palindrome");
                }
                left++;
                right--;

            }
            Console.WriteLine("The string is  palindrome");

        }
        public void Findvowel()
        {
            string vowels = "aeiouAEIOU";
            string consonant = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            string str = Console.ReadLine() ?? "";
            int vowelCount = 0;
            int consonantCount = 0;
            for (int i = str.Length-1;i>=0;i--) //abce
            {
                for(int j = vowels.Length - 1; j >= 0; j--)
                {
                    if (str[i] == vowels[j])
                    {
                        vowelCount++;
                    }
                }
                for (int k = consonant.Length - 1; k >= 0; k--)
                {
                    if (str[i] == consonant[k])
                    {
                        consonantCount++;
                    }
                }
            }
            Console.WriteLine("The number of vowels in the string is: " + vowelCount);
            Console.WriteLine("The number of consonants in the string is: " + consonantCount);
        }
    }


}
>>>>>>> b3967bcf0a486cb0eea5c0c6feb9d20d494effbb
