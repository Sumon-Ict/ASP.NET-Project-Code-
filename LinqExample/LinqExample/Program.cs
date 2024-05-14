using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Program
    {
         
        static void Main(string[] args)
        {

           

            IEnumerable<Student> studentdata =from s in students where s.Scores[0] >90&& s.Scores[3]<80
                            select s;

            foreach(var student in studentdata)
            {
                Console.WriteLine($"{student.First} , {student.Last},{student.ID}, {student.Scores[2]}");
            }
            foreach(var data3 in studentdata)
            {
                Console.WriteLine(data3.First);

            }









           
           var std = from s in students where s.ID > 120 select s;
            foreach(var data1 in  std)
            {
                Console.WriteLine($"last name={data1.Last}");
            }
                 

            var data = from s in students
                       orderby s.ID ascending
                       group s by s.Last[1];  // group by student last string
                                                                 // second charcter

            foreach(var stg in data)
            {
                Console.WriteLine("group key "+stg.Key);

                foreach(var s in stg)
                {
                    Console.WriteLine($"{s.ID}, {s.First}");

                }

            }

         

            //     group and orderby same time 

            var studentQuery4 =
           from student in students
           group student by student.Last[0] into studentGroup
           orderby studentGroup.Key
           select studentGroup;
            foreach (var groupOfStudents in studentQuery4)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine(" {0}, {1}",
                    student.Last, student.First);
                }
            }

            var sq4 =
                from st4 in students
                group st4 by st4.First[0] into stgroup
                orderby stgroup.Key
                select stgroup;
            foreach (var x in sq4)
            {
                Console.WriteLine(x.Key);

                foreach (var y in x)
                {
                    Console.WriteLine("{0}, {1}", y.First, y.Last);

                }
            }

            

             foreach (Student sd in data)
             {
                 Console.WriteLine("{0}, {1}, {2}, {3}", sd.First, sd.Last, sd.ID, sd.Scores[3]);

             }
            // #endregion


       
            var studentquery5 =
                from st5 in students
                let totalscore = st5.Scores[0] + st5.Scores[1] + st5.Scores[2] + st5.Scores[3]
                where totalscore / 4 < st5.Scores[3]
               select st5;




            foreach (var name in studentquery5)
            {
                Console.WriteLine(name.First);

            }

 
            //to transorm of select project on clause

            IEnumerable<string> studentquery6 =
                from st6 in students
                where st6.Last == "Garcia"
                select st6.First + "   " + st6.ID;

            Console.WriteLine("student name whom last name is garcia");


            foreach (var nameandId in studentquery6)
            {
                Console.WriteLine(nameandId);

            }



           var studentquery7 =
                from st7 in students
                let totalscsore = st7.Scores[0] + st7.Scores[1] + st7.Scores[2] + st7.Scores[3]
                select totalscsore;

            foreach(var v in  studentquery7)
            {
                Console.WriteLine(v);
            }

            double average = studentquery7.Average();
            Console.WriteLine(average);



            var studentquery8 =
                from st8 in students
                let x = st8.Scores[0] + st8.Scores[1] + st8.Scores[2] + st8.Scores[3]

                where x > average
                select st8;
               

            foreach(var data4 in studentquery8)
            {
                Console.WriteLine($"std id {data4.ID}, score={data4.Scores[3]}");
            }

          
             
           
            var sentence = "my name is sumon and I am student of islamic university dept of information and communication technology";

            string[] words = sentence.Split(' ');

            var query = from word in words

                        group word.ToUpper() by word.Length into gr
                        orderby gr.Key
                        select new { Length = gr.Key, Words = gr };




            foreach (var obj in query)
            {
                Console.WriteLine("Words of length {0}:", obj.Length);

                foreach (string word in obj.Words)

                    Console.WriteLine(word);
            }



    }

    static List<Student> students = new List<Student>{
            
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81,60 }},

              new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
              new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
              new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
              new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
              new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
              new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
              new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
              new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
              new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
              new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
              new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}


        };





    }
}
