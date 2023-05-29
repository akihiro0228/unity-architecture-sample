namespace Domain.ValueObject.Repository.Api
{
    public struct LoginOutput
    {
        public string PlayerName { get; private set; }

        public LoginOutput(string playerName)
        {
            PlayerName = playerName;
        }
    }
}
