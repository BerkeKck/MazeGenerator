using Microsoft.AspNetCore.Mvc.Rendering;

namespace NorthwindWeb.MVCUI.Models
{
    public class OrderInsertDTO
    {
        public SelectList CustomerList { get; set; }
        public SelectList EmployeeList { get; set; }
        public SelectList ShipperList { get; set; }
        public OrderInsertDTO()
        {
                
        }

    }
}