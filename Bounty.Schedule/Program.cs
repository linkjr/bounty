using System;
using System.Threading.Tasks;

namespace Bounty.Schedule
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //await new MiniProgram().GetToken();
            //await new MiniProgram().Code2Session();
            await new MiniProgram().SendTemplateMessage();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
