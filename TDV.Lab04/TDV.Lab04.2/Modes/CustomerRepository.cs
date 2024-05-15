using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDV.Lab04._2.Models
{
    public class CustomerRepository 
    {
        private static readonly List<TDVCustomer> data = new List<TDVCustomer>()
    {
        new TDVCustomer(){ CustomerId = "KH001", FullName = "Tran Duy Vu", Address = "Hà Nội", Email = "duyvutran2004@gmail.com", Phone = "0912345678", Balance = 9990000},
        new TDVCustomer(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc", Address = "Hà Nội", Email = "cucdt@gmail.com", Phone = "0986.767.444", Balance = 2200000},
        new TDVCustomer(){ CustomerId = "KH003", FullName = "Nguyễn Tuấn Thắng", Address = "Nam Định", Email = "thangnt@gmail.com", Phone = "0924.656.542", Balance = 1200000},
        new TDVCustomer(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải", Address = "Hà Nội", Email = "hailn@gmail.com", Phone = "0996.555.267", Balance = 6200000}
    };

        public IList<TDVCustomer> GetCustomers()
        {
            return data;
        }

        public IList<TDVCustomer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }

        public TDVCustomer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }

        public void AddCustomer(TDVCustomer cus)
        {
            data.Add(cus);
        }

        public void UpdateCustomer(TDVCustomer cus)
        {
            var customer = data.FirstOrDefault(c => c.CustomerId.Equals(cus.CustomerId));

            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }

        public void DeleteCustomer(TDVCustomer cus)
        {
            data.Remove(cus);
        }
    }
}