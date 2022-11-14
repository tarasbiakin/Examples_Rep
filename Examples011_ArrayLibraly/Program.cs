﻿void FillArray(int[] collection ){
    int length = collection.Length;
    int index = 0;
    while(index<length){

        collection[index] = new Random().Next(1,10);
        index++;
    }

}
void PrintArray (int[] col){
    int count = col.Length;
    int position = 0;
    while(position<count){
        Console.WriteLine($"Значение позиции " + position+" в массиве "+"=" + col[position]);
        position++;
        
    }
}
int IndexOf(int[] collection, int find){
   int count = collection.Length;
   int index = 0;
   int position = -1;
   while (index<count){
    if(collection[index]==find){
        position = index;
        break;
    }
    index++;
   }
   return position;
}


int[] array = new int[10];

FillArray(array);
array[4]=4;
array[1]=4;
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 44);
System.Console.WriteLine("Искомое число на позиции " +pos);