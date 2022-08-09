using State.Concrete;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            ModifiedState modifiedState = new ModifiedState();

            modifiedState.Entry(context);

            Console.WriteLine("State of Context: {0}",context.GetState().ToString());

        }
    }
}