
List<Group> groups = [
    new Group { Id = 1, Name = "Group A", Faculty = "Programming" },
    new Group { Id = 2, Name = "Group B", Faculty = "Design" },
    new Group { Id = 3, Name = "Group C", Faculty = "Cybercecurity" },
    new Group { Id = 4, Name = "Group D", Faculty = "Programming" },
    new Group { Id = 5, Name = "Group E", Faculty = "Design" },
    new Group { Id = 6, Name = "Group F", Faculty = "Cybercecurity" },
    new Group { Id = 7, Name = "Group G", Faculty = "Programming" },
    new Group { Id = 8, Name = "Group H", Faculty = "Design" },
    new Group { Id = 9, Name = "Group I", Faculty = "Cybercecurity" }
    ];
List<Student> students = [
    new Student
    {
        FirstName = "Alice",
        LastName = "Alisson",
        Age = 20,
        GroupId = 1 
    },
    new Student
    {
        FirstName = "Bob",
        LastName = "Bobby",
        Age = 22,
        GroupId = 2
    },
    new Student
    {
        FirstName = "Charlie",
        LastName = "Charlson",
        Age = 21,
        GroupId = 3
    },
    new Student
    {
        FirstName = "David",
        LastName = "Davidson",
        Age = 23,
        GroupId = 4
    },
    new Student
    {
        FirstName = "Eve",
        LastName = "Everson",
        Age = 19,
        GroupId = 5
    },
    new Student
    {
        FirstName = "Frank",
        LastName = "Franklin",
        Age = 24,
        GroupId = 6
    },
    new Student
    {
        FirstName = "Grace",
        LastName = "Gracely",
        Age = 20,
        GroupId = 7
    },
    new Student
    {
        FirstName = "Hank",
        LastName = "Hankson",
        Age = 22,
        GroupId = 8
    },
    new Student
    {
        FirstName = "Ivy",
        LastName = "Iverson",
        Age = 21,
        GroupId = 1
    },
    new Student
    {
        FirstName = "Jack",
        LastName = "Jackson",
        Age = 23,
        GroupId = 2
    },
    new Student
    {
        FirstName = "Kathy",
        LastName = "Katherson",
        Age = 19,
        GroupId = 3
    },
    new Student
    {
        FirstName = "Leo",
        LastName = "Leonard",
        Age = 24,
        GroupId = 2
    },
    new Student
    {
        FirstName = "Mia",
        LastName = "Miller",
        Age = 20,
        GroupId = 1
    },
    new Student
    {
        FirstName = "Nina",
        LastName = "Nixon",
        Age = 22,
        GroupId = 3
    },
    new Student
    {
        FirstName = "Oscar",
        LastName = "Oswald",
        Age = 21,
        GroupId = 9
    },
    new Student
    {
        FirstName = "Paul",
        LastName = "Parker",
        Age = 23,
        GroupId = 4
    },
    new Student
    {
        FirstName = "Quinn",
        LastName = "Quinnson",
        Age = 19,
        GroupId = 5
    },
    new Student
    {
        FirstName = "Rita",
        LastName = "Richardson",
        Age = 24,
        GroupId = 3
    },
    new Student
    {
        FirstName = "Sam",
        LastName = "Sampson",
        Age = 20,
        GroupId = 6
    },
    new Student
    {
        FirstName = "Tina",
        LastName = "Thompson",
        Age = 22,
        GroupId = 9
    },
    new Student
    {
        FirstName = "Uma",
        LastName = "Underwood",
        Age = 21,
        GroupId = 7
    },
    new Student
    {
        FirstName = "Vera",
        LastName = "Vasquez",
        Age = 23,
        GroupId = 8
    },
    new Student
    {
        FirstName = "Will",
        LastName = "Williams",
        Age = 19,
        GroupId = 1
    },
    new Student
    {
        FirstName = "Xena",
        LastName = "Xavier",
        Age = 24,
        GroupId = 2
    },
    new Student
    {
        FirstName = "Yara",
        LastName = "Young",
        Age = 20,
        GroupId = 3
    },
    new Student
    {
        FirstName = "Zane",
        LastName = "Zimmerman",
        Age = 22,
        GroupId = 4
    },
    new Student
    {
        FirstName = "Aaron",
        LastName = "Anderson",
        Age = 21,
        GroupId = 5
    },
    new Student
    {
        FirstName = "Bella",
        LastName = "Brown",
        Age = 23,
        GroupId = 6
    },
    new Student
    {
        FirstName = "Cody",
        LastName = "Clark",
        Age = 19,
        GroupId = 7
    },
    new Student
    {
        FirstName = "Diana",
        LastName = "Davis",
        Age = 24,
        GroupId = 8
    },
    new Student
    {
        FirstName = "Ethan",
        LastName = "Edwards",
        Age = 20,
        GroupId = 9
    }

    ];

var result = from g in groups
             join s in students on g.Id equals s.GroupId
             orderby s.FirstName
             select new
             {
                 FirstName = s.FirstName,
                 LastName = s.LastName,
                 Age = s.Age,
                 GroupName = g.Name,
                 Faculty = g.Faculty

             };
//foreach (var item in result)
//{
//    Console.WriteLine($"""
//        FirstName:  {item.FirstName}
//        LastName:   {item.LastName}
//        Age:        {item.Age}
//        GroupName:  {item.GroupName}
//        Faculty:    {item.Faculty}

//        """);
//}
Console.WriteLine();
//var groupByGroup = from i in result
//                   group i by i.GroupName;

//foreach (var group in groupByGroup)
//{
//    Console.WriteLine(group.Key);
//    Console.WriteLine();
//    foreach (var student in group)
//    {
//        Console.WriteLine($"""
//        FirstName:  {student.FirstName}
//        LastName:   {student.LastName}
//        Age:        {student.Age}
//        GroupName:  {student.GroupName}
//        Faculty:    {student.Faculty}

//        """);
//    }
//}

//var groupByFaculty = from i in result
//                   group i by i.Faculty;

//foreach (var faculty in groupByFaculty)
//{
//    Console.WriteLine(faculty.Key);
//    Console.WriteLine();
//    foreach (var student in faculty)
//    {
//        Console.WriteLine($"""
//        FirstName:  {student.FirstName}
//        LastName:   {student.LastName}
//        Age:        {student.Age}
//        GroupName:  {student.GroupName}
//        Faculty:    {student.Faculty}

//        """);
//    }
//}

var designers = from i in result
                where i.Faculty == "Design" && i.Age < 20
                select i;

foreach (var student in designers)
{
    Console.WriteLine($"""
        FirstName:  {student.FirstName}
        LastName:   {student.LastName}
        Age:        {student.Age}
        GroupName:  {student.GroupName}
        Faculty:    {student.Faculty}

        """);
}