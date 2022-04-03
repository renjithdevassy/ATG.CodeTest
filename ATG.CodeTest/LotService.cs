using System;
using System.Collections.Generic;
using System.Linq;

namespace ATG.CodeTest
{
    public class LotService
    {
        private readonly ILotRepository _lotRepository;
        private readonly IFailoverLotRepository _failoverLotRepository;
        private readonly IArchivedRepository _archivedRepository;
        public LotService(ILotRepository lotRepository, IFailoverLotRepository failoverLotRepository, IArchivedRepository archivedRepository)
        {
            _lotRepository = lotRepository;
            _failoverLotRepository = failoverLotRepository;
            _archivedRepository = archivedRepository;

        }
        public Lot GetLot(int id, bool isLotArchived)
        {
            bool isFailoverModeEnabled = true;
            int MaxFailedRequests = 50;
            Lot lot = null;

            var failoverLots = GetFailOverLotEntries();
            var failedRequests = failoverLots.Where(failoverLotsEntry => failoverLotsEntry.DateTime > DateTime.Now.AddMinutes(10)).Count();
            if ((failedRequests > MaxFailedRequests) && isFailoverModeEnabled)
            {
                lot = _failoverLotRepository.GetLot(id);
            }

            if (lot.IsArchived && isLotArchived)
            {
                return _archivedRepository.GetLot(id);
            }
            else
            {
                return _lotRepository.LoadCustomer();
            }
        }

        public List<FailoverLots> GetFailOverLotEntries()
        {
            // return all from fail entries from database
            return new List<FailoverLots>();
        }
    }
}
