// Exceptions

/*
    Exception
        - SystemException
        - ApplicationException
*/

int numb1 = 3;
int numb2 = 1;
int result = default;
try
{
    //result = numb1 / numb2;
    //Console.WriteLine(result);
    //throw new Exception();

    //Foo(numb1, numb2);
    //Bar();
    Some();
    //throw new MyException("This is SPARTAAAA!!!");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Catch in Main - DivideByZeroException");
    Console.WriteLine();
    Console.WriteLine($"Message - {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Stack trace - {ex.StackTrace}");
    Console.WriteLine();
    Console.WriteLine($"Target site - {ex.TargetSite}");
}
catch(MyException ex)
{
    Console.WriteLine("Catch in Main - MyException");
    Console.WriteLine();
    Console.WriteLine($"Message - {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Stack trace - {ex.StackTrace}");
    Console.WriteLine();
    Console.WriteLine($"Target site - {ex.TargetSite}");
}

catch (Exception ex)
{
    Console.WriteLine("Catch in Main - Any exception");
    Console.WriteLine();
    Console.WriteLine($"Message - {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Stack trace - {ex.StackTrace}");
    Console.WriteLine();
    Console.WriteLine($"Target site - {ex.TargetSite}");
}

// Bundan evvelki catch bloku butun exceptionlari emal etdiyi uchun
// bu blok hal hazirda menasizdir
//catch
//{
//    Console.WriteLine("Catch in Main - Any exception");
//}

// finally istenilen halda(exception olsa da, olmasa da, emal edilse de, edilmese de)
// ishe dushecek kod blokudur 
finally
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Finally block");
    Console.ForegroundColor = ConsoleColor.White;
}

int Foo(int a, int b)
{
    int result = default;
    int[] arr = new int[5];

    try
    {
        result = a / b;
        Console.WriteLine(arr[8]);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Catch in Foo method - DivideByZeroException");
        Console.WriteLine();
        Console.WriteLine($"Message - {ex.Message}");
        Console.WriteLine();
        Console.WriteLine($"Stack trace - {ex.StackTrace}");
        Console.WriteLine();
        Console.WriteLine($"Target site - {ex.TargetSite}");
        //throw new Exception("Men exceptionam");
        throw;
    }

    return result;
}

void Bar()
{
    Foo(5, 0);
}

void Some()
{
    Bar();
}
