namespace Net.Experience.Common.Helpers
{
    public static class MessageGeneral
    {
        private static string messageDontExist = "The element doesn't exist.";
        private static string messageDeleteSuccess = "The element was deleted with success.";
        private static string messageInvalidFormant = "Invalid Format";
        private static string messageExist = "It already existst";
        private static string notFound = "Not Found";
        private static string bussinessRules = "Bussiness Rules";
        private static string successful = "Successful";
        private static string userLoginSucess = "User logged in.";
        private static string invalidLogin = "Invalid login attempt.";
        public static string DontExist { get => messageDontExist; set { messageDontExist = value; } }
        public static string DeleteSuccess { get => messageDeleteSuccess; set { messageDeleteSuccess = value; } }
        public static string InvalidFormat { get => messageInvalidFormant; set { messageInvalidFormant = value; } }
        public static string MessageExist { get => messageExist; set { messageInvalidFormant = value; } }
        public static string NotFound { get => notFound; set { notFound = value; } }
        public static string Successful { get => successful; set { successful = value; } }
        public static string BussinessRules { get => bussinessRules; set { bussinessRules = value; } }
        public static string UserLoginSucess { get => userLoginSucess; set { userLoginSucess = value; } }
        public static string InvalidLogin { get => invalidLogin; set { invalidLogin = value; } }
    }
}
