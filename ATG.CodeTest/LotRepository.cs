using System;
using System.Collections.Generic;
using System.Text;

namespace ATG.CodeTest
{
   public class LotRepository : ILotRepository
    {
        public Lot LoadCustomer()
        {
            Lot lot= new Lot();
            lot.Id = 1;
            lot.Name = "Test1";
            lot.Description = "Test Description";
            lot.Price = 150;
            lot.IsArchived = true;

            return lot;
        }
    }
}
