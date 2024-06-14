//using System;

//namespace PLAMMY
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome");
//            int a, b, c, d;
//            a = 25;
//            b = 45;
//            c = a * b;
//            d = c * b - a;
//            Console.WriteLine("A = "+a);
//            Console.WriteLine("B = "+b);
//            Console.WriteLine("C = "+c);
//            Console.WriteLine("D = "+d);



// string firstname = "peyapong";
// string lastname = "samakorn";
// string fullname = firstname + lastname;
// Console.WriteLine("my name is : " + fullname);

// int x, y, z;
// x = y = z = 50;
// Console.WriteLine("X + Y + Z = "( x + y + z));
//        

//    }
//}



//int a, b, c, d;
//a = 25;
//b = 45;
//c = a * b;
//d = c * b - a;
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);



//string FirstName = "Peyapong";
//string LastName = "Samakorn";
//string FullName = FirstName + LastName;
//Console.WriteLine(FullName);



//int x, y, z;
//x = y = z = 50;
//Console.WriteLine(x + y + z);



//int myInt = 9;
//double myDouble = myInt;

//Console.WriteLine(myDouble);
//Console.WriteLine(myInt);

//double myDouble = 9.78;
//int myInt = (int)myDouble;

//Console.WriteLine(myDouble);
//Console.WriteLine(myInt);



//Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):// Comment : Convert Type //

//int myInt = 10;
//double myDouble = 5.25;
//bool myBool = true;

//Console.WriteLine(Convert.ToString(myInt));
//Console.WriteLine(Convert.ToDouble(myInt));
//Console.WriteLine(Convert.ToInt32(myDouble));
//Console.WriteLine(myDouble);
//Console.WriteLine(Convert.ToString(myBool));



//Console.Write("Username: ");

//string username = Console.ReadLine();

//Console.WriteLine("Username is " + username);

//Console.Write("Your Age: ");

//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Your age is "+age);



//NoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNoteNote//////////////////////////////////
//=      num=5      num=5
//+=     num+=5     num=num+5
//-=     num-=5     num=num-5
//*=     num*=5     num=num*5
//%=     num%=5     num=num%5
// ++  --

//&=	x &= 3	x = x & 3	
//|= x |= 3  x = x | 3
//^= x ^= 3  x = x ^ 3
//>>= x >>= 3 x = x >> 3
//<<= x <<= 3 x = x << 3

//int x = 5;
//Console.WriteLine(x &=3);
//Console.WriteLine(x |= 3);
//Console.WriteLine(x ^= 3);
//Console.WriteLine(x >>= 3);
//Console.WriteLine(x <<= 3);



//==    Equal to                    x == y	
//!=	Not equal	                x != y	
//>	    Greater than                x > y	
//< 	Less than	                x < y	
//>=	Greater than or equal to	x >= y	
//<=	Less than or equal to   	x <= y

//Operator Name	Description	Example	Try it
//&& 	Logical and	Returns True if both statements are true	                x < 5 && x < 10	
//|| 	Logical or	Returns True if one of the statements is true           	x < 5 || x < 4	
//! 	Logical not	Reverse the result, returns False if the result is true	  !(x < 5 && x < 10)



//MathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMathMath//////////////////////////////////
//The Math.Max(x, y)     method can be used to find the highest value of x and y:
//The Math.Min(x, y)     method can be used to find the lowest value of of x and y:
//The Math.Sqrt(x)       method returns the square root of x:
//The Math.Abs(x)        method returns the absolute (positive) value of x:
//Math.Round()           rounds a number to the nearest whole number:



//string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//Console.WriteLine("The length of the txt string is: " + txt.Length);

//string txts = "Hello World";
//Console.WriteLine(txts.ToUpper());   // Outputs "HELLO WORLD"
//Console.WriteLine(txts.ToLower());   // Outputs "hello world"


//string firstName = "Peyapong ";
//string lastName = "Samakorn";
//string name = string.Concat(firstName, lastName);
//Console.WriteLine(name);


//string firstName = "Peyapong";
//string lastName = "Samakorn";
//string name = $"My full name is: {firstName} {lastName}";
//Console.WriteLine(name);
//Also note that you have to use the dollar sign ($) when using the string interpolation method.//////////////////////////////////



//string myString = "Hello";
//Console.WriteLine(myString[0]);  // Outputs "H"   0=1   1=2  Letter

//string myString = "Hello";
//Console.WriteLine(myString[1]);  // Outputs "e"

//string myString = "Hello";
//Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"   1 from e  and e is 1 from Hello (0H 1e 2l 3l 4o)

//// Full name
//string name = "Peyapong Samakorn";

//// Location of the letter S
//int charPos = name.IndexOf("S");

//// Get last name
//string lastName = name.Substring(charPos);

//// Print the result
//Console.WriteLine(lastName);


//string txt = "We are the so-called \"Vikings\" from the north.";
//string txts = "It\'s alright.";
//string txte = "The character \\ is called backslash.";

//Console.WriteLine(txt);
//Console.WriteLine(txts);
//Console.WriteLine(txte);

////\n = NewLine  , \t = Tab  , \b = Backspace//////////////////////////////////


//int x = 10;
//int y = 9;
//Console.WriteLine(x>y);
//Console.WriteLine(y==9);
//Console.WriteLine(y==10);

//int myAge = 25;
//int votingAge = 18;

