namespace solid_principles_example_project;

public class Customer
{
    private DBContext _db;
    public string? Name { get; set; }
    public string? EmailAddress { get; set; }

    public Customer(DBContext db)
    {
        _db = db;
    }

    public int GetNameLength()
    {
        return (Name is not null) ? Name.Length : 0;
    }

    public void ChangeEmailAddress(string email)
    {
        EmailAddress = email;
        _db.Add(this);
        _db.SaveChanges();
    }
}

// Sample class for database context
public class DBContext
{
    internal void Add(Customer customer)
    {
        // Add some stuff
    }

    internal void SaveChanges()
    {
        // Save changes
    }
}