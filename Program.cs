using System;

namespace ConsoleApp1_Git_1
{
    class Program
    {
        static void Main(string[] args)
        {
          Random rand = new Random();
            var ch = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string s = "mqkamgk eee PASSWORD  lmgll";
            string[] mas = s.Split(' ');
            int len = mas.Length;
            for(int i=0;i<len;i++)
            {

                if(mas[i]== "PASSWORD")
                {
                    var f = ch[rand.Next(ch.Length)].ToString();
                    mas[i] = f;
                    Console.WriteLine(mas[i]);
                }


            }
            foreach(var n in mas)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine("Htllo Git!");
        }
        
    }
}
