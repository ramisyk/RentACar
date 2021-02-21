using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
