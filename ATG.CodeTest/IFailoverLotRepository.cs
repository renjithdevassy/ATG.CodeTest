using System;
using System.Collections.Generic;
using System.Text;

namespace ATG.CodeTest
{
    public interface IFailoverLotRepository
    {
        Lot GetLot(int id);
    }
}
