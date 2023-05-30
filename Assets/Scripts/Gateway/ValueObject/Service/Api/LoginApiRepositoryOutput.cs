namespace Gateway.ValueObject.Service.Api
{
    public class LoginApiServiceOutput
    {
        public string PlayerName { get; }

        public LoginApiServiceOutput(string playerName)
        {
            PlayerName = playerName;
        }
    }
}
