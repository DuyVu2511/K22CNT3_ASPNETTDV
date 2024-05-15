using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDV.Lab04._2.Models
{
    //định nghĩa giao diện khách hàng
    public interface ICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<TDVCustomer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        TDVCustomer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(TDVCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(TDVCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<TDVCustomer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(TDVCustomer cus);
    }
}
