// delegate is an object wich can be used as a pointer to a Method;

//  it can also use as the parametr for other methods;

//Test

int[] myArray = { 3, 5, 8, 12, 15, 32, 20 };

static int Max(int a, int b)
{
    return Math.Max(a, b);
}

static int Min(int a, int b)
{
    return Math.Min(a, b);
}

static bool IsEven(int a)
{
    return a % 2 == 0;
}

static bool IsOdd(int a)
{
    return a % 2 == 1;
}


IsEvenOrOddDelegate IsEvenDel = IsEven;
IsEvenOrOddDelegate IsOddDel = IsOdd;

MinMaxDelegate MaxDel = Max;
MinMaxDelegate MinDel = Min;

Min(20, 10);        // as you can see both show the same Method  
MinDel(20, 10);     //

static List<int> FilterArray(int[] array, IsEvenOrOddDelegate evenOrOdd)
{
    List<int> resault = new List<int>();
    foreach (var item in array) 
    {
        if(evenOrOdd(item))
            resault.Add(item);
    }
    return resault;
}

var resualt = FilterArray(myArray, IsEvenDel);
foreach (var item in resualt)
{
    Console.WriteLine(item);
}

public delegate int MinMaxDelegate(int a, int b);       // this delegate can only see methods with the same
                                                        // parameters and return type !
public delegate bool IsEvenOrOddDelegate(int a);