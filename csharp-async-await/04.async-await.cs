using System;
using System.Threading.Tasks;

namespace Examples.AdvancedProgramming.AsynchronousOperations
{
    public class ForAsync
    {
        public async void ToWauitMe(int amount, string nonMount)
        {
            Console.WriteLine(amount);
            Console.WriteLine(amount + amount);
            Console.WriteLine(amount + amount + amount);
            int result = await MyNonSyncMethod();
            Console.WriteLine(result);

            int result2 = await MyNonSyncMethod2(amount);
            Console.WriteLine(result2);

            int result3 = await MyNonSyncMethod2(amount + amount);
            Console.WriteLine(result3);
        }

        private Task<int> MyNonSyncMethod()
        {
            return Task.FromResult(5);
        }

        private Task<int> MyNonSyncMethod2(int er)
        {
            return Task.FromResult(er + er);
        }
    }
}