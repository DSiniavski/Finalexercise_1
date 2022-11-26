string[] array;
Console.WriteLine("Enter elements separated by a space ");
string userenter = Console.ReadLine()??"";
array = userenter.Split(' ');
            
string[] sortedarray = ChooseShortString(array);

PrintArray(array);
PrintResult(sortedarray);

string[] ChooseShortString(string[] array)
  {
       
   string[] result = new string[array.Length];
    int  newindex = 0;
    int maxlenght = 3;
    for (int i = 0; i < array.Length; i++ )
    {
      if (array[i].Length <= maxlenght)
      {
      result[newindex] = array[i];
      newindex++;
      }
     }
     Array.Resize(ref result, newindex);
    return result;
  }
  

  void PrintArray(string[] array)
  {
    Console.Write ($"[ ");
      for(int i = 0; i < array.Length-1; i++) 
      Console.Write ($"{array[i]}, ");
        Console.Write ($"{array[array.Length-1]}] -> ");
  }
  
  void PrintResult(string[] sortrdarray)
  {
    
    if (sortedarray.Length  == 0)
     {
      Console.Write ($"[]");
     }
     else
     {
      Console.Write ($"[ ");
      for (int j =0; j < sortedarray.Length-1; j++)

      Console.Write($"{sortedarray[j]}, ");
      Console.Write ($"{sortedarray[sortedarray.Length-1]}]");
     }
   
  }
