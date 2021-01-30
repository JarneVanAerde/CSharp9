namespace Records
{
    public record User1(int id, string FirstName, string LastName) : Record1(FirstName, LastName);
}
