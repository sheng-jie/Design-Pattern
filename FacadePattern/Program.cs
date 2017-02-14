namespace FacadePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var atm = new ATM();
            atm.DisplayUi();
        }
    }
}