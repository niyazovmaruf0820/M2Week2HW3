using task4;

Actor actor = new Actor("Jeison Steitim", 30, "male");
actor.SetName("Jeison Steitim");
System.Console.WriteLine("Actor's Name: " + actor.GetName());
actor.SetAge(30);
System.Console.WriteLine("Age: " + actor.GetAge());
actor.SetGender("male");
System.Console.WriteLine("Gender: " + actor.GetGender());
actor.AddMovie("Iron Man");
actor.AddMovie("Avengers: Endgame");
actor.AddMovie("Sherlock Holmes");
System.Console.WriteLine("Movies Played by Robert Downey Jr.:");
actor.GetMoviesPlayed();