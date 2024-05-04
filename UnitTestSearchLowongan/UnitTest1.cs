using LibraryTubes.Searching;
using System.Diagnostics;
using TubesKelompok5;

namespace UnitTestSearchLowongan
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchingLowongan()
        {
            BuatLowongan_1302223050 searching = new BuatLowongan_1302223050();

            searching.getlowonganPerusahaan().Add(new BuatLowongan_1302223050.Lowongan("Web Developer", "We are looking for quick-thinking, problem-solving frontend engineers to build the next generation of fintech products.", "Have experience with Astro, react.js or next.js", "23/02/23"));
            searching.getlowonganPerusahaan().Add(new BuatLowongan_1302223050.Lowongan("Quality Assurance", "Maintain and write automation tests for Mobile Apps, Web, Mobile Web, API Tests", "Experience with testing tools like Proxyman, TestRail, JIRA, Firebase, etc.", "12/02/23"));

            searching.searchingLowonganTesting();
        }

        [TestMethod]
        public void showAllLowongan()
        {
            BuatLowongan_1302223050 lowongan = new BuatLowongan_1302223050();

            lowongan.getlowonganPerusahaan().Add(new BuatLowongan_1302223050.Lowongan("Web Developer", "We are looking for quick-thinking, problem-solving frontend engineers to build the next generation of fintech products.", "Have experience with Astro, react.js or next.js", "23/02/23"));
            lowongan.getlowonganPerusahaan().Add(new BuatLowongan_1302223050.Lowongan("Quality Assurance", "Maintain and write automation tests for Mobile Apps, Web, Mobile Web, API Tests", "Experience with testing tools like Proxyman, TestRail, JIRA, Firebase, etc.", "12/02/23"));

            lowongan.ShowAllLowongan();
        }
    }
}