namespace DesignPatterns.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Singleton & NoSingleton
            //No Singleton mean getting instance directly through default constructor using new operator
            NoSingleton noSingletonInstance = new NoSingleton();
            Console.WriteLine("=================================================================");
            Singleton SingletonInstance = Singleton.GetInstance();
            #region Threading-Safe Singleton
            ThreadSafeSingleton threadSafeInstance = ThreadSafeSingleton.GetInstance();
            #endregion
            #endregion


        }
    }
}
