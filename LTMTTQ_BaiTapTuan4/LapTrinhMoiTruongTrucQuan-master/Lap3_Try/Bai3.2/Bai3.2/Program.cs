using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TH1: Trong exception duoc thuc hien
            Console.WriteLine("Goi phuong thuc DoesNotThrowException()");
            DoesNotThrowException();

            //TH2: Nem va bat ngoai le
            Console.WriteLine( "\nGoi phuong thuc ThrowExceptionWitchCatch()" );
            ThrowExceptionWithCatch();
            //TH3: Nem va khong bat ngoai le

            Console.WriteLine("\nGoi phuong thuc ThrowExceptionWithoutCatch()");
            try
            {
                ThrowExceptionWithoutCatch();
            }
            //Bat ngoai le tra ve tu ThrowExceptionWithoutCatch()
            catch
            {
                Console.WriteLine("Bat ngoai le tra ve tuThrowExceptionWithoutCatch() trong Main");
            }
            //TH4: Nem lai ngoai le
            Console.WriteLine("Goi ham ThrowExceptionCatchReThrow()");
            try
            {
                ThrowExceptionCatchReThrow();
            }
            //Bat ngoai le tra ve tu ThrowExceptionCatchReThrow
            catch
            {
                Console.WriteLine(" Bat ngoai le tu ThrowExceptionCatchReThrowtrong Main ");
            }
            Console.Read();
        }
        //Khong nem ngoai le
        public static void DoesNotThrowException()
        {
            //Try block khong nem ngoai le
            try
            {
                Console.WriteLine("Trong ham DoesNotThrowException()");
            }
            //catch block nay khong bao gio duoc thuc hien
            catch
            {
                Console.WriteLine("Khoi catch nay khong bao gio duoc thuc hien");
            }
        }
        //Nem va bat ngoai le
        public static void ThrowExceptionWithCatch()
        {
            try
            {
                Console.WriteLine("Trong ham ThrowExceptionWithCatch()");
                //Nem ngoai le
                throw new Exception("Ngoai le trong ThrowExceptionWitchCatch");
            }
            catch (Exception error)
            {
                Console.WriteLine("Message: " +error.Message);
            }
            finally
            {
                Console.WriteLine("Thuc hien khoi finally trongThrowExceptionWithCatch");
            }
            Console.WriteLine("Ket thuc phuong thuc ThrowExceptionWitchCatch()");
        }
        //Nem ngoai le nhung khong bat ngoai le
        public static void ThrowExceptionWithoutCatch()
        {
            try
            {
                Console.WriteLine("Trong phuong thuc ThrowExceptionWithoutCatch");
                throw new Exception("Nem ngoai le trongThrowExceptionWithoutCatch");
            }
            finally
            {
                Console.WriteLine("Thuc hien finally trongThrowExceptionWithoutCatch");
            }
            Console.WriteLine("Dong code nay se khong bao gio duoc thuc hien");
        }
        public static void ThrowExceptionCatchReThrow()
        {
            try
            {
                Console.WriteLine("Trong phuong thuc ThrowExceptionCatchReThrow");
                throw new Exception("Ngoai le trong ThrowExceptionCatchReThrow");

            }
            catch (Exception error)
            {
                Console.WriteLine("Message: " +error.Message);
                throw error;
                Console.WriteLine("Dong nay se khong duoc in");
            }
            finally
            {
                Console.WriteLine("Thuc hien finally trongThrowExceptionCatchRethrow()");
            }
            Console.WriteLine("Dong nay se khong duoc in");
        }
    }
}
