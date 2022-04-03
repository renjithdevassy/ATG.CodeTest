using System;
using System.Collections.Generic;
using System.Text;

namespace ATG.CodeTest
{
    public class ArchivedRepository : IArchivedRepository
    {
        public Lot GetLot(int id)
        {
            return new Lot();
        }
    }
}
