using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputUser = UserMass();
            //foreach(var item in inputUser)
            //{
            //    Console.WriteLine(item + " ");
            //}

            int[] arr = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            
            Console.WriteLine(Check(arr, inputUser));
            Console.ReadLine();
        }

        public static int[] UserMass()
        {
            int[] user = new int[3];
            Console.WriteLine("Input string number");
            string temp = Console.ReadLine();
            string[] mass = temp.Split(' ');
            for(int i = 0; i <user.Length; i++)
            {
                user[i] = int.Parse(mass[i]);
            }
            return user;
        }
        public static int Check(int[] arr, int[] inputUser)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < inputUser.Length; j++)
                {
                    if (arr[i] == inputUser[j])
                    {
                        count++;
                        break;
                    }
                    break;
                }
            }
            return count;
        }
    }
}
