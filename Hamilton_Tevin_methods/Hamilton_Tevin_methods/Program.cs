using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tevin Hamilton
             * Methods 
             * 05/14/2018
             * */
            Console.Clear();
            //Problem 1
            Console.WriteLine("please enter your weight\r\n");
            string userWeightString = Console.ReadLine();
            double userWeight;
            while (!(double.TryParse(userWeightString, out userWeight)))
            {
                Console.WriteLine("please only enter a numbers\r\nplease enter your weight\r\n");
                userWeightString = Console.ReadLine();
            }
            double spaceCadet = MoonMan(userWeight);
            Console.WriteLine($"\r\nOn Earth you weight is {userWeight}lbs, but on the moon you would only weigh {spaceCadet}lbs.\r\n");
            /*TEST TEST TEST 
             * test 1 (user input 160 = 26.6666666666667)
             * test 2(user input 210 = 35)
             * test 3 (user input one hundred pounds = re-prompting the user )
             * test 4 (user input 122 =20.3333333333)
             * */


            //Problem 2 
            Console.WriteLine("\r\nWhats the Price for item 1\r\n");
            string item1String = Console.ReadLine();
            decimal item1;
            while(!(decimal.TryParse(item1String,out item1)))
            {
                Console.WriteLine("please enter only numbers\r\nwhats the price of item 1\r\n");
                item1String = Console.ReadLine();
            }
            Console.WriteLine("\r\nWhats the Price for item 2\r\n");
            string item2String = Console.ReadLine();
            decimal item2;
            while (!(decimal.TryParse(item2String, out item2)))
            {
                Console.WriteLine("please enter only numbers\r\nwhats the price of item 2\r\n");
                item1String = Console.ReadLine();
            }
            Console.WriteLine("\r\nWhats is the discount your applying\r\n");
            string discountString = Console.ReadLine();
            decimal discount;
            while (!(decimal.TryParse(discountString, out discount)))
            {
                Console.WriteLine("please enter only numbers\r\nWhats is the discount your applying.]\r\n");
                item1String = Console.ReadLine();
            }
            decimal discountCal = StoreDiscount(item1, item2, discount);
            Console.WriteLine($"\r\nwith a discount of {discount}%, your total with the discount would be {discountCal.ToString("c")}\r\n");
            /*TEST TEST TEST 
             * TEST 1(user input item 1 10.00 item 2 discount 20 = $20.40)
             * test 2 (user input 1 item  20.25 item 2 37.75 discount 10 = $52.20 )
             * test 3 (user input item1 100 item2 46.89 discount 45 = 80.79 (100+ 46.89 = 146.89 | 146.89 * .45 = 66.1005 |146.89 - 66.10 = $80.79))
             * */

            //problem 3
            int[] numsArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] newNumsArray = DoubleTheFun(numsArray);
            Console.WriteLine("your first set of arrays was\r\n");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine("\r\nhere are your array doubled\r\n");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(newNumsArray[i]);
            }
            

        }
        public static double MoonMan(double uw)
        {           
            double convertedWeight =  uw/6;
            return convertedWeight;
        }
        public static decimal StoreDiscount(decimal i1,decimal i2, decimal d)
        {
            decimal itemSum = i1 + i2;
            decimal dis = d / 100;
            decimal disSub = dis * itemSum;
            decimal itemTotal = itemSum - disSub;
            return itemTotal;
        }
        public static int[] DoubleTheFun(int[] na)
        {
            int[] array = new int[na.Length];
            for (int i = 0; i < na.Length; i++)
            {
                array[i] = na[i] * 2;
            }
            return array;
        }
    }
}
