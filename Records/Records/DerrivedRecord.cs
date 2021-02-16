namespace Records
{
    public record DerrivedRecord(int Id, string FirstName, string LastName) : Record1(FirstName, LastName);
}
