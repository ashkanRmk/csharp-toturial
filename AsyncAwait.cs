using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    /*
    Asynchronous Programming Sample:
        Buy a product steps:
        1) update product quantity in database
        2) send sms to customer
        3) send sms to seller
    */
    class Program
    {
        static async Task Main(string[] args)
        {
            // Async / Await
            var watch = new Stopwatch();
            watch.Start();
            var result = await UpdateProductInDatabase();  //1
            // SendSmsToCustomer();        //2
            // SendSmsToSeller();          //2

            Task.WaitAll(SendSmsToCustomer(),
                    SendSmsToSeller());

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds + " ms");
        }

        public static async Task<int> UpdateProductInDatabase()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Product UPDATED!");
            });
            return 10;
        }

        public static async Task SendSmsToCustomer()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("SMS to customer send!");
            });
        }

        public static async Task SendSmsToSeller()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("SMS to seller send!");
            });
        }
    }
}
