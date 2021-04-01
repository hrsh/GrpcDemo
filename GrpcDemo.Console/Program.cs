using Grpc.Net.Client;
using GrpcDemo.Server;
using System.Threading.Tasks;

namespace GrpcDemo.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //System.Console.Write("What is your name? ");
            //var name = System.Console.ReadLine();
            //using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Greeter.GreeterClient(channel);
            //var reply = await client.SayHelloAsync(new HelloRequest
            //{
            //    Name = name
            //});
            //System.Console.WriteLine(reply.Message);

            System.Console.Write("Enter book id: ");
            var id = int.Parse(System.Console.ReadLine());
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new BookStore.BookStoreClient(channel);
            var book = await client.GetBookByIdAsync(new BookRequest
            {
                BookId = id
            });
            System.Console.WriteLine($"Id: {book.Id}\nTitle: {book.Title}");

            System.Console.ReadLine();
        }
    }
}
