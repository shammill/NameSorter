using NUnit.Framework;
using Sorter.Services;
using Sorter.Model;

namespace Sorter.Testing
{
    [TestFixture]
    public class FileHelperTests
    {
        [Test]
        public void GetOutputFileNameTest()
        {
            string inputFileName = "C:\\TestFolder\\TestFile.txt";
            string appender = "sorted";
            string expectedResult = "C:\\TestFolder\\TestFile-sorted.txt";

            string outPutFileName = FileHelper.GetOutputFileName(inputFileName, appender);

            Assert.AreEqual(expectedResult, outPutFileName);
        }

        [Test]
        public void ConvertLineToPersonTest()
        {
            string line = "DOE, JOHN";
            Person person = FileHelper.ConvertLineToPerson(line);

            Assert.AreEqual(person.FirstName, "JOHN");
            Assert.AreEqual(person.LastName, "DOE");
        }


    }
}
