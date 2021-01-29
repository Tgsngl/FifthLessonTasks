using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }

            else 
            {
                throw new Exception("Not a valid customer");
            }
        }
            

    }
}
