// Exceptions

/*
    Exception
        - SystemException
        - ApplicationException
*/

/*
vavib olmayan qayda:
    Istifadechi terefinden yaradilan butun exceptionlar
    ApplicationException class-dan toremelidir

vacib qaydalar:
    1. Exception uchcun [Serializable] atributu tetbiq edilmelidir
    2. Exception-un default constructor-u olmalidir
    3. Message property-ni teyin etmek uchun constructor-u olmalidir
    4. Inner exception-lari handle etmek uchun overload olunmush constructor-u olmalidir
    5. Tipi serializasiya etmek uchun verload olunmush constructor-u olmalidir
 */


using System.Runtime.Serialization;

[Serializable]
class MyException : ApplicationException
{
    public MyException(){}
    public MyException(string? message) : base(message){}

    public MyException(string? message, Exception? innerException) 
        : base(message, innerException)
    {}

    protected MyException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    {}
}