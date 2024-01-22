const  double P =  Math.PI;
Console.WriteLine("Введите радиус окружности");
float r = float.Parse(Console.ReadLine());
Console.WriteLine("Введите формулу радиуса окружности и производящую просчет площади круга");
string formuls = Console.ReadLine();

string finish = $"S={P*(r*r):F2}";
Console.WriteLine(finish);

