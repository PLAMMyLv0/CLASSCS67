
//double table, price = 1200;
//Console.Write("Talbe:"); table = Convert.ToDouble(Console.ReadLine());
//if (table > 50) price = 1000;
//Console.Write($"\n\nTable:{table}\nPrice:{price}\nTotal:{table * price}");

//Hw1 Page 5
//double price, num, total, discount = 0.1, tax = 0.07, member, memberY, memberN, memberTax, result;
//Console.Write("Price:"); price = Convert.ToDouble(Console.ReadLine());
//Console.Write("Num:"); num = Convert.ToDouble(Console.ReadLine());
//total = price * num;

//memberN = total * tax;
//result = total + memberN;

//memberY = total * discount;
//memberTax = (total - memberY) * tax;

//Console.Write("Member[1:YES,2:NO]:"); member = Convert.ToDouble(Console.ReadLine());
//if (member == 1) result = total + memberTax;
//Console.Write($"\n\nPrice:{price}\nNum:{num}\nCost:{total}\nTotal:{result}");

//Hw2 Page 28 1,2

//double tax, bonus, result, Jobposition, year;
//Console.Write("[1]Owner[2]Employee:"); Jobposition = Convert.ToDouble(Console.ReadLine());
//Console.Write("Input Salary(year):"); year = Convert.ToDouble(Console.ReadLine());
//if (Jobposition == 1)
//{
//    bonus = year * 0.05;
//    tax = (bonus + year) * 0.04;
//    result = (year + bonus) - tax;
//}
//else if (Jobposition == 2)
//{
//    bonus = year * 0.04;
//    tax = (year + bonus) * 0.02;
//    result = (year + bonus) - tax;
//}
//else
//{
//    Console.Write("ERROR");
//    return;
//}
//Console.Write($"+Bonus{bonus}\nSalary(year)+Bonus:{year + bonus}\n-Tax:{tax}\nSalary(year):{result}");
