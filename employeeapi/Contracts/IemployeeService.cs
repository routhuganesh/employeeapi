using employeeapi.Models;

namespace employeeapi.Contracts
{
    public interface IemployeeService
    {
        
        IEnumerable<employee> GetAllItems();
        employee Add(employee newItem);
        employee GetById(Guid id);
        void Remove(Guid id);
    }
}

