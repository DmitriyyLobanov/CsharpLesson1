int a = 2;
int b = 1;
int c = 4;
int d = 8;
int e = 5;

int max = a;

if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.WriteLine($"max = {max}.");
