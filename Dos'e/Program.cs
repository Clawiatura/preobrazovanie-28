Console.Write("Как вас зовут? ");
string name = Console.ReadLine();

Console.Write("Ваша фамилия? ");
string surname = Console.ReadLine();

Console.Write("Ваш возраст? ");
int age = int.Parse(Console.ReadLine());

Console.Write("Вы работаете? ");
string job = Console.ReadLine();

Console.Write("Вы женаты? ");
string wife = Console.ReadLine();

string finish = $"\t\t\tДосье\n\n\nИмя\tФамилия\t\tВозраст\tРабота\tЖенаты\n{name}\t{surname}\t{age}\t{job}\t{wife}\a";

Console.WriteLine(finish);


