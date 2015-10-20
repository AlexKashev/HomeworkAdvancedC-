﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Print all students from group number 2. Use a LINQ query. Order the students by FirstName.*/

namespace z02.Students_by_Group
{
    class StudentsbyGroup
    {
        static void Main()
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

            var groupTwoStudents =
                from st in student
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            foreach (var st in groupTwoStudents)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
        }


    }
}