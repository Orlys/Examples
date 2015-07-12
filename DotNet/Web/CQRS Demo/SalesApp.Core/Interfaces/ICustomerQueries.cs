using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PagedList;
using SalesApp.Core.Models;

namespace SalesApp.Core.Interfaces
{
    public interface ICustomerQueries
    {
        // ���䴩�����B�ƧǡB�z��
        Task<Customer[]> GetCustomersAsync();   

        // �䴩�����B�ƧǡB�z��]�I�s�ݥi�� PredicateBuilder �إ߿z���ܦ��^
        Task<IPagedList<Customer>> GetCustomersAsync(int page, int pageSize, string sortOrder, Expression<Func<Customer, bool>> filterExpr);

        Task<Customer> GetCustomerByIdAsync(int customerId);
    }
}