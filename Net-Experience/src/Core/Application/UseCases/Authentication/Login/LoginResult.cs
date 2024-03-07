namespace Net.Experience.Application.UseCases.Authentication.Login
{
    public class  LoginResult
    {
        public string Menssage { get; set; }
        public string Token { get; set; }

        public LoginResult(string message, string token)
        {
            Menssage = message;
            Token = token;
        }
    }
}
