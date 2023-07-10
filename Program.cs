
int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GenerateArray2DDD(int rows, int columns,int min, int max)
{
    
    int [,] numbers = new int [rows, columns];
    Random rnd = new Random ();
    
    for (int i = 0; i <numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers[i,j] = rnd.Next (min,max +1) ;
           
           
        }
        
    }

    
    
    return numbers;
}


int Poisk(int[,] numbers)
{
    int min = 100;
    int v=0;
    int num = 0;
 for (int i = 0; i <numbers.GetLength(0); i++)
    {
        num=0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           num=num+numbers[i,j];
           
           
        }
        if (num<min)
        {
            min = num;
            v=i;
        }
    }

    System.Console.WriteLine($"минимальная строка -> {v+1}");
     System.Console.WriteLine($"минимальная сумма -> {min}");
    return 0;

}






   
void PrintArray2Dd(int [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
          System.Console.Write($"{numbers[i,j]}\t"); 
         }
System.Console.WriteLine();
 }
    System.Console.WriteLine();
    }
 
   
   
    int[,] array = GenerateArray2DDD(4,4,0,12);



PrintArray2Dd(array);
Poisk(array);



