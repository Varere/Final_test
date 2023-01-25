Console.WriteLine("Введите размер исходного массива");
int size = int.Parse(Console.ReadLine()!);

string[] firstArr = new string[size];
string[] finalArr = new string[size];
int count = 0;
for (int i = 0; i < size; i++) {
    Console.WriteLine("Введите элемент массива");
    firstArr[i] = Console.ReadLine()!;
    if (firstArr[i].Length <= 3) {
        finalArr[count] = firstArr[i];
        count++;
    }
}

if(count == 0) {
    Console.WriteLine("[]");
} else {
    Array.Resize(ref finalArr, count);
    Console.WriteLine(finalArr.Length);
    PrintArray(finalArr);
}

void PrintArray (string[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) {
            Console.Write("<" + arr[i] + ">,");
        } else {
            Console.Write("<" + arr[i] + ">");
        }
    }
    Console.WriteLine("]");
}