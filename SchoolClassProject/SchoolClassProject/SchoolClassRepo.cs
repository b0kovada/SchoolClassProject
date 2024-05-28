using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        #region Database
        private List<SchoolClass> _schoolClasses = new();
        #endregion

        public SchoolClassRepo(List<SchoolClass> schoolClasses)
        {
            _schoolClasses = schoolClasses;
        }

        public List<SchoolClass> FindAll()
        {
            return _schoolClasses;
        }

        public string MostPaydSchoolClass()
        {
            if (!FindAll().Any())
            {
                return "Nincs egyetlen diák sem az adatbázisban!";
            }
            else
            {
                SchoolClass MostMoney = _schoolClasses.OrderByDescending(scCl => scCl.ClassFeeMonthly).FirstOrDefault();
                return $"{MostMoney.Class}.{MostMoney.ClassID}";
            }
        }

    }
}
