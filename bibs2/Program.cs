using System;
using System.IO;
using System.Text;

namespace bibs2
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultpath = @"C:\Users\lowel\source\repos\bibs2\bibs2\bin\Debug\netcoreapp3.1\numberres";
            int result = 0;
            int count = 0;
            try
            {
                
                using (StreamReader sr = new StreamReader("Numbers.txt"))
                {
                    string line;
                 
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        {
                            string[] inputString = line.Split(' ');
                            int[] intArray = new int[inputString.Length];

                            for (int i = 0; i < inputString.Length; i++)
                            {
                                intArray[i] = int.Parse(inputString[i]);
                                
                            }

                            if (count > 2)
                            {

                                for (int i = 0; i < 2; i++)
                                {
                                    result += intArray[i];

                                }

                                
                                
                            }
                            count++;
                        }
                      
                    }
                    Console.WriteLine(result);
                }
                File.WriteAllTextAsync(resultpath, result.ToString());
            }
            catch (Exception e)
            {
               
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
