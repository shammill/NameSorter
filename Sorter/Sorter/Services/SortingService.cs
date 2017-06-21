using System.Collections.Generic;
using System.Linq;
using Sorter.Model;

namespace Sorter.Services
{
    public static class SortingService
    {
        public static List<Person> SortPeopleByLastName(List<Person> people)
        {
            return people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();
        }

    }
}
