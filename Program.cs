// Basic. Tanlash
// 1 - masala
Console.Write("So'z kiriting: ");
string str = Console.ReadLine();
Console.Write("Son kiriting: ");
string inputValue = Console.ReadLine();
int n = Convert.ToInt32(inputValue);

if (n > str.Length)
{
    Console.WriteLine(str.ToUpper());
}
else
{
    Console.WriteLine(str.ToLower());

}


//---------------------------------------------------
// 2-masala
int x = 15;
int y = 10;
if (x > y)
{
    Console.WriteLine("x is greater than y");
}
else if (x < y)
{
    Console.WriteLine("x is less than y");
}
else if (x == y)
{
    Console.WriteLine("x is equal to y");
}
else
{
    Console.WriteLine("x and y are not comparable");
}

//---------------------------------------------------
// 3-masala
Console.Write("Hafta kunini kiriting: ");
string inputweekDay = Console.ReadLine();
string weekDay = inputweekDay.ToLower(); //Dushanba DuSHAnba kabi katta kichik turli xil kiritilgan kunlarni bir xil qilib olish uchun

switch (weekDay)
{
    case "dushanba":
        Console.WriteLine("Monday");
        break;

    case "seshanba":
        Console.WriteLine("Tuesday");
        break;
    case "chorshanba":
        Console.WriteLine("Wednesday");
        break;
    case "payshanba":
        Console.WriteLine("Thursday");
        break;
    case "juma":
        Console.WriteLine("Friday");
        break;
    case "shanba":
        Console.WriteLine("Saturday");
        break;
    case "yakshanba":
        Console.WriteLine("Sunday");
        break;

    default:
        Console.WriteLine("Noto'g'ri qiymat kiritildi!");
        break;
}

