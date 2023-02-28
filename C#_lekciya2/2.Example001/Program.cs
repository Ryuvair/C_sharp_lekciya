int Max(int arg1, int arg2, int arg3)
{
     int result = arg1;
     if (arg2 > result) result = arg2;
     if (arg3 > result) result = arg3;
     return result;
}
int a = 10;
int b = 2;
int c = 6;
int d = 8;
int e = 9; 
int a2 = 8;
int b2 = 13;
int c2 = 21;
int d2 = 3;

//int max1 = Max (a, b, c);
//int max2 = Max (d, e, a2);
//int max3 = Max (b2, c2, d2);

int max = Max(
    Max (a, b, c),
    Max (d, e, a2),
    Max (b2, c2, d2));
 

Console.Write("max=");
Console.WriteLine(max);
