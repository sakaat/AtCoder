using System;
using System.IO;
using Xunit;

namespace CSharp
{
    public class MainTest
    {
        [Fact]
        public void MainTest1()
        {
            TestInOut("input1.txt", "output1.txt");
        }

        [Fact]
        public void MainTest2()
        {
            TestInOut("input2.txt", "output2.txt");
        }

        private void TestInOut(string inputFileName, string outputFileName)
        {
            using (var input = new StreamReader(inputFileName))
            using (var output = new StringWriter())
            {
                Console.SetOut(output);
                Console.SetIn(input);

                Program.Main();

                Assert.Equal(File.ReadAllText(outputFileName), output.ToString());
            }
        }
    }
}
