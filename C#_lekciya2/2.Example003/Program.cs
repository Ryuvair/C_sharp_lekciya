int [] array = {7,0,7,4,2,8,9,0,72};

int n = array.Length; // Определяет колличество элеменнтов масива (длину масива)
int  find = 0;

int index = 0;

while (index< n)
 {
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;

    }
    index++; // index = index + 1

} 