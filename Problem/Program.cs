
namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer producer = new(10,10,10);
            Shop shop = new(5,3,4);

            shop.BuyAllFruitsFromProducer(producer);

            Client firstClient = new() { Name="Client 1"};
            Client secondClient = new() { Name="Client 2"};

            firstClient.BuyFruitsFromShop(2,3,4,shop);
            secondClient.BuyFruitsFromShop(3, 2, 1, shop);

            producer.ViewResults();
            shop.ViewResults();
            firstClient.ViewResults();
            secondClient.ViewResults();
        }
    }
}
