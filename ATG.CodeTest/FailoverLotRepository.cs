using System;
using System.Collections.Generic;
using System.Text;

namespace ATG.CodeTest
{
   public class FailoverLotRepository : IFailoverLotRepository
    {
        public Lot GetLot(int id)
        {
            return new Lot();
        }
    }
}
