using System;
using System.Collections.Generic;
using System.Linq;

namespace QLDanhSachStudent
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Age: {Age}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student { Id = 1, Name = "Tran Trung Tin", Age = 16 },
                new Student { Id = 2, Name = "Nguyen Huynh Truc Hien", Age = 15 },
                new Student { Id = 3, Name = "Luu Nguyen Ai Ngan", Age = 17 },
                new Student { Id = 4, Name = "Nguyen Tran Thien Y", Age = 18 }
            };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("danh sach toan bo hoc sinh:");
            foreach (var student in list)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var ageRangeStudents = list.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            Console.WriteLine("danh sach hoc sinh co tuoi tu 15 den 18:");
            foreach (var student in ageRangeStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            var nameStartsWithA = list.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("Danh sach hoc sinh bat dau bang chu 'A':");
            foreach (var student in nameStartsWithA)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            var totalAge = list.Sum(s => s.Age);
            Console.WriteLine($"Tong tuoi cua tat ca hoc sinh: {totalAge}");
            Console.WriteLine();

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var oldestStudent = list.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine("Hoc sinh co tuoi lon nhat:");
            Console.WriteLine(oldestStudent);
            Console.WriteLine();

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            var sortedByAge = list.OrderBy(s => s.Age).ToList();
            Console.WriteLine("danh sach hoc sinh sau khi sap xep tuoi tang dan:");
            foreach (var student in sortedByAge)
            {
                Console.WriteLine(student);
            }
        }
    }
}