using SantasEmporium.Models;

namespace SantasEmporium.Services
{
    public class RecipientService
    {
        // Contains list of recipients
        static List<Recipient> Recipients { get; }
        static int nextId = 4;
        // Constructor
        static RecipientService()
        {
            // Add three recipients to our list 
            Recipients = new List<Recipient>
                {
                    new Recipient { Id = 1, Name = "Nish Mandal", Location = "London", IsNice = true,  Present = "Playstation 5"},
                    new Recipient { Id = 2, Name = "Cathy French", Location = "Toronto", IsNice = true,  Present = "Chocolate Elves"},
                    new Recipient { Id = 3, Name = "Lei Booth", Location = "Birmingham", IsNice = false,  Present = "Burning Coal"}
                };
        }

        //Method which returns all recipients in the Recipients list
        public static List<Recipient> GetAll()
        {
            return Recipients;
        }

        //Method to get all recipients by Id
        public static Recipient? Get(int id)
        {
            return Recipients.FirstOrDefault(p => p.Id == id);
        }

        //Method to add recipients to List
        public static void Add(Recipient recipient)
        {
            //Set recipient id 
            recipient.Id = nextId++;
            Recipients.Add(recipient);
        }

        //Delete recipient by Id
        public static void Delete(int id)
        {
            var recipient = Get(id);
            if (recipient is null)
                return;

            Recipients.Remove(recipient);
        }

        //Update recipient details
        public static void Update(Recipient recipient)
        {
            var index = Recipients.FindIndex(p => p.Id == recipient.Id);
            if (index == -1)
                return;

            Recipients[index] = recipient;
        }
    }
}