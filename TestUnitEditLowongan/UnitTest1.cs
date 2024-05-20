using Newtonsoft.Json;
using TubesKelompok5;
using TubesKelompok5.Model;
using static TubesKelompok5.StatusLowongan;
namespace TestUnitEditLowongan
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EditNama()
        {
            var editor = new editLowongan();
            List<lowongan> lowongan = new List<lowongan>
            {
                new lowongan { nama = "Software Developer", syarat = "Degree in Computer Science", deskripsi = "create software using the Kotlin language and create APIs", Status = 0, periode = "01/05/2023" },
                new lowongan { nama = "Graphic Designer", syarat = "Experience in Adobe Premier Pro", deskripsi = "Create a new product design that will launcing", Status = 0, periode = "05/07/2024" },
                new lowongan { nama = "Marketing Manager", syarat = "MBA in Marketing", deskripsi = "Make a marketing plan", Status = 0, periode = "01/01/01" },
                new lowongan { nama = "Software Developer", syarat = "Master in Computer Science", deskripsi = "make software with flutter", Status = 0, periode = "01/05/2024" }
            };

            string tempFile = Path.GetTempFileName();
            try
            {
                File.WriteAllText(tempFile, JsonConvert.SerializeObject(lowongan));

                string input = "Nama baru";
                StringReader stringReader = new StringReader(input);
                Console.SetIn(stringReader);

                editor.EditNama(lowongan, 1);

                Assert.AreEqual("Nama baru", lowongan[0].nama);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void EditDeskripsi()
        {
            var editor = new editLowongan();
            List<lowongan> lowongan = new List<lowongan>
            {
                new lowongan { nama = "Software Developer", syarat = "Degree in Computer Science", deskripsi = "create software using the Kotlin language and create APIs", Status = 0, periode = "01/05/2023" },
                new lowongan { nama = "Graphic Designer", syarat = "Experience in Adobe Premier Pro", deskripsi = "Create a new product design that will launcing", Status = 0, periode = "05/07/2024" },
                new lowongan { nama = "Marketing Manager", syarat = "MBA in Marketing", deskripsi = "Make a marketing plan", Status = 0, periode = "01/01/01" },
                new lowongan { nama = "Software Developer", syarat = "Master in Computer Science", deskripsi = "make software with flutter", Status = 0, periode = "01/05/2024" }
            };

            string tempFile = Path.GetTempFileName();
            try
            {
                File.WriteAllText(tempFile, JsonConvert.SerializeObject(lowongan));

                string input = "Deskripsi baru";
                StringReader stringReader = new StringReader(input);
                Console.SetIn(stringReader);

                editor.EditDeskripsi(lowongan, 1);

                Assert.AreEqual("Deskripsi baru", lowongan[0].deskripsi);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void EditSyarat()
        {
            var editor = new editLowongan();
            List<lowongan> lowongan = new List<lowongan>
            {
                new lowongan { nama = "Software Developer", syarat = "Degree in Computer Science", deskripsi = "create software using the Kotlin language and create APIs", Status = 0, periode = "01/05/2023" },
                new lowongan { nama = "Graphic Designer", syarat = "Experience in Adobe Premier Pro", deskripsi = "Create a new product design that will launcing", Status = 0, periode = "05/07/2024" },
                new lowongan { nama = "Marketing Manager", syarat = "MBA in Marketing", deskripsi = "Make a marketing plan", Status = 0, periode = "01/01/01" },
                new lowongan { nama = "Software Developer", syarat = "Master in Computer Science", deskripsi = "make software with flutter", Status = 0, periode = "01/05/2024" }
            };

            string tempFile = Path.GetTempFileName();
            try
            {
                File.WriteAllText(tempFile, JsonConvert.SerializeObject(lowongan));

                string input = "Syarat baru";
                StringReader stringReader = new StringReader(input);
                Console.SetIn(stringReader);

                editor.EditSyarat(lowongan, 1);

                Assert.AreEqual("Syarat baru", lowongan[0].syarat);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void EditPeriode()
        {
            var editor = new editLowongan();
            List<lowongan> lowongan = new List<lowongan>
            {
                new lowongan { nama = "Software Developer", syarat = "Degree in Computer Science", deskripsi = "create software using the Kotlin language and create APIs", Status = 0, periode = "01/05/2023" },
                new lowongan { nama = "Graphic Designer", syarat = "Experience in Adobe Premier Pro", deskripsi = "Create a new product design that will launcing", Status = 0, periode = "05/07/2024" },
                new lowongan { nama = "Marketing Manager", syarat = "MBA in Marketing", deskripsi = "Make a marketing plan", Status = 0, periode = "01/01/01" },
                new lowongan { nama = "Software Developer", syarat = "Master in Computer Science", deskripsi = "make software with flutter", Status = 0, periode = "01/05/2024" }
            };

            string tempFile = Path.GetTempFileName();
            try
            {
                File.WriteAllText(tempFile, JsonConvert.SerializeObject(lowongan));

                string input = "21/05/2024";
                StringReader stringReader = new StringReader(input);
                Console.SetIn(stringReader);

                editor.EditPeriode(lowongan, 1);

                Assert.AreEqual("21/05/2024", lowongan[0].periode);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }
        [TestMethod]
        public void cekStatus()
        {
            // Arrange
            var status = new StatusLowongan();
            List<lowongan> lowongan = new List<lowongan>
            {
                new lowongan { nama = "Software Developer", syarat = "Degree in Computer Science", deskripsi = "create software using the Kotlin language and create APIs", Status = 0, periode = "01/12/2024" },
                new lowongan { nama = "Graphic Designer", syarat = "Experience in Adobe Premier Pro", deskripsi = "Create a new product design that will launcing", Status = 0, periode = "05/05/2024" },
                new lowongan { nama = "Marketing Manager", syarat = "MBA in Marketing", deskripsi = "Make a marketing plan", Status = 0, periode = "20/06/2024" },
                new lowongan { nama = "Software Developer", syarat = "Master in Computer Science", deskripsi = "make software with flutter", Status = 0, periode = "01/05/2024" }
            };

            // Act
            status.SetStatus(lowongan);

            // Assert
            foreach (var vacancy in lowongan)
            {
                if (Convert.ToInt32(vacancy.periode.Split('/')[1]) == DateTime.Now.Month &&
                    Convert.ToInt32(vacancy.periode.Split('/')[2]) == DateTime.Now.Year)
                {
                    Assert.AreEqual(statusState.TERSEDIA, vacancy.Status);
                }
                else
                {
                    Assert.AreEqual(statusState.TIDAK_TERSEDIA, vacancy.Status);
                }
            }
        }
    }
}