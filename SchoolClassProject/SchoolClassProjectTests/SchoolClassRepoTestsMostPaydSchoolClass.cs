using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Tests
{
    [TestClass()]
    public class SchoolClassRepoTestsMostPaydSchoolClass
    {
        [TestMethod()]
        public void MostPaydSchoolClassTestSameAmount()
        {

            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(new List<SchoolClass>
            {
                new SchoolClass (9,"a", 6000, 30),
                new SchoolClass (9,"b", 6000, 30)
            });
            string actual = schoolClassRepo.MostPaydSchoolClass();
            string expected = "9.a";

            Assert.AreEqual(actual, expected);

        }

        [TestMethod()]
        public void MostPaydSchoolClassTestFirstisHigher()
        {

            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(new List<SchoolClass>
            {
                new SchoolClass (9,"a", 7000, 30),
                new SchoolClass (9,"b", 6000, 30)
            });
            string actual = schoolClassRepo.MostPaydSchoolClass();
            string expected = "9.a";

            Assert.AreEqual(actual, expected);

        }

        [TestMethod()]
        public void MostPaydSchoolClassTestSecondIsHigher()
        {

            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(new List<SchoolClass>
            {
                new SchoolClass (9,"a", 6000, 30),
                new SchoolClass (9,"b", 7000, 30)
            });
            string actual = schoolClassRepo.MostPaydSchoolClass();
            string expected = "9.b";

            Assert.AreEqual(actual, expected);

        }

        [TestMethod()]
        public void MostPaydSchoolClassTestNoClass()
        {

            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(new List<SchoolClass>());
            string actual = schoolClassRepo.MostPaydSchoolClass();
            string expected = "Nincs egyetlen diák sem az adatbázisban!";

            Assert.AreEqual(actual, expected);

        }
    }
}