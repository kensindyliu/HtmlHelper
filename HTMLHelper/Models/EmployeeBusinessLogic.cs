using System;
namespace HTMLHelper.Models
{
	public class EmployeeBusinessLogic
	{
		public static List<Employee> Employees = new()
		{
			new Employee(){EmployeeFirstName ="FirstName", EmployeeLastName = "LastName" , Country = "Malay"}
		};

		public static Employee EditingEmployee;



        public EmployeeBusinessLogic()
		{
		}

		public bool AddEmployee(Employee em)
		{
			Employees.Add(em);
			return true;
        }

		public List<Employee> GetEmployees()
		{
			return Employees;

        }

		public List<Employee> DeleteEmployee(int employeeId)
		{
			int index = Employees.FindIndex(e => e.EmployeeId == employeeId);
			Employees.RemoveAt(index);
            return Employees;
        }


        public void EditEmployee(int employeeId)
        {
			EditingEmployee = Employees.FirstOrDefault(em => em.EmployeeId == employeeId);
        }

		public Employee GetEditingEmployee()
		{
			return EditingEmployee;
		}
    }
}

