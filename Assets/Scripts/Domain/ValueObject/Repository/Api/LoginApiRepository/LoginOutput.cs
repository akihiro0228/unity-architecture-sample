namespace Domain.ValueObject.Repository.Api.LoginApiRepository
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
