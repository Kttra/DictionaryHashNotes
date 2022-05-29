using System;
using System.Collections;
//A Program showing the use of classes with hashtables


namespace HashTableEx
{
	public class Program
	{
		public static void Main()
		{
			//Key - Value
			//ID  - Student
			Hashtable studentsTable = new Hashtable();

			//Create 4 students using the student class
			Student stud1 = new Student(1, "Maria", 98);
			Student stud2 = new Student(2, "Jason", 76);
			Student stud3 = new Student(3, "Clara", 43);
			Student stud4 = new Student(4, "Steve", 55);

			//Add students to our hashtable
			studentsTable.Add(stud1.ID, stud1);
			studentsTable.Add(stud2.ID, stud2);
			studentsTable.Add(stud3.ID, stud3);
			studentsTable.Add(stud4.ID, stud4);

			//Retrieve all values from a hashtable
			foreach (DictionaryEntry entry in studentsTable)
            {
				Student temp = (Student)entry.Value;
				Console.WriteLine($"Student ID:{temp.ID}");
				Console.WriteLine($"Name: {temp.Name}");
				Console.WriteLine($"GPA: {temp.GPA}");
				Console.WriteLine();
			}

			//Access student value directly
			foreach (Student value in studentsTable.Values)
			{
				Console.WriteLine($"Student ID:{value.ID}");
				Console.WriteLine($"Name: {value.Name}");
				Console.WriteLine($"GPA: {value.GPA}");
				Console.WriteLine();
			}

			//Copying a student from the student hash table
			Student storedStudent = (Student)studentsTable[stud1.ID];

			Console.WriteLine($"Student ID:{storedStudent.ID}");
			Console.WriteLine($"Name: {storedStudent.Name}");
			Console.WriteLine($"GPA: {storedStudent.GPA}");
		}
	}
}

//Our student class
class Student
{
	public int ID { get; set; }
	public string Name { get; set; }
	public float GPA { get; set; }
	//Simple constructor
	public Student(int _ID, string _Name, float _GPA)
	{
		this.ID = _ID;
		this.Name = _Name;
		this.GPA = _GPA;
	}
}
