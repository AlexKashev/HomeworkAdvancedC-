﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class FilterStudent
    {
        static void Main(string[] args)
        {
            var student = new List<Student>
        {
            new Student("Alex", "Kirov",18,1,"021234","",new List<int> {5, 3, 5, 6},1),
			new Student("Mendi", "Shanadjiqta",18,2,"3592321638","peshev@abv.bg",new List<int> {5, 2, 5, 6},1),
			new Student("Gosho", "Pochivka",19,3,"07113","aaa@abv.bg",new List<int> {5, 2, 5, 6},2),
			new Student("Goshko", "Goskov",19,4,"083545","goshov@gmail.com",new List<int> {5, 2, 5, 5},2),
			new Student("Pesho", "Peshov",20,5,"+359 2","niazzma@ght.gh",new List<int> {6, 2, 6, 4},1),
			new Student("Mudi", "Munev",21,6,"112345","pabbkmail@abv.bg",new List<int> {4, 2, 6, 3},2),
			new Student("Ivan", "Petkov",36,7,"524354","aaa@hotmail.com",new List<int> {6, 2, 6, 6},3),
        };

            var studentsByEmails =
                from st in student
                where st.Email.Contains("@abv.bg")
                select st;

            foreach (var st in studentsByEmails)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + "-->" + st.Email);
            }
        }
        
    }

