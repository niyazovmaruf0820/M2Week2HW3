using task1;

Teacher teacher = new Teacher("Akmal Shodiev", "Fizra", 15);
teacher.SetExperience(15);
System.Console.WriteLine(teacher.Teach());
System.Console.WriteLine(teacher.GetExperience());