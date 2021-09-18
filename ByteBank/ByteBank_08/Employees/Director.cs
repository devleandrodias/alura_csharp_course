namespace ByteBank_08.Employees
{
    internal class Director : Employee
    {
        public override double GetBonus()
        {
            return (Salary * 0.20) + base.GetBonus();
        } 
    }
}
