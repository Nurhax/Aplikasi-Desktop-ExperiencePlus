namespace UnitTesting_Iqbal_1302223050


{
using TubesKelompok5;

[TestClass]
    public class Testing_Iqbal
    {
        [TestMethod]
        public void TestBuatLowongan()
        {
            //Arrange
            BuatLowongan_1302223050 testLowongan = new BuatLowongan_1302223050();
            lowongan lowongan = new lowongan();
            lowongan.setNamaLowongan("Software Engineering - Business Analyst");
            lowongan.setdeskripsiPekerjaan("Bekerja sebagai business analyst untuk menjabarkan requirements yang didapatkan");
            lowongan.setsyarat("Mahasiswa S1 RPL, Memiliki pengalaman 3 bulan dengan projek serupa");
            lowongan.setperiodeLowongan("03/06/2024");
            lowongan.setIDLowongan(testLowongan.getlowonganPerusahaan().Count);
            testLowongan.getlowonganPerusahaan().Add(lowongan);

            //Act
            BuatLowongan_1302223050 actLowongan = new BuatLowongan_1302223050();
            actLowongan.TestCreateLowongan();

            //Assert
            Assert.AreEqual(testLowongan.getlowonganPerusahaan().Count, actLowongan.getlowonganPerusahaan().Count);

        }

        [TestMethod]
        public void TestShowAllMahasiswa()
        {
            //Arrange
            ListCV_1302223050 testListCV = new ListCV_1302223050();

            //Act
            testListCV.getListCV().Add(new ListCV_1302223050.CV("Muhammad Iqbal Nurhaq","Chevalier Lab, Gamejam, Bot Project","S1 Rekayasa Perangkat Lunak","iqbalnur2000@gmail.com"));
            testListCV.getListCV().Add(new ListCV_1302223050.CV("Hafid Al Akhyar", "Chevalier Lab, Mobile Lab, RPLGDC", "S1 Rekayasa Perangkat Lunak", "Hafid123@gmail.com"));
            testListCV.getListCV().Add(new ListCV_1302223050.CV("Ragadhitya", "Mobile Lab, CyberLab", "S1 Rekayasa Perangkat Lunak", "Ragadhitya@gmail.com"));

            //Assert
            testListCV.showALLCVMahasiswa();
            Assert.IsNotNull(testListCV);
        }

        [TestMethod]
        public void TestMenuEnum1()
        {
            //Arrange
            int hasil = 0;
            int expected = 1;

            //Act
            hasil = MenuEnum_1302223050.GetKonfirmasi(MenuEnum_1302223050.Konfirmasi.Iya);

            //Assert
            Console.WriteLine(expected);
            Console.WriteLine(hasil);
            Assert.AreEqual(expected, hasil);
        }
    }
}