using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = Singleton<Greeter>.Instance;
            greeter.SayHiToTheWorld();

            



        }
    }
}