//if (myAge >= votingAge)
//{
//    Console.WriteLine("Old enough to vote!");
//}
//else
//{
//    Console.WriteLine("Not old enough to vote.");
//}


//if (20 > 18) ;
//{
//    Console.WriteLine("20 is greater than 18");
//}


//int time = 20;
//if (time < 18)
//{
//    Console.WriteLine("Good day.");
//}
//else
//{
//    Console.WriteLine("Good evening.");
//}
//// Outputs "Good evening."


//int time = 22;
//if (time < 10)
//{
//    Console.WriteLine("Good morning.");
//}
//else if (time < 20)
//{
//    Console.WriteLine("Good day.");
//}
//else
//{
//    Console.WriteLine("Good evening.");
//}
//// Outputs "Good evening."

////int time = 20;
////string result = (time < 18) ? "Good day." : "Good evening.";
////Console.WriteLine(result);//////////////////////////////////////////////////////////////////////////////





//int day = 12;
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("No have other number , try again");
//        break;
//}
//// Outputs "Thursday" (day 4)


//int i = 0;
//while (i < 1000000000000000)
//{
//    Console.WriteLine(i);
//    i++;
//}


//int i = 0;
//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i < 10);


//for (int i = 0; i < 5; i++) //อ่านค่าคือ สำหรับค่า INT I เท่ากับ 0 แล้ว I มีค่าน้อยกว่า 5 ให้ทำการเพิ่มค่า I ที่ละ 1 จนถึง 5 แต่มีค่าน้อยกว่า 5
//{
//    Console.WriteLine(i);
//}

/*for (int i = 0; i <= 10; i = i + 2)
{
    Console.WriteLine(i);
}*/

// Outer loop
//for (int i = 1; i <= 2; ++i)
//{
//    Console.WriteLine("Outer: " + i);  // Executes 2 times

//    // Inner loop
//    for (int j = 1; j <= 3; j++)
//    {
//        Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
//    }
//}


//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//foreach (string i in cars)                                    //อ่านค่าคือ อ่านค่า I ให้ครบ
//{
//    Console.WriteLine(i);
//}


//for (int i = 0; i <= 10; i = i + 2)
//{
//    Console.WriteLine(i);
//}

////int i = 0 คือการกำหนดค่าเริ่มต้นของตัวแปร i เป็น 0 ซึ่งจะถูกใช้เป็นตัวนับในการวนรอบของลูป
////i <= 10 เป็นเงื่อนไขที่กำหนดว่าลูปควรทำงานต่อหรือไม่ กล่าวคือถ้า i ยังน้อยกว่าหรือเท่ากับ 10 ลูปจะทำงานต่อ
////i = i + 2 เป็นคำสั่งเพิ่มค่าของ i ทีละ 2 หลังจากทุกครั้งที่ลูปทำงานเสร็จสิ้น
////Console.WriteLine(i); เป็นคำสั่งในลูปที่ใช้แสดงค่าของ i บนคอนโซล



//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        break; //continue หยุดเมื่อถึง4 แต่ถ้าใช้คำสั่งข้างหลังจะไปต่อจนค่าที่กำหนดไว้ข้างบน
//    }
//    Console.WriteLine(i);
//}

//int i = 0;
//while (i < 10)
//{
//    Console.WriteLine(i);
//    i++;
//    if (i == 4)
//    {
//        break;
//    }
//}

//int i = 0;
//while (i < 10)
//{
//    if (i == 4)
//    {
//        i++;
//        continue;
//    }
//    Console.WriteLine(i);
//    i++;
//}


//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//cars[0] = "Opel";
//Console.WriteLine(cars[0]);
//// Now outputs Opel instead of Volvo////////// Opel แทนที่ Volvo
//Console.WriteLine(cars.Length);
//// Outputs 4
///

//// Create an array of four elements, and add values later
//string[] cars = new string[4];


//// Create an array of four elements and add values right away 
//string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };


//// Create an array of four elements without specifying the size 
//string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };


//// Create an array of four elements, omitting the new keyword, and without specifying the size
//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//Console.WriteLine(cars[3]);


//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//for (int i = 0; i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}//////////////////////////////////////////////////////////////////////////////////////////////////////ไล่คำสั่ง อ่านทุกชื่อรถ


//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//foreach (string i in cars)
//{
//    Console.WriteLine(i);
//}//////////////////////////////////////////////////////////////////////////////////////////////////////Short Hand จากข้างบนแบบย่อ


//// Sort a string
//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//Array.Sort(cars);
//foreach (string i in cars)
//{
//    Console.WriteLine(i);
//}


//// Sort an int
//int[] myNumbers = { 5, 1, 8, 9 };
//Array.Sort(myNumbers);
//foreach (int i in myNumbers)
//{
//    Console.WriteLine(i);
//}


//using System;
//using System.Linq;

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] myNumbers = { 5, 1, 8, 9 };
//            Console.WriteLine(myNumbers.Max());  // returns the largest value
//            Console.WriteLine(myNumbers.Min());  // returns the smallest value
//            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
//        }
//    }
//}

//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
//numbers[0, 0] = 5;  // Change value to 5
//Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}


//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

//for (int i = 0; i < numbers.GetLength(0); i++)
//{
//    for (int j = 0; j < numbers.GetLength(1); j++)
//    {
//        Console.WriteLine(numbers[i, j]);
//    }
//}



////Arrays
////int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
////Console.WriteLine(numbers[0, 2]);  // Outputs 2