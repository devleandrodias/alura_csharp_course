using ByteBank_08.Employees;

namespace ByteBank_08
{
    internal class ManagerBonus
    {
        private double _totalBonus;

        public void Register(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }

        public void Register(Director director)
        {
            _totalBonus += director.GetBonus();
        }

        public double GetTotalBonus() => _totalBonus;
    } 
}
