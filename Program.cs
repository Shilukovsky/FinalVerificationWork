string[] array = {"hello", "2", "world", ":-)"};

int NewSize(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            size++;
        }
    }
    return size;
}

string[] NewArray(string[] array, int size)
{
    string[] newarray = new string[size];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i].Length <= 3) 
        {
            newarray[count] = array[i]; 
            count++;
        }         
    }
    return newarray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
PrintArray(array);
Console.Write(" -> ");
int newsize = NewSize(array);
string[] newarr = NewArray(array, newsize);
if (newsize > 0) 
PrintArray(newarr);
else 
Console.Write("[]");



