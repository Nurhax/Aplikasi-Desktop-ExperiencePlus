using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace TubesKelompok5.UnitTests
{
    [TestClass]
    public class MainProgramTests
    {
        private readonly StringWriter _consoleOutput = new StringWriter();

        [TestInitialize]
        public void Initialize()
        {
            Console.SetOut(_consoleOutput);
        }

        [TestMethod]
        public async Task RegisterAndLogin_Success()
        {
            StringReader input = new StringReader("1\nTestUser\nTestPassword\ntest@example.com\nTestUser\nTestPassword\n");

            Console.SetIn(input);

            await MainProgram.Main(null);

            Assert.IsTrue(_consoleOutput.ToString().Contains("Registrasi berhasil"));
            Assert.IsTrue(_consoleOutput.ToString().Contains("Login berhasil"));
        }

        [TestMethod]
        public async Task RegisterAndLogin_Failure()
        {
            StringReader input = new StringReader("1\nTestUser\nTestPassword\ninvalidemail\nTestUser\nInvalidPassword\n");

            Console.SetIn(input);

            await MainProgram.Main(null);

            Assert.IsTrue(_consoleOutput.ToString().Contains("Registrasi gagal"));
            Assert.IsTrue(_consoleOutput.ToString().Contains("Login gagal"));
        }
    }
}
