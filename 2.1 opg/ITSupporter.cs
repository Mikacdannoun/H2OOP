
using EmployeesV10;

public class ITSupporter : Employee
{
    #region Properties
    public string? PrimaryWorkArea { get; set; }


    #endregion

    public void _PrintInformation(Employee employee)
    {
        Console.WriteLine($"{_Profession} {_Name} works {_HoursPerWeek} hours/week, working primarily with {PrimaryWorkArea}");
    }



    #region Constructor
    public ITSupporter(string profession, string name, int hoursPerWeek, string primaryWorkArea)
    {
        this._Name = name;
        this._HoursPerWeek = hoursPerWeek;
        this.PrimaryWorkArea = primaryWorkArea;
        this._Profession = profession;
    }
    #endregion
}