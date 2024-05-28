using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolClassProject
{
    public class SchoolClass
    {
        public SchoolClass()
        {
            Class = 0;
            ClassID = string.Empty;
            ClassFeeMonthly = 0;

        }

        public SchoolClass(int _class, string _classID, int _classFeeMonthly, int _numberofStudentsinClass)
        {
            Class = _class;
            ClassID = _classID;
            ClassFeeMonthly = _classFeeMonthly;
            NumberofStudentsinClass = _numberofStudentsinClass;
        }

        public int Class { get; set; }
        public string ClassID { get; set; }
        public int ClassFeeMonthly { get; set; }

        public int NumberofStudentsinClass { get; set; }

        public string WhoPaysMore(SchoolClass other)
        {
            if (ClassFeeMonthly == other.ClassFeeMonthly)
            {
                return Class + "." + ClassID + "és " + other.Class + "." + other.ClassID + "osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta!";
            }

            else if (ClassFeeMonthly > other.ClassFeeMonthly)
            {
                return $"{Class}.{ClassID} osztály diákjai  havonta {ClassFeeMonthly - other.ClassFeeMonthly} forinttal többet fizetnek osztálypénzbe, mint {other.Class}.{other.ClassID} osztály tanulói.";
            }
            else
            {
                return $"{other.Class}.{other.ClassID} osztály diákjai  havonta {other.ClassFeeMonthly - ClassFeeMonthly} forinttal többet fizetnek osztálypénzbe, mint {Class}.{ClassID} osztály tanulói.";
            }
        }

        public override string ToString()
        {
            return $"{Class}.{ClassID} ({ClassFeeMonthly} Ft)";
        }


    }
}
