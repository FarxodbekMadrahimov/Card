namespace Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uzcard uzcard = new Uzcard(7777, "Farxodbek", 100000);
            var money = uzcard.AddWithBonus(15000);
            Console.WriteLine(uzcard.Pay(100000));

            Humo humo = new Humo(7777, "Farxod", 50000);
            Console.WriteLine(humo.PayWireless(51000));
        }
    }
}