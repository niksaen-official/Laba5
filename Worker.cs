using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Worker {
    public string fullName { get; private set; }
    public string jobTitle { get; private set; }
    public int yearOfAdmission { get; private set; }
    public int salary { get; private set; }
    public Worker(string fullName,string jobTitle,int yearOfAdmission,int salary) {
        this.fullName = fullName;
        this.jobTitle = jobTitle;
        this.yearOfAdmission = yearOfAdmission;
        this.salary = salary;
    }
    public int getExperience() {
        return DateTime.Now.Year-yearOfAdmission;
    }
    public string ToString() {
        return $"Фамилия и инициалы: {fullName}\nДолжность: {jobTitle}\nГод поступления: {yearOfAdmission}\nЗарплата: {salary}R\n";
    }
}