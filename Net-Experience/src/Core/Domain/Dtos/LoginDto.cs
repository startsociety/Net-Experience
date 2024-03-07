namespace Net.Experience.Domain.Dtos
{
    public class LoginDto
    {
        public string Menssage { get; set; }
        public string Token { get; set; }

        public LoginDto(string message)
        {
            Menssage = message;
        }
    }
}
