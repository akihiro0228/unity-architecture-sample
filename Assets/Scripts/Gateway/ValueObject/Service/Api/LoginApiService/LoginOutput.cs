namespace Gateway.ValueObject.Service.Api.LoginApiService
{
    public class LoginOutput
    {
        public string PlayerName { get; }

        public LoginOutput(string playerName)
        {
            PlayerName = playerName;
        }
    }
}
