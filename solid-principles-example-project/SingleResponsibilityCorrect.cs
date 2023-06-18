namespace solid_principles_example_project;

public class CustomerCorrect
{
    public string? Name { get; set; }
    public string? EmailAddress { get; set; }

    public int GetNameLength()
    {
        return (Name is not null) ? Name.Length : 0;
    }

    public void ChangeEmailAddress(string email)
    {
        EmailAddress = email;
    }
}

public class CustomerRepository
{
    private DBContext _dbContext;

    public CustomerRepository(DBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddCustomer(Customer customer)
    {
        _dbContext.Add(customer);
        _dbContext.SaveChanges();
    }
}