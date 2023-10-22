ContactList contactList = new();
contactList.Menu();

public class ContactList
{
    public void Menu()
    {
        List<Contact> contacts = new List <Contact>();
        int option;

        do
        {
            Console.WriteLine("Enter 1 to Add Contact");
            Console.WriteLine("Enter 2 to View contact");
            Console.WriteLine("Enter 3 to Search contact");
            Console.WriteLine("Enter 4 to Exit");
            Console.Write("Enter your option: ");
            option = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            switch (option)
        {
            case 1:
                AddContact(contacts);
            break;
            case 2: 
                ViewContact(contacts);
            break;
            case 3: 
                FindContact(contacts);
            break;
            case 4: 
                Console.WriteLine("Exiting.... \nYou are signed out of the app.");
            break;
            default: 
                Console.WriteLine("Invalid option. Input the right option");
            break;
        }; 

        }while ( option != 4);
    }

    public void AddContact(List <Contact> contacts)
    {
        Contact newContact = new Contact();
        Console.Write("Enter contact name: ");
        newContact.Name = Console.ReadLine()!;
        Console.WriteLine();
        Console.WriteLine("Enter contact phone number: ");
        newContact.PhoneNumber = long.Parse(Console.ReadLine()!);
        Console.WriteLine();
        Console.WriteLine("Enter contact email: ");
        newContact.Email = Console.ReadLine()!;
        Console.WriteLine();
        contacts.Add(newContact);
        Console.WriteLine("Contact added successfully");
        Console.WriteLine();
    }

    public void ViewContact(List <Contact> contacts)
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contact found");
            Console.WriteLine();
            return;
        }

        foreach(Contact contact in contacts)
        {
            Console.WriteLine($"{contact.Name} \n{contact.PhoneNumber} \n{contact.Email}");
        }
    }

    public void FindContact(List <Contact> contacts)
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contact found");
            return;
        }

        Console.Write("Enter name to search: ");
        string searchName = Console.ReadLine()!;

        Contact resultSearch = contacts.Find(contact => contact.Name == searchName)!;

        if (searchName != "")
        {
            Console.WriteLine($"Name: {resultSearch.Name}");
            Console.WriteLine($"Phone number: {resultSearch.PhoneNumber}");
            Console.WriteLine($"Email: {resultSearch.Email}");
        }

        else
        {
            Console.WriteLine("This contact cannot be found");
        }
        Console.WriteLine();
    }
}


public class Contact
{
    public string? Name { get; set; }
    public long PhoneNumber { get; set; }
    public string? Email { get; set; }
}
