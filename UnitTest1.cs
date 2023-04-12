using System.Text.RegularExpressions;
using UserRegistrationProblem_Test;
namespace Registration_Test
{
    [TestClass]
    public class UnitTestUC1
    {
        [TestMethod]
        public void Main_ValidFirstNameInput_ReturnsValid()
        {
            // Arrange
            var input = new StringReader("John\n");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Program.Main(new string[] { });

            // Assert
            Assert.AreEqual("Please enter your first name:\r\nValid first name entered.\r\n", output.ToString());
        }


        [TestMethod]
        public void Main_InvalidFirstNameInput_ReturnsInvalid()
        {
            // Arrange
            var input = new StringReader("john\n");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Program.Main(new string[] { });

            // Assert
            Assert.AreEqual("Please enter your first name:\r\nInvalid first name entered.\r\n", output.ToString());
        }
    }
}