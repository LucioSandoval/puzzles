// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int[] RandomArray(){
    
    int[] array = new int[10];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(5, 25);
    }
    return array;
}
int[] randomArray = RandomArray();
int min = randomArray.Min();
int max = randomArray.Max();
int sum = randomArray.Sum();
Console.WriteLine("Matriz Aleatoria -------------------------------");
foreach (int num in randomArray)
{
    Console.WriteLine(num);
}

Console.WriteLine("Valores mínimos: " + min);
Console.WriteLine("Valores máximos: " + max);
Console.WriteLine("Suma de los valores: " + sum);

Console.WriteLine("Lanzamiento de Moneda -------------------------------");
static string TossCoin(){
    Console.WriteLine("¡Tirando una moneda!");
    Random random = new Random();
    int toss = random.Next(0, 2);

    return toss == 0 ? "Cara": "Cruz";
}
Console.WriteLine(TossCoin());
Console.WriteLine("Nombres -------------------------------");
static List<string> Nombres()
{
    List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
    List<string> longNames = new List<string>();

    foreach (string name in names)
    {
        if (name.Length > 5)
        {
            longNames.Add(name);
        }
    }

    return longNames;
}

List<string> names = Nombres();
foreach (string name in names)
{
    Console.WriteLine(name);
}