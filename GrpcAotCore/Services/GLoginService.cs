
using Grpc.Core;
using jwt.proto;

namespace jwt.Services
{
    public class GLoginService : Login.LoginBase
    {
        private readonly ILogger<GLoginService> _logger;
        public GLoginService(ILogger<GLoginService> logger)
        {
            _logger = logger;
        }


        public override Task<LoginResponse> DoLogin(User user, ServerCallContext context)
        {
            LoginResponse response = new LoginResponse();
            response.Ok = 1;
            return Task.FromResult(response);
        }

    }
}
