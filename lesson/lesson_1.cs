
Console.WriteLine("Hello, мир");

//переменные
string name = "Tom";  // определяем переменную и инициализируем ее
int a=18;
bool alive = true;
byte bit2 = 102; // от 0 до 255 и занимает 1 байт.
sbyte bit1 = -101; //от -128 до 127 и занимает 1 байт.
char a = 'A'; //Unicode и занимает 2 байта

//может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе. 
object a = 22;
object b = 3.14;
object c = "hello code";
//

Console.WriteLine("name:"+name+ " \n a:"+a);    // Tom
Console.WriteLine($"Имя: {name}  Возраст: {a} ");
Console.WriteLine(0xFF);    // 255


//ввод
/*
Console.Write("Введите имя: ");
string name = Console.ReadLine();

Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());//Convert.ToDouble()
Console.WriteLine($"Имя: {name}  Возраст: {age}");
*/


int num1 = 8;
int num2 = 6;
if(num1 > num2){

    Console.WriteLine($"Число {num1} больше числа {num2}");
}



for (int i = 1; i < 4; i++)
{
    Console.WriteLine(i);
}

//Цикл foreach предназначен для перебора набора или коллекции элементов.
foreach(char c in "TomPee")
{
    
    if(c=='o') continue;
    if(c=='P') break;

    Console.WriteLine(c);
}
Console.WriteLine("\n");

int[] nums2 = new int[4] { 1, 2, 3, 5 };
int[] numbers = { 1, 2, 3, 5 };
Console.WriteLine(numbers.Length+"\n");  // 4

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach (int i in numbers)
{
    Console.WriteLine(i);
}
Console.WriteLine("\n");



//многомерная 
int[,] numbers2 = { { 1, 2, 3 }, { 4, 5, 6 }}; 
int rows = numbers2.GetUpperBound(0) + 1;    // количество строк
int columns = numbers2.Length / rows;        // количество столбцов
// или так
// int columns = numbers.GetUpperBound(1) + 1;
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numbers2[i, j]} \t");
    }
    Console.WriteLine();
}

//-------------------------------------------------------
void PrintPerson(string n, int a, int c=90)
{
    Console.WriteLine($"Name: {n}  Age: {a}");
}
//PrintPerson("Tom", a:24); // Name: Tom  Age: 24



//ref типо передача по ссылке 
//in типо ref но нельзя изменить значение
void Increment(ref int n, in int a)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

//используя ключевое слово params, мы можем передавать неопределенное количество параметров
void Sum(params int[]  numbers)
{
    int result = 0;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}
 
int[] nums = { 1, 2, 3, 4, 5};
//Sum(nums);
//Sum(1, 2, 3, 4);
//Sum(1, 2, 3);
//Sum();



enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}

DayTime dayTime = DayTime.Morning;