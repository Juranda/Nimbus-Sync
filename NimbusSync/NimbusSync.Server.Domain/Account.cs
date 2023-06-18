namespace NimbusSync.Server.Domain
{
    public class Account
    {
        public enum PrivilageTypes
        {
            ReadFile,
            WriteFile,
            UpdateFile,
            DeleteFile,
            CreateAccount,
            UpdateAccount,
            DeleteAccont
        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<PrivilageTypes> Privilages { get; set; }
        public List<TecnicalDraw> TecnicalDraws { get; set; }
    }
}