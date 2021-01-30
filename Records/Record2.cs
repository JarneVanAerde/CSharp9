namespace Records
{
    public record Record2(string FirstName, string LastName)
    {
        private string _firstName = FirstName;

        public string Firstname
        {
            get { return _firstName = FirstName.Substring(0, 1); }
            init {  }
        }

        public string FullName { get => $"{FirstName} {LastName}"; }

        public string SayHello()
        {
            return $"Hello {FirstName}";
        }
    }
}
