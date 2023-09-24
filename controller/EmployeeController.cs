using Microsoft.AspNetCore.Mvc;
using mvc_Lap1.Model;

namespace mvc_Lap1.controller
{
    public class EmployeeController : Controller
    {
       
        public IActionResult GetEmployeeData()
        {
            List<Department> department = new List<Department>();
            department.Add(new Department() { id=1,name="it"});
            department.Add(new Department() { id=2,name="is"});
            department.Add(new Department() { id=1,name="it"});
            department.Add(new Department() { id=4,name="DS"});
           
            Employee EmployeeObj = new Employee()
            {
                id = 10,
                name = "shereen",
                address = "cairo",
                //department =department.FirstOrDefault(e=>e.id==4).name,
                department ="It",
                salary = 5000
             
                };


            //return View("employee", EmployeeObj);
            return View("GetEmployeeData", EmployeeObj);
            
        }
    }

    internal class Department
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
