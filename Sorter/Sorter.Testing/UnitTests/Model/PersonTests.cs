using NUnit.Framework;
using Sorter.Model;

namespace Sorter.Testing.UnitTests.Model
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void PersonCtorTest()
        {
            string firstName = "John";
            string lastName = "Doe";

            Person person = new Person(firstName, lastName);
            Assert.AreEqual(firstName, person.FirstName);
            Assert.AreEqual(lastName, person.LastName);
        }

        [Test]
        public void PersonOutputNameTest()
        {
            string firstName = "John";
            string lastName = "Doe";

            Person person = new Person(firstName, lastName);
            Assert.AreEqual("Doe, John", person.OutputName);
        }
    }
}
