
using TubesKelompok5;
using static TubesKelompok5.ListCV_1302223050;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void UploadCV()
        {
            //Arrange
            ListCV_1302223050 testing = new ListCV_1302223050();
            ListCV_1302223050.CV CVS = new ListCV_1302223050.CV();
            //act
            ListCV_1302223050.CV result = testing.testuploadCV2("hafid", "hafiidd@gmail.com", "SMK", "300");
            //assert
          
            Assert.IsNotNull(result);  

        }
    }
}