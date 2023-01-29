// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо
// равна трем символам.

string[] TruncateMassive(string[] Massive)
{
    string[] arr = new string[Massive.Length];

    int j=0;
    for (int i = 0; i < Massive.Length; i++)
    {
         if (Massive[i].Length<4)
         {
            arr[j] = Massive[i];
            j++;
         }  
    }
    Array.Resize(ref arr , j);
    return arr;
}

string[] CreateMassive(int count)
{
    string[] arr = new string[count];
    arr[0]="day";
    arr[1]="4251";
    arr[2]="birthday";
    arr[3]=":)";
    arr[4]="no";
    return arr;
}

// Задать массив заполненный строками
string[] array = CreateMassive(5);
// определить длину строки
// создать второй массив
string[] NewArray = TruncateMassive(array);
Console.WriteLine("["+ String.Join(", ", array) + "]->[" + String.Join (", ", NewArray)+ "]");
