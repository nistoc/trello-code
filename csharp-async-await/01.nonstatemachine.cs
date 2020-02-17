using System;
using System.Threading.Tasks;

namespace Examples.AdvancedProgramming.AsynchronousOperations
{
    public class ForAsync
    {
        public Task ToWauitMe(int amount, string nonMount)
        {
           return MyNonSyncMethod2(amount + amount);
        }

        private Task<int> MyNonSyncMethod2(int er)
        {
            return Task.FromResult(er + er);
        }
    }
}