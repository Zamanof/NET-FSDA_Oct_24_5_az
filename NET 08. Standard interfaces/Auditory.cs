// Standard interfaces
using System.Collections;

class Auditory: IEnumerable
{
    Student[] students = [

    new Student { FirstName = "Aysel", LastName = "Mammadova", Email = "aysel.mammadova@example.com", BirthDate = new DateTime(2004, 3, 15), StudentCard = new StudentCard { Series = "AA", Id = 100001 } },
    new Student { FirstName = "Rauf", LastName = "Huseynov", Email = "rauf.huseynov@example.com", BirthDate = new DateTime(2003, 11, 25), StudentCard = new StudentCard { Series = "AB", Id = 100002 } },
    new Student { FirstName = "Nigar", LastName = "Aliyeva", Email = "nigar.aliyeva@example.com", BirthDate = new DateTime(2005, 1, 9), StudentCard = new StudentCard { Series = "AC", Id = 100003 } },
    new Student { FirstName = "Elvin", LastName = "Quliyev", Email = "elvin.quliyev@example.com", BirthDate = new DateTime(2004, 6, 30), StudentCard = new StudentCard { Series = "AD", Id = 100004 } },
    new Student { FirstName = "Zehra", LastName = "Seferova", Email = "zehra.safarova@example.com", BirthDate = new DateTime(2005, 9, 12), StudentCard = new StudentCard { Series = "AE", Id = 100005 } },
    new Student { FirstName = "Murad", LastName = "Ismayilov", Email = "murad.ismayilov@example.com", BirthDate = new DateTime(2003, 12, 5), StudentCard = new StudentCard { Series = "AF", Id = 100006 } },
    new Student { FirstName = "Leyla", LastName = "Haciyeva", Email = "leyla.haciyeva@example.com", BirthDate = new DateTime(2004, 7, 7), StudentCard = new StudentCard { Series = "AG", Id = 100007 } },
    new Student { FirstName = "Tural", LastName = "Nasirov", Email = "tural.nasirov@example.com", BirthDate = new DateTime(2005, 5, 20), StudentCard = new StudentCard { Series = "AH", Id = 100008 } },
    new Student { FirstName = "Fidan", LastName = "Rzayeva", Email = "fidan.rzayeva@example.com", BirthDate = new DateTime(2004, 2, 28), StudentCard = new StudentCard { Series = "AI", Id = 100009 } },
    new Student { FirstName = "Kamran", LastName = "Qasimov", Email = "kamran.qasimov@example.com", BirthDate = new DateTime(2003, 8, 17), StudentCard = new StudentCard { Series = "AJ", Id = 100010 } },
    new Student { FirstName = "Gunay", LastName = "Abdullayeva", Email = "gunay.abdullayeva@example.com", BirthDate = new DateTime(2005, 10, 8), StudentCard = new StudentCard { Series = "AK", Id = 100011 } },
    new Student { FirstName = "Nurlan", LastName = "Elizade", Email = "nurlan.elizade@example.com", BirthDate = new DateTime(2004, 4, 14), StudentCard = new StudentCard { Series = "AL", Id = 100012 } },
    new Student { FirstName = "Aydan", LastName = "Sadiqova", Email = "aydan.sadiqova@example.com", BirthDate = new DateTime(2005, 6, 1), StudentCard = new StudentCard { Series = "AM", Id = 100013 } },
    new Student { FirstName = "Emin", LastName = "Mammadov", Email = "emin.mammadov@example.com", BirthDate = new DateTime(2003, 9, 11), StudentCard = new StudentCard { Series = "AN", Id = 100014 } },
    new Student { FirstName = "Shabnam", LastName = "Mustafayeva", Email = "shabnam.mustafayeva@example.com", BirthDate = new DateTime(2004, 12, 22), StudentCard = new StudentCard { Series = "AO", Id = 100015 } },
    new Student { FirstName = "Orkhan", LastName = "Aliyev", Email = "orkhan.aliyev@example.com", BirthDate = new DateTime(2005, 1, 3), StudentCard = new StudentCard { Series = "AP", Id = 100016 } },
    new Student { FirstName = "Nazrin", LastName = "Tagiyeva", Email = "nazrin.tagiyeva@example.com", BirthDate = new DateTime(2004, 3, 8), StudentCard = new StudentCard { Series = "AQ", Id = 100017 } },
    new Student { FirstName = "Ramil", LastName = "Veliev", Email = "ramil.veliyev@example.com", BirthDate = new DateTime(2003, 10, 16), StudentCard = new StudentCard { Series = "AR", Id = 100018 } },
    new Student { FirstName = "Lale", LastName = "Esedova", Email = "lale.esedova@example.com", BirthDate = new DateTime(2005, 8, 29), StudentCard = new StudentCard { Series = "AS", Id = 100019 } },
    new Student { FirstName = "Elchin", LastName = "Qahramanov", Email = "elchin.qahramanov@example.com", BirthDate = new DateTime(2004, 11, 10), StudentCard = new StudentCard { Series = "AT", Id = 100020 } },
];

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort()
    {
        Array.Sort(students);
    }

    public void Sort(IComparer comparer)
    {
        Array.Sort(students, comparer);
    }
}