namespace task_Dev_3
{
    /// <summary>
    /// abstract parent class which gets payroll and performance information
    /// </summary>
    abstract class Employee
    {
        public abstract int GetSalary();
        public abstract int GetProductivity();
    }
}
