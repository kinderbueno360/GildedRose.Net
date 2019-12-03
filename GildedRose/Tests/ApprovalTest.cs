using Xunit;
using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;

namespace GildedRoseApp.ConsoleApplication
{
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            // Arrange
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));
            Program.Main(new string[] { });

            // Act
            var output = fakeoutput.ToString();

            // Assert
            Approvals.Verify(output);
        }
    }
}
