
namespace Day_27_Practice_AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("---first name------last names---------address------city------state------zip------phone number------email...");
            ContactOperation contactOperation = new ContactOperation();
            contactOperation.addContact("mahesh", "modi", "maharashtra", "mumbai", "maharashtra", "766452", "9712345678", "abc@gmail.com");
            contactOperation.showList();
        }
    }
}