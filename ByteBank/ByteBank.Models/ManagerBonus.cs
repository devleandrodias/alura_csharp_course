
using ByteBank.Models.Employees;

namespace ByteBank.Models
{
    internal class ManagerBonus
    {
        private double _totalBonus;

        public void Register(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }

        public double GetTotalBonus() => _totalBonus;
    }
}
