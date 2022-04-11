// See https://aka.ms/new-console-template for more information
using Handlers;
using Models;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var utility = new Utility();

            utility.Max<int>(2, 10);
            utility.Max<char>('r', 'a');
            utility.Max<string>("salman", "taj");
        }
    }
}
