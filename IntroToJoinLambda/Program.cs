////using System;


////namespace InheritanceOOP
////{
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            Student s1 = new Student("Joe", "CS", 4.0,Student.Gender.Male.ToString());

////            StudentMPhysics smp = new StudentMPhysics("John", "MathsPhysics", 5.0, 65.3, 66.6, 78.8);

////            smp.Intro();


////        }

////        class Student //base class
////        {
////            public string name;
////            public string profile;
////            public double GPA;
////            public enum Gender { Male, Female }
////            public string gender { get; set; }


////            public Student(string name, string profile, double GPA, string Gender)
////            {
////                this.name = name;
////                this.profile = profile;
////                this.GPA = GPA;
////                this.gender = Gender;
////            }

////            public virtual void Intro()
////            {
////                Console.WriteLine($"Hello my name is {name}, I am a student from {profile} profile and my  GPA is: {GPA}");
////            }
////        }







////            class StudentMPhysics : Student //derived class
////        { 

////                public double MathGrade;
////                public double PhysicsGrade;
////                public double InformaticsGrade;

////            public StudentMPhysics(string name, string profile, double GPA, double MathGrade, double PhysicsGrade, double InformaticsGrade) : base(name,profile, GPA)
////            {
////                this.MathGrade = MathGrade;
////                this.PhysicsGrade = PhysicsGrade;
////                this.InformaticsGrade = InformaticsGrade;

////                 base.Intro();
////            }


////            public override void Intro()  //here we OVERRIDE the method from the base class , so we can use it with the additional variables from the derived class 
////            {
////                Console.WriteLine($"Hello my name is {name}, I am a student from {profile} profile and my  GPA is: {GPA} and my math grade is {MathGrade} , my Informatics grade is{InformaticsGrade} and my Physics grade is {PhysicsGrade} ");
////            }


////        }
////        }

////}


////Inner Join through Lambda

//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Program
//{
//    public static void Main()
//    {
//        // Student collection
//        List<Student> studentList = new List<Student>() {
//                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
//                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
//                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
//                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21, StandardID = 3 }
//            };

//        List<Standard> standardList = new List<Standard>() {
//                new Standard(){ StandardID = 1, StandardName="Pass"},
//                new Standard(){ StandardID = 2, StandardName="Fail"},
//                new Standard(){ StandardID = 3, StandardName="Satisfactory"}
//            };





//        //lambda 

//        // => 

//        var innerJoinLambda = studentList.Join(//outer sequence
//            standardList, //inner sequence
//            s => s.StandardID, //outer key selector 
//            st => st.StandardID, //inner key selector 
//            (s, st) =>
//            new //result selector 
//            {
//                StudentName = s.StudentName,
//                StandardName = st.StandardName
//            });

//        foreach (var item in innerJoinLambda)
//        {
//            Console.WriteLine($"{item.StudentName}, {item.StandardName}");
//        }




//        //query 

//        var innerJoin = from s in studentList //outer sequence 
//                        join st in standardList //inner sequence
//                        on s.StandardID equals st.StandardID //key selector 
//                        select new
//                        {
//                            StudentName = s.StudentName,
//                            StandardName = st.StandardName
//                        };

//        foreach (var item in innerJoin)
//        {
//            Console.WriteLine($"{item.StudentName}, {item.StandardName}");
//        }








//    }
//    public class Student
//    {

//        public int StudentID {  get; set; }
//        public string StudentName { get; set; }
//        public int Age { get; set; }
//        public int StandardID { get; set; }
//    }

//    public class Standard
//    {

//        public int StandardID { get; set; }
//        public string StandardName { get; set; }
//    }



//}


//using CsvHelper;
//using System.Globalization;
//using System.Linq;
//using System.Collections.Concurrent;
//using System.IO;
//using System.Formats.Asn1;
//using System;

//using (var readerTwo = new StreamReader(@"C:\Users\m.yovchevski\Downloads\department_data - department_data.csv"))
//using (var reader = new StreamReader(@"C:\Users\m.yovchevski\Downloads\Employee_Data - Employee_Data.csv"))




//using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
//using (var csvTwo = new CsvReader(readerTwo, CultureInfo.InvariantCulture))
//{
//    var records = csv.GetRecords<Employee_Data>();

//    var recordsTwo = csvTwo.GetRecords<department_data>();

//    var innerJoin = from s in records
//                    join st in recordsTwo
//                    on s.department_id equals st.department_id
//                    select new
//                    {
//                        employee_name = s.employee_name,
//                        department_name = st.department_name,
//                    };


//    foreach (var item in innerJoin)
//    {
//        Console.WriteLine($"{item.employee_name} - {item.department_name}");
//    }

//}




//class Employee_Data
//{
//    public int employeeid;
//    public string employee_name;
//    public int age;
//    public int department_id;

//    public Employee_Data(int employeeid, string employee_name, int age, int department_id)
//    {
//        this.employeeid = employeeid;
//        this.employee_name = employee_name;
//        this.age = age;
//        this.department_id = department_id;

//    }

//}

//class department_data
//{
//    public int department_id;
//    public string department_name;

//    public department_data(int department_id, string department_name)
//    {
//        this.department_id = department_id;
//        this.department_name = department_name;
//    }
//}


using CsvHelper;
using System.Globalization;
using System.Linq;
using System.Collections.Concurrent;
using System.IO;
using System.Formats.Asn1;
using System;
namespace InheritanceOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Input a number:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Input a second number:");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine(a / b);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }






        }
    }
}



