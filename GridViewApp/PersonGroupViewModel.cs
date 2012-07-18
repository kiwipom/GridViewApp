using System.Collections.Generic;

namespace GridViewApp
{
    public class PersonGroupViewModel : GroupViewModel<string, Person>
    {
        public PersonGroupViewModel(string key, IEnumerable<Person> collection)
            : base(key, collection)
        {
        }
    }
}