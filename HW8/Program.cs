void Zadacha54()
        //Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

        {
        Random random = new Random();
        int rows = 3;
        int columns = 4;
               
        int [,] numbers = new int[rows, columns];

        FillArray(numbers);
        PrintArray(numbers);
        SortingArray(numbers);
        Console.WriteLine();
        PrintArray(numbers);
        
        
            
            void FillArray (int[,] num)
            {
            for (int i = 0; i < rows; i++)
            {
                Random random = new Random();
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.Next(0, 10);
                }
            }
            }
            void PrintArray (int[,] num)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(numbers[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            
            void SortingArray (int[,] num)
            {
         
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int max = 0; max < columns - 1; max++)
                    {
                        if (num[i, max] < num[i, max + 1])
                        {
                            int temp = num[i, max + 1];
                            num[i, max + 1] = num[i, max];
                            num[i, max] = temp;
                        }
                    }
                }
       
            }

            }

        }

void Zadacha56()
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        {
           
        Random random = new Random();
        int rows = 5;
        int columns = 4;
               
        int [,] numbers = new int[rows, columns];

        FillArray(numbers);
        PrintArray(numbers);
        Console.WriteLine();
        Minrow(numbers);
        
            
            void FillArray (int[,] num)
            {
            for (int i = 0; i < rows; i++)
            {
                Random random = new Random();
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = random.Next(0, 10);
                }
            }
            }
            void PrintArray (int[,] num)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(numbers[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            } 

            void Minrow (int[,] num)
            {
            int[] sum = new int [rows];
            
                for (int i = 0; i < rows; i++)
                {
                    int sumrow = 0;
                    for (int j = 0; j < columns; j++)
                    {
                        sumrow = sumrow + num[i, j];           
                    }
                    sum[i] = sumrow;   
                    //Console.Write(sum[i] + "\t");
                }

                int indexMin = 0;
                int min = sum[0];
                for (int i = 1; i < rows; i++)
                {
                
                    if (min > sum[i])
                    {
                    min = sum[i];
                    indexMin = i;
                    
                    }
                
                }
                
                Console.WriteLine($"Минимальная строка: {indexMin + 1}"); 
 
        }
        }
        
Zadacha56();