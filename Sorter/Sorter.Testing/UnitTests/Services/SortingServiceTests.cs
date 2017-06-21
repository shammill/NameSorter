using System.Collections.Generic;
using NUnit.Framework;
using Sorter.Services;
using Sorter.Model;
using System.Linq;

namespace Sorter.Testing
{
    [TestFixture]
    public class SortingServiceTests
    {
        [Test]
        public void SortPeopleByLastNameTests()
        {
            List<Person> unsortedPeople = new List<Person>();

            var personTheo = new Person("THEODORE", "BAKER");
            var personFred = new Person("FREDRICK", "SMITH");

            unsortedPeople.Add(new Person("ANDREW", "SMITH"));
            unsortedPeople.Add(personTheo);
            unsortedPeople.Add(personFred);
            unsortedPeople.Add(new Person("MADISON", "KENT"));

            var sortedPeople = SortingService.SortPeopleByLastName(unsortedPeople);

            Assert.AreEqual(sortedPeople.First().OutputName, personTheo.OutputName);
            Assert.AreEqual(sortedPeople.Last().OutputName, personFred.OutputName);
        }
    }
}
