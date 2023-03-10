using Methods;

Console.Write("What is your name?: ");
string name = Console.ReadLine();

SampleMethods.SayHi(name);


MathShortcuts.Add(4, 5);

double[] vals = new double[] { 2, 5, 6, 9, 55, 34, 5 };
MathShortcuts.AddAll(vals);


SampleMethods.SayGoodybe();