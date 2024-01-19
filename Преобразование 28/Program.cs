string a = "28";
byte c = byte.Parse(a);
nint d = (nint)c;
int f = (int)d;
long s = (long)f;
double z = (double)s;

Console.WriteLine($"{a} {c} {d} {f} {s} {z}");

