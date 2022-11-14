int[] array = {81,3,3,24,35,16,7,88};

int n = array.Length;
int find = 3;
int index = 0;
while(index<n){
    if(array[index]==find){
        Console.WriteLine($"Номер в массиве: " + index);
        break;
    }
    index++;
}

