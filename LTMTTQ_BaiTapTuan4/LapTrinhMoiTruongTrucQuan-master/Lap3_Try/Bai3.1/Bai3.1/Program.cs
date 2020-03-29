using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numerator, denominator; //So chia va so bi chia 123469926

            string strNumerator, strDenominator; //Cac xau luu gia tri nhap tu ban phim 
             try
             {
                 strNumerator = Console.ReadLine(); 
                 numerator = Convert.ToInt32(strNumerator);//quy123456  
                 strDenominator = Console.ReadLine();
                 denominator = Convert.ToInt32(strDenominator);


                 int result = numerator / denominator;


                 Console.WriteLine("Ket qua phep chia { 0} cho { 1} la { 2}"+ numerator + denominator + result);

             }
             //Bat su kien nguoi dung nhap sai dinh dang
             catch (FormatException ex)
             {
                 Console.WriteLine("Sai dinh dang dau vao " +ex.Message);
             }
             //Bat loi chia cho 0
             catch (DivideByZeroException ex)
             {
                 Console.WriteLine("Loi chia cho 0" +ex.Message);
             }
             //finally block
             {
                 Console.WriteLine("Thank you");
             }
            Console.Read();
        }
    }
}
