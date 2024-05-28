using SchoolClassProject;

SchoolClass firstClass = new()
{
    Class = 9,
    ClassID = "a",
    ClassFeeMonthly = 7000,
    NumberofStudentsinClass = 30
};

SchoolClass secondClass = new()
{
    Class = 9,
    ClassID = "b",
    ClassFeeMonthly = 6000,
    NumberofStudentsinClass = 30

};

Console.WriteLine(firstClass.WhoPaysMore(secondClass));

SchoolClassRepo schoolClassRepo = new SchoolClassRepo(new List<SchoolClass>());
Console.WriteLine(schoolClassRepo.MostPaydSchoolClass());

Console.WriteLine(firstClass.Class + "." + firstClass.ClassID + ": " + firstClass.ClassFeeMonthly * firstClass.NumberofStudentsinClass * 10 + "Ft");
Console.WriteLine(secondClass.Class + "." + secondClass.ClassID + ": " + secondClass.ClassFeeMonthly * secondClass.NumberofStudentsinClass * 10 + "Ft");