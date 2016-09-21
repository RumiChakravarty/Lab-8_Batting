using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Batting
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Batting Average Calculator!\n");
            string doYouWantToRepeat="";
            do
            {
                Console.Write("Enter number of time at bat:");
                int numberOfTime = int.Parse(Console.ReadLine());
               // int[] batting;
               //if (numberOfTime < 0 || numberOfTime > 5)
                //{
                //    Console.WriteLine("Please enter a value 1,2,3,4,5");
                //}
                //else
                //{
                   int[] batting = new int[numberOfTime];
                    Console.WriteLine("0=out, 1=single, 2=double, 3=triple, 4=home run");
                    for (int i = 0; i < numberOfTime; i++)
                    {
                        Console.Write($"Result for at-bat {i}: ");
                        batting[i] = int.Parse(Console.ReadLine());
                    if (batting[i] > 4)
                    {
                        Console.WriteLine("Please enter only 0 or 1 or 2 or 3 or 4 ");
                        i--;

                    }

                }
                    Console.WriteLine("\nBatting average:" + CalculateBattingAverage(batting));
                    Console.WriteLine("Slugging Percentage :" + CalculateSluggingPercentage(batting));
                    Console.WriteLine("Another Batter?(y/n)");
                    doYouWantToRepeat = Console.ReadLine();
               // }
            } while (doYouWantToRepeat == "y");
           

          

        }

        public static double CalculateBattingAverage(int[] battingSheet)
        {
            double average=0.0;
            int  oneBase=0;
            int length = battingSheet.Length;
            for (int i=0; i<length; i++)
            {
                if(battingSheet[i]>0)
                {
                    oneBase++;
                }
                //if (battingSheet[i] == 0)
                //{
                //    oneBase = oneBase + 0;
                //}
                //else
                //{
                //    oneBase = oneBase + 1;
                //}
            }
            average = ((double) oneBase) / length;
            return Math.Round(average,3);
        }

        public static double CalculateSluggingPercentage(int[] battingSheet)
        {
            int battingRun = 0;
            for (int i = 0; i < battingSheet.Length; i++)
            {
                battingRun = battingRun + battingSheet[i];
            }
            double sluggingAverage = ((double)battingRun) / battingSheet.Length;
            return Math.Round(sluggingAverage,3);

        }
    }
}
