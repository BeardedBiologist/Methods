using Methods;

//string name = ConsoleMessages.GetUsersName();

//ConsoleMessages.SayHi(name);


//MathShortcuts.Add(4, 5);

//double[] vals = new double[] { 2, 5, 6, 9, 55, 34, 5 };
//MathShortcuts.AddAll(vals);


//ConsoleMessages.SayGoodybe();

(string, string) fullname = ConsoleMessages.GetFullName();

Console.WriteLine($"First Name: {fullname.Item1}");
Console.WriteLine($"Last Name: {fullname.Item2}");
