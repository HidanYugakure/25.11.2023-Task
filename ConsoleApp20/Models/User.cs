
namespace ConsoleApp20.Models
{
    internal class User : IAccount
    {
        public int Id;
        public string Fullname;
        public string Email;
        public bool PsswordChecker;
        public string Password;
        public static int MaxId=1;

        public User(string fullname, string email, string password)
        {
            Id = MaxId++;
            Fullname = fullname;
            Email = email;
            Password = password;
        }
        public void InfoShow()
        {
            Console.WriteLine($"User ID: {Id}");
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"Email: {Email}");
        }
        public void checkPssword(string password)
        {
            if (password.Length > 8 &&
               password.Any(char.IsUpper) &&
               password.Any(char.IsLower) &&
               password.Any(char.IsDigit))
            {
                PsswordChecker = true;
                Console.WriteLine("dogrudur");
            }
            else
            {
                PsswordChecker = false;
                Console.WriteLine("sehvdir");
            }
        }
    }
}