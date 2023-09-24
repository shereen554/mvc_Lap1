namespace mvc_Lap1.Model
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string department { get; set; }
        public float salary { get; set; }

        public override string ToString()
        {
            return $"id= {id} Name ={name} Address = {address} Department = {department} Salary = {salary}";

        }
    }
}
