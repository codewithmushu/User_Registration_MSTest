using System.Text.RegularExpressions;
using UserRegistrationProblem_Test;
namespace Registration_Test
{
    [TestClass]
    public class UnitTestUC1
    {
        [TestMethod]
        public void Main_ValidLastNameInput_ReturnsValid()
        {
            // Arrange
            var input = new StringReader("Doe\n");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Program.Main(new string[] { });

            // Assert
            Assert.AreEqual("Please enter your last name:\r\nValid last name entered.\r\n", output.ToString());
        }

        [TestMethod]
        public void Main_InvalidLastNameInput_ReturnsInvalid()
        {
            // Arrange
            var input = new StringReader("doe\n");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Program.Main(new string[] { });

            // Assert
            Assert.AreEqual("Please enter your last name:\r\nInvalid last name entered.\r\n", output.ToString());
        }
    }
       
}