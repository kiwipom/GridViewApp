namespace GridViewApp
{
    public class Person
    {
        public int Age { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name
        {
            get { return FirstName + " " + LastName; }
        }
    }
}