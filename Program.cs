using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP
{
    internal class Program
    {

        //public class StudentMain
        //{
        //    public static void Main()
        //    {
        //        Student student = new Student("John", 17, "London");


        //        //Console.WriteLine(student.Name);
        //        //Console.WriteLine(student.Age);
        //        //Console.WriteLine(student.GetCity());
        //        student.ShowInfo();
        //    }
        //}




        public static void Main()
        {
            List<Message> list = new List<Message>();
            Random r = new Random();
            int MCount = r.Next(1, 10);

            for (int i = 0; i < MCount; i++)
            {
                Console.WriteLine("Sõnumi sisu: ");
                string c = Console.ReadLine();
                Console.WriteLine("Sõnumi autor: ");
                string a = Console.ReadLine();
                int t = -1 * r.Next(0, 1000000000);
                DateTime dhm = DateTime.Now.Date.AddSeconds(t);

                // Create a new Message object with the provided parameters
                Message m = new Message(c, a, dhm);

                for (int j = 0; j < r.Next(1, 1000); j++)
                {
                    m.AddLike();
                }
                list.Add(m);
            }

            string mostPopularMessage = Message.ShowPopularityN(list);
            Console.WriteLine(mostPopularMessage);
        }
    }
    }
}