namespace Library.User;

public class User
{
    public Guid Id { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public User()
    {
        Id = Guid.NewGuid();
        UserName = string.Empty;
        Password = string.Empty;
        Email = string.Empty;
        Phone = string.Empty;
        
    }

}