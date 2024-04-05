
namespace DesignPatterns.Singleton
{
    public class NoSingleton
    {
        public static string HashCode { get; private set; }
        public static void Print()
        {
            HashCode = new NoSingleton().GetHashCode().ToString();
        }
    }
}
