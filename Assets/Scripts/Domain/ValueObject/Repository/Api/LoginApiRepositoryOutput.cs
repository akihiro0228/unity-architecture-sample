namespace Domain.ValueObject.Repository.Api
{
    public class LoginApiRepositoryOutput
    {
        public string PlayerName { get; }

        public LoginApiRepositoryOutput(string playerName)
        {
            PlayerName = playerName;
        }
    }
}
