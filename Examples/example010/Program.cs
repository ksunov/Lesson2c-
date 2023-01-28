int[] array = { 18, 26, 33, 4, 95, 76, 57, 18};

int n = array.Length;
int find = 18;

int index = 0;
while (index<n)

{

    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}