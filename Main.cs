using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ConsoleAppLearning1.Learning.Operator.Learning.Generic;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.DatetimeExplore;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.ExploreObject;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodExplore;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodOverloading;
using ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodOverriding;
using ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;
using ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;
using ConsoleAppLearning1.Learning.Operator.Learning.RegixExplore;
using ConsoleAppLearning1.Learning.Operator.Learning.SnakeLadderGame;
using ConsoleAppLearning1.Learning.Operator.Learning.Test;
using Operators;
using Animal = ConsoleAppLearning1.Learning.Operator.Learning.Test.Animal;
using Dog = ConsoleAppLearning1.Learning.Operator.Learning.Test.Dog;
using Hospital = ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem.Hospital;
using Patient = ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem.Patient;
using Student = ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance.Student;

namespace ConsoleAppLearning1.Learning.Operator;

public class MainCs
{
 public static void Main(string[] args)
 {
  // Arithmatic a = new Arithmatic();
  // a.func();
  //
  //
  // //method overloading
  // Console.WriteLine(Calculator.Add(10, 20));
  //
  // Console.WriteLine(Calculator.Add(10, 20, 30));

  //method overriding
  // Dog dog = new Dog();
  // dog.Speak();
  //
  // Animal animal = new Dog();
  // animal.Speak();
  //
  // int max = Math.Max(10, 20);
  //
  // int d = 6;
  // switch (d)
  // {
  //     case 10:
  //         Console.WriteLine(d);
  //         break;
  //     case 20:
  //         Console.WriteLine(d);
  //         break;
  //     case 30:
  //         Console.WriteLine(d);
  //         break;  
  //     default:
  //         Console.WriteLine(d);
  //         break;
  //     
  // }

  // string str1 = Console.ReadLine();
  // Console.WriteLine(str1);
  // int num = int.Parse(str1);
  // Console.WriteLine(num); //if str1 contains characters then it will give ForamtException
  //  int num1 = int.Parse(Console.ReadLine());
  //  Console.WriteLine(num1);

  // int num2 = Console.ReadKey();
  // char ch = Console.ReadLine() ![0];
  // Console.WriteLine(ch);
  // char ch1 = (char)Console.Read();
  // Console.WriteLine(ch1);


  //Problem Solving

  //  int[] arr = { 1, 2, 2, 3, 3 };

  // for(int i = 0 ; i < arr.Length ; i++)
  // {
  //     arr[i] = int.Parse(Console.ReadLine());
  // }

  // ArrayCS.printElements(arr);

  // List<int> res  = ArrayCS.removeDuplicates(arr);
  // Console.WriteLine(res);
  // foreach (int i in res)
  // {
  //     Console.WriteLine(i);
  // }

  // double double1 = Convert.ToDouble(Console.ReadLine());
  // Console.WriteLine(double1);
  // int int1 = Convert.ToInt32(Console.ReadLine());
  // Console.WriteLine(int1);

  //  double double2 =   ArrayProblem.TriangleArea(12, 12);
  //  Console.WriteLine(double2);
  //  
  //  Console.WriteLine(ArrayProblem.Anagram("HarSh" , "harsH"));
  //
  //  string[] strs = { "flower", "flow", "flight" };
  //
  //  string longestPrefix = ArrayProblem.LongestCommonPrefix(strs);
  //  Console.WriteLine(longestPrefix);
  //
  // string rev =  ArrayProblem.Reverse("EasyRewardz");
  // Console.WriteLine(rev);
  // int [] arr1 = { 1, 3, 2, 0, 1, 0, 2, 1, 0, 4 };
  // ArrayProblem.MoveZerosToEnd(arr1);
  //
  // foreach (int i in arr1)
  // {
  //     Console.Write(i + " ");
  // }

  // string s1 = new string("Harsh");
  // string s2 = "Harsh";
  //
  // if(s1 == s2) Console.WriteLine(s1); //both equals() and == check content not referance
  //
  //
  // int [ , ] array = new int[3 , 3]; //2d array
  //
  // for (int i = 0; i < array.GetLength(0); i++) //GetLength gives us the length of particular dimension
  // {
  //     for (int j = 0; j < array.GetLength(1); j++)
  //     {
  //        array[i, j] = i + j; 
  //     }
  //    Console.Error.WriteLine(array);
  //}




  // int[] array2 = { 1, 2, 3, 4 };
  // int [] copy = new int[array2.Length];
  //
  // Array.Copy(array2 , copy , 4);
  //Array.Clear(array2 , 1 , 3);     // }


  // Array.Reverse(array2 , 1 , 3);
  // Array.Resize(ref array2 , 6);

  // for (int i = 0; i < array2.Length; i++)
  // {
  //     Console.Write(array2[i] + " ");
  // }


  // for (int i = 0; i < copy.Length; i++)
  // {
  //     Console.Write(copy[i] + " ");
  // }
  //
  //  int input = Convert.ToInt32(Console.ReadLine());
  // ArrayProblem.practiceProblem(input);

  //  string inputString = Convert.ToString(Console.ReadLine());
  // char ch =  ArrayProblem.FirstNonRepatingCharacter(inputString);
  // Console.WriteLine(ch);

  //input 2d array
  // string n = Console.ReadLine();
  // string m = Console.ReadLine();
  // int row;
  // int column;
  // if ((!int.TryParse(n, out row) || row < 0) || (!int.TryParse(m, out column) || column < 0))
  // {
  //     Console.Error.WriteLine("Invalid input");
  //     return;
  // }
  //
  // int [ , ] array2D = new int[row , column];
  //
  // for (int i = 0; i < array2D.GetLength(0); i++)
  // {
  //     for (int j = 0; j < array2D.GetLength(1); j++)
  //     {
  //         array2D[i, j] = Convert.ToInt32(Console.ReadLine());
  //     }
  // }
  //
  // ArrayProblem.Print2DArray(array2D);
  //
  // Assignment1.WelcomeToBridgelabz();
  // Assignment1.AddTwoNumbers();
  // Assignment1.CelsiusToFahrenheit();
  // Assignment1.AreaOfCircle();
  // Assignment1.VolumeOfCylinder();
  // Assignment1.CalculateSimpleInterest();

  // int[] termiator = { 1, 2, 3, 4, 5 };
  // int[] skynet = new int[4];
  // Array.Copy(termiator , skynet, 2); //here length is how many elements we 
  //want to copy in new arr. (length in parameter  <= length of new arr)

  // for (int i = 0; i < skynet.Length; i++)
  // {
  //     Console.WriteLine(skynet[i]);
  // }


  int[] nums = { 10, 20, -30, 40, 50 };
  int[] ones = { 1, 0, 1, 1, 1, 0, 20, 40 };
  // int a = 5;
  // MethodExp.Change(nums , ref a) ;
  // Console.WriteLine(a);
  //Console.WriteLine(nums[0]);

  // string name = "Hello";
  // MethodExp.Change2(name);
  // Console.WriteLine(name); //Hello 



  // MethodExp.Change3(nums);
  // Console.WriteLine(nums[0]);
  // Console.WriteLine(nums[1]);
  // Console.WriteLine(nums[2]);


  // MethodExp.Change4(nums);
  // Console.WriteLine(nums[0]);

  //MethodExp.Change5(nums);

  //MethodExp.Change6(nums);


  // MethodExp.Change7(ref nums);
  // Console.WriteLine(nums[0]);

  //MethodExp.Change8(nums);


  // MethodExp.Change9(ref nums);
  // Console.WriteLine(nums.Length);

  // int[] dice = { 1, 2, 3, 4, 5, 6 };
  // Random random = new Random();
  // random.Shuffle(dice);
  // Console.WriteLine(string.Join(",", dice));
  //
  // for (int i = 0; i < 6; i++)
  // {
  //     Console.WriteLine(random.Next(3 , 5)); //from 3  to 5 - 1 i-e 4
  //     
  // }
  //
  // int randomNum = random.Next(1 , 10); // 1 to 9
  //
  // Console.WriteLine(random.Next()); //it will print number from 1 to 10 in random order
  //
  //

  //Math
  //double absDouble =  Math.Abs(2.6);
  //Console.WriteLine(absDouble);
  //Console.WriteLine(Math.Ceiling(absDouble)); //next int
  //Console.WriteLine(Math.Floor(absDouble)); //prev int
  //Console.WriteLine(Math.Round(absDouble)); //closest int

  //MethodExp.Change10(10 , 20 , 3 , 7 );


  // string number = Console.ReadLine();
  //
  // if (!int.TryParse( number , out int num))
  // {
  //     Console.Error.WriteLine("Invalid input");
  // }

  // int cntUpperCase = ArrayProblem.CountUpperCase("HarsH");
  // Console.WriteLine(cntUpperCase);
  //
  // ArrayProblem.rotateArrayLeft(nums , 2);
  // Console.WriteLine(string.Join(", " , nums));

  // int maxOnes = ArrayProblem.MaxConsecutiveOnes(ones);
  // Console.WriteLine(maxOnes);

  // int maxSubarraySum = ArrayProblem.MaxSubarraySum(nums);
  // Console.WriteLine(maxSubarraySum);

  // IList<int> unionArrays  = ArrayProblem.UnionArray(nums, ones);
  // Console.WriteLine(string.Join(", " , unionArrays));
  // string sentence = "my name is harshdeep singh";
  // string [] strs   = sentence.Split(' ');

  // Console.WriteLine(Assignments.ArmStrong(153));
  //Console.WriteLine(Assignments.NeonNumber(9));
  // DayOfWeek startDay = Assignments.FirstDayOfMonth(4, 2006); 
  //  Console.WriteLine(startDay);

  // string monthName = "April";
  // int year = 2006;
  // Console.WriteLine($"{monthName} {year}");
  // Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
  // int startDay = (int)Assignments.FirstDayOfMonth(4, year);
  // for (int i = 0; i < startDay; i++)
  // {
  //     Console.Write("    ");
  // }
  // int numberOfDays = Assignments.NumberOfDaysInMonth(monthName, year);
  // for(int day=1;day<=numberOfDays;day++)
  // {
  //     Console.Write($"{day,3} ");
  //
  //     if((day+startDay)%7==0)
  //     {
  //         Console.WriteLine();
  //     }
  // }
  // int[,] convertToTranspose =
  // {
  //     { 1, 2, 3 },
  //     { 4, 5, 6 },
  //      { 7, 8, 9 },
  // };
  // Assignments.Transpose(convertToTranspose);
  //Assignments.printDiamond(4);
  // string s1 = "HARSH";
  // string s2 = "HARSH";
  // Console.WriteLine(s1.Equals(s2));
  // Console.WriteLine(s1 == s2);
  // int a, b;
  // ArrayProblem.func1( out a , out b);
  //ArrayProblem.HollowTriangle(4);


  //StringProblem.ThreadSaftyExample();

  // ExploreObject objA = new ExploreObject(1, "Harsh");
  // ExploreObject objB = new ExploreObject(1, "Harsh");
  // Console.WriteLine(objA.Equals(objB));
  // HashSet<ExploreObject> set1 = new  HashSet<ExploreObject>();
  // set1.Add(objA);
  // set1.Add(objB);
  // Console.WriteLine(set1.Count);

  // DateTimeExp.BuildInFunc();

  // Circle circle = new Circle(4);
  // Console.WriteLine(circle.GetArea());
  // Console.WriteLine(circle.GetPerimeter());
  //
  //
  // Book book = new Book("Thinking slow and fast", "Daniel Kahneman", 120);
  // Console.WriteLine(book.Title);
  //book.Title = "How are you?";
  // book.display();




  //  Student s1 = new Student("Harsh", 2121);
  //  Student s2 = new Student("Harsh", 2122);
  //
  // Console.WriteLine(s1.name == s2.name);
  //Console.WriteLine(s1.Equals(s2));

  // Person person1 = new Person("Harsh", 20, "harshdeepsingh10d@gmail.com");
  // Person person2 = new Person(person1);
  // Console.WriteLine(person1.Name);
  //  Console.WriteLine(person2.Name);

  // Hotel booking1 = new Hotel("Rohan" , RoomType.Double , 2);
  // Hotel booking2 = new Hotel(booking1);
  // booking2.RoomType = RoomType.Triple;
  // Console.WriteLine(booking2.RoomType);

  // LibraryBook book1 = new LibraryBook("Danial kahneman", "Daniel Kahneman", 2  , 120);
  // Console.WriteLine(book1.Title);
  // book1.BorrowBook();
  // Console.WriteLine(book1.Available);

  // CarRental carRental1 = new CarRental("Harsh", CarModel.Hyundai_Creta, 3);
  // Console.WriteLine(carRental1.TotalCost());

  //PostgraduateStudent postgraduateStudent1 = new PostgraduateStudent(1841 , "Harsh" , 9.21);

  // BankAccount bankAccount = new SavingAccount(12345654321, "Harsh");
  // SavingAccount savingAccount = new SavingAccount(12345654322, "James");
  // if (bankAccount is SavingAccount)
  // {
  //  Console.WriteLine("This is a saving account");
  // }
  //
  //
  //
  // if (bankAccount is SavingAccount)
  // {
  //  Console.WriteLine("This is a bank account");
  // }
  // LibraryBook libraryBook = new LibraryBook("author", "title", 12, 120);
  // libraryBook.Author = "Daniel Kahneman";
  //


  // Patient p1 = new Patient("Rahul", 25, "Fever");
  // Patient p2 = new Patient("Anita", 30, "Migraine");
  //
  // Console.WriteLine($"Hospital Name: {Patient.HospitalName}");
  // Console.WriteLine($"Total Patients: {Patient.GetTotalPatients()}");
  // Console.WriteLine();
  //
  // // Using 'is' operator
  // object obj = p1;
  //
  // if (obj is Patient )
  // {
  //  Patient? p = obj as Patient;
  //  p?.Display();
  // }

//
//  Hospital hospital = new Hospital("Civil Hospital");
//  Address address = new Address("Ambala" , "stree1" , "13232" , "India");
//  MedicalRecord medicalRecord = new MedicalRecord(1 , "diagonisis" , "Fever");
//  Patient p1 = new Patient(1, "Rohan", 21, "Male" , BloodGroup.B_Positive, address, medicalRecord);
// Doctor d1 = new Doctor(1 , "Mahesh Bhatt" ,34 , "Male" , "Cardiologists" , 13131);
// hospital.RegisterPatient(p1);
// Appointment appointment = new Appointment("")
//   string text = "   The   quick   brown    fox    jumps   over    the   lazy   dog.   \n" +
//                 "   this    is   the   second    sentence   with   bad   spacing.   \n" +
//                 "   and   here   is   the   third   one    to   finish   the   test.   ";
//
// Console.WriteLine(StringProblem.FormatSentence(text));

  // Game game = new Game();
  //
  // Console.Write("Enter number of players (2-4): ");
  //
  // int count = int.Parse(Console.ReadLine());
  //
  // if (count < 2 || count > 4)
  // {
  //  Console.WriteLine("Invalid number of players.");
  //  return;
  // }
  //
  // for (int i = 1; i <= count; i++)
  // {
  //  Console.Write($"Player {i} Name : ");
  //  string name = Console.ReadLine();
  //
  //  game.Players.Add(new Player(name));
  // }
  //
  // game.Start();
  //
  //  Employee e1 = new Employee("Harsh" , 21);  //compiler autmatically check values through Equals() and also generate HashCode
  //  Employee e2 = new Employee("Harsh", 21);
  //  HashSet<Employee> set = new HashSet<Employee>();
  //  set.Add(e1);
  //  set.Add(e2);
  //  Console.WriteLine(set.Count);
  // Console.WriteLine(e1.Equals(e2));


  // Animal animal = new Dog("Tom" , 2);
  // animal.Speak();
  //
  // Teacher teacher = new Teacher(
  //  "John",
  //  40,
  //  "Mathematics");
  //
  // Student student = new Student(
  //  "Harsh",
  //  20,
  //  4);
  //
  // Staff staff = new Staff(
  //  "Rahul",
  //  35,
  //  "Administration");
  //
  // teacher.Display();
  // teacher.DisplayRole();
  //
  // Console.WriteLine();
  //
  // student.Display();
  // student.DisplayRole();
  //
  // Console.WriteLine();
  //
  // staff.Display();
  // staff.DisplayRole();
  //
  //  Book book1 = new Book("title1", "author1");
  //  Book [] books = {book1  ,  new Book("title2" , "author2")};
  //  
  //  Library library = new Library(books);
  //  Book [] searchedBooks = library.Search("title");
  //  foreach(Book book in searchedBooks)
  //  {
  //   Console.WriteLine(book);
  //  }
  //  library.CheckoutBook("title1");
  //  Console.WriteLine(book1.IsAvailable);
  //  library.ReturnBook("title1");
  //  Console.WriteLine(book1.IsAvailable);
  // }
  //
  //record Employee(string name, int age);

  // Patient p1 = new Patient(1, "Harsh" , 20 ,"MALE" , BloodGroup.O_Negative , new Address("Ambala" , "Huda" , "134003" , "India") , new MedicalRecord(1 , "diagonis" , "Elergy"));
  // Test1 test1 = new Test1();
  
  
  // BasicRegix basicRegix =  new BasicRegix();
  // basicRegix.Basics1();
  
  // Storage<Electronics> electronics = new Storage<Electronics>();
  //
  // electronics.AddItem(new Electronics(1, "Laptop"));
  // electronics.AddItem(new Electronics(2, "Phone"));
  //
  // electronics.DisplayItems();
  
  
  // Course<ExamCourse> examCourses = new Course<ExamCourse>();
  //
  // examCourses.AddCourse(
  //  new ExamCourse("Data Structures")
  // );
  //
  // examCourses.AddCourse(
  //  new ExamCourse("Operating Systems")
  // );
  //
  // examCourses.DisplayCourses();

  
 }

}
    


