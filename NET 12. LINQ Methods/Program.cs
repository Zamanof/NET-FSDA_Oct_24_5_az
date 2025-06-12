// LINQ Methods
// https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/introduction-to-linq-queries
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
        Age = 25,
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
        Age = 105,
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

#region First, FirstOrDefault
//var stud = students.First();
//Console.WriteLine(stud);

//var student1 = students.First(s => s.GroupId == 12);
//Console.WriteLine(student1);

//var student2 = students.FirstOrDefault(s => s.GroupId == 9);
//if(student2 is not null) Console.WriteLine(student2);
//else Console.WriteLine("Student not found");

#endregion

#region Single, SingleOrDefault

//var stud = students.Single(s=>s.Age == 105);
//Console.WriteLine(stud);

//var stud2 = students.SingleOrDefault(s => s.Age == 102);
//if (stud2 is not null) Console.WriteLine(stud2);
//else Console.WriteLine("Student not found");

#endregion

#region Contains
//var student = new Student
//{
//    FirstName = "Nadir",
//    LastName = "Zamanov",
//    Age = 45,
//    GroupId = 4
//};
//Console.WriteLine(students.Contains(student));
//students.Add(student);
//Console.WriteLine(students.Contains(student));
#endregion

#region Where
//var result = students.Where(s => s.Age > 35);
///*
// var result =  from i in students
//               where i.Age > 50
//               select i; 
// */
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//var student = new Student
//{
//    FirstName = "Nadir",
//    LastName = "Zamanov",
//    Age = 45,
//    GroupId = 4
//};
//Console.WriteLine();
//students.Add(student);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Min, Max, Average, Sum

//var minResult = students.Min(s => s.Age);
//Console.WriteLine(minResult);

//var maxResult = students.Max(s => s.Age);
//Console.WriteLine(maxResult);

//var average = students.Average(s => s.Age);
//Console.WriteLine(average);

//var summ = students.Sum(s => s.Age);
//Console.WriteLine(summ);
//Console.WriteLine(summ / (double)students.Count);

#endregion

#region OrderBy, OrderByDescending, ThenBy, ThenByDescending

//var studs = students.OrderBy(s => s.Age).ToList();
//studs.ForEach(Console.WriteLine);

//var studDesc = students.OrderByDescending(s => s.Age).ToList();
//studDesc.ForEach(Console.WriteLine);

//var studs2 = students.OrderBy(s => s.Age).ThenByDescending(s=>s.FirstName).ToList();
//studs2.ForEach(Console.WriteLine);

#endregion

#region Count
//var count = students.Count(s=> s.Age == 24);
//Console.WriteLine(count);
#endregion

#region Take, Skip, TakeLast, SkipLast, SkipWhile, TakeWhile
//var studs = students.Skip(3).Take(3).ToList();

//studs.ForEach(Console.WriteLine);

var studs2 = students.TakeWhile(s => s.Age < 35).ToList();
studs2.ForEach(Console.WriteLine);

#endregion

#region All, Any
//var check = students.All(s => s.Age > 35);
//Console.WriteLine(check);

//var checkAny = students.Any(s => s.Age > 35);
//Console.WriteLine(checkAny);
#endregion

#region Join, GroupJoin
//var result = groups.Join(students, 
//                            g => g.Id, 
//                            s => s.GroupId,
//                            (g, s)=> new
//                            {
//                                FirstName =s.FirstName,
//                                LastName = s.LastName,
//                                Age =s.Age,
//                                GroupName = g.Name
//                            });

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age} - {item.GroupName}");
//}

//var resultGroup = groups.GroupJoin(students,
//                                   g => g.Id,
//                                   s => s.GroupId,
//                                   (g, s) => new
//                                   {
//                                       GroupName = g.Name,
//                                       Students = s
//                                   });

//foreach (var group in resultGroup)
//{
//    Console.WriteLine(group.GroupName);
//    foreach (var student in group.Students)
//    {
//        Console.WriteLine($"\t{student.FirstName} {student.LastName} {student.Age}");
//    }
//}

#endregion