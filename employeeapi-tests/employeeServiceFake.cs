using employeeapi.Contracts;
using employeeapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeapi_tests
{
    public class employeeServiceFake : IemployeeService
    {
        private readonly List<employee> _shoppingCart;

        public employeeServiceFake()
        {
            _shoppingCart = new List<employee>()
            {
                new employee() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c"),
                    Name = "Ganesh", Role="Developer"},
                new employee() { Id = new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"),
                    Name = "Elon", Role= "inventor" },
                new employee() { Id = new Guid("33704c4a-5b87-464c-bfb6-51971b4d18ad"),
                    Name = "Mark", Role="entreprenuer"}
            };
        }

        public IEnumerable<employee> GetAllItems()
        {
            return _shoppingCart;
        }

        public employee Add(employee newItem)
        {
            newItem.Id = Guid.NewGuid();
            _shoppingCart.Add(newItem);
            return newItem;
        }

        public employee GetById(Guid id)
        {
            return _shoppingCart.Where(a => a.Id == id)
                .FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            var existing = _shoppingCart.First(a => a.Id == id);
            _shoppingCart.Remove(existing);
        }
    }
}
