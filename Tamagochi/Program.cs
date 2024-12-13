using Tamagochi;

var cat = new Cat();
var who = cat.Whoami();
Console.WriteLine(who);
cat.Feed();
cat.Play ();
cat.Play();
cat.Play ();
cat.Feed ();
cat.Play ();
cat.Feed();
Console.WriteLine(cat.Hunger);
Console.WriteLine(cat.Boredom);
Console.WriteLine(cat.isAlive() ? "žije" : "nežije");


