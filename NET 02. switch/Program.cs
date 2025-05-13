// switch

//int.TryParse(Console.ReadLine(), out int weekDay);
// break sozu mutleq yazilmalidir
//switch ((WeekDays)weekDay)
//{
//    case WeekDays.MONDAY:
//        Console.WriteLine("Bazar ertesi");
//        break;
//    case WeekDays.TUESDAY:
//        Console.WriteLine("Ch. Axshami");
//        break;
//    case WeekDays.WEDNESDAY:
//        Console.WriteLine("Chershenbe");
//        break;
//    case WeekDays.THURSDAY:
//        Console.WriteLine("C. Axshami");
//        break;
//    case WeekDays.FRIDAY:
//        Console.WriteLine("Cume");
//        break;
//    case WeekDays.SATURDAY:
//        Console.WriteLine("Shenbe");
//        break;
//    case WeekDays.SUNDAY:
//        Console.WriteLine("Bazar");
//        break;
//    default:
//        Console.WriteLine("1-7 araliqinda deyil");

//        break;
//}

// istenilen tipde case mumkundur
//double.TryParse(Console.ReadLine(), out double numb);
//switch (numb)
//{
//    case 0.5:
//        Console.WriteLine("Hi");
//        break;
//    default:
//        break;
//}

//string name = Console.ReadLine();
//switch (name)
//{
//    case "Nadir":
//        Console.WriteLine("Hello");
//        break;
//    default:
//        break;
//}

int.TryParse(Console.ReadLine(), out int month);

switch ((Months)month)
{
    case Months.JANUARY:
    case Months.MARCH:
    case Months.MAY:
    case Months.JULY:
    case Months.AUGUST:
    case Months.OCTOBER:
        goto case Months.DECEMBER;
    case Months.APRIL:
    case Months.JUNE:
    case Months.SEPTEMBER:
    case Months.NOVEMBER:
        Console.WriteLine("30 gun");
        break;
    case Months.DECEMBER:
        Console.WriteLine("31 gun");
        break;
    default:
        break;
    case Months.FEBRUARY:
        Console.WriteLine("28 ve ya 29 gun");
        break;
}

enum WeekDays
{
    MONDAY = 1,
    TUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY,
    SUNDAY
}

enum Months
{
    JANUARY = 1,
    FEBRUARY,
    MARCH,
    APRIL,
    MAY,
    JUNE,
    JULY,
    AUGUST,
    SEPTEMBER,
    OCTOBER,
    NOVEMBER,
    DECEMBER

}
