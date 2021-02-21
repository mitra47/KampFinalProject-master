using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();

        IDataResult<Order> GetById(int orderId);
        IDataResult<Order> GetAllShipCity();
        IResult Add(Order order);
        IDataResult<Order> GetByCustomerId();

        IDataResult<Order> GetByEmployeeId(int id);


    }
}
