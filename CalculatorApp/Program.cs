using CalculatorServer;
using Grpc.Net.Client;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var channel = GrpcChannel.ForAddress("https://localhost:7025/");
            var client = new Calculator.CalculatorClient(channel);
            var calculatorResponse = client.Add(new CalculatorRequest()
            {
                Num1 = 1,
                Num2 = 2,
            });
            Console.WriteLine($"The sum is : {calculatorResponse.Result}");
            Console.ReadKey();
        }
    }
}