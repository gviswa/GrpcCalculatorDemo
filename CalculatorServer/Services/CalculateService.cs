using Grpc.Core;

namespace CalculatorServer.Services
{
    public class CalculateService : Calculator.CalculatorBase
    {
        public override Task<CalculatorResponse> Add(CalculatorRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CalculatorResponse()
            {
                Result = request.Num1 + request.Num2
            });
        }
    }
}
