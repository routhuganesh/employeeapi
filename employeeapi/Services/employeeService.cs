using employeeapi.Contracts;
using employeeapi.Models;

namespace employeeapi.Services
{
    public class employeeService:IemployeeService
    {
        public employee Add(employee newItem) => throw new NotImplementedException();

        public IEnumerable<employee> GetAllItems() => throw new NotImplementedException();

        public employee GetById(Guid id) => throw new NotImplementedException();

        public void Remove(Guid id) => throw new NotImplementedException();

        
    }
}
