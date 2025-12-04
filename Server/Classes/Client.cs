namespace Server.Classes
{
    class Client
    {
        public string Token { get; set; }
        public string Login { get; set; }  
        public DateTime DateConnect { get; set; }

        public Client(string login = "")  
        {
            Random random = new Random();
            string Chars = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasfghjklzxcvbnm0123456789";

            Token = new string(Enumerable.Repeat(Chars, 15).Select(x => x[random.Next(Chars.Length)]).ToArray());
            DateConnect = DateTime.Now;
            Login = login;  
        }
    }
}