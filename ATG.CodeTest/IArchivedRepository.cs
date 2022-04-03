using System;
using System.Collections.Generic;
using System.Text;

namespace ATG.CodeTest
{
    public interface IArchivedRepository
    {
        Lot GetLot(int id);
    }
}
