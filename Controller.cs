using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class Controller {
    List<Worker> workers;
    public Controller() {
        workers = JsonSerializer.Deserialize<List<Worker>>(File.ReadAllText("list.json"));
    }
    public List<Worker> getListEmployeeWithExperience(int experience) {
        List<Worker> list = new List<Worker>();
        foreach(Worker worker in workers) {
            if(worker.getExperience()>=experience) list.Add(worker);
        }
        return list;
    }
    public List<Worker> getListEmployeeWithSalary(int salary) {
        List<Worker> list = new List<Worker>();
        foreach (Worker worker in workers) {
            if (worker.salary >= salary) list.Add(worker);
        }
        return list;
    }

    public List<Worker> getListEmployeeJobTitle(string jobTitle) {
        List<Worker> list = new List<Worker>();
        foreach (Worker worker in workers) {
            if (worker.jobTitle == jobTitle) list.Add(worker);
        }
        return list;
    }
}