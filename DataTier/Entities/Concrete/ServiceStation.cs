using DataTier.Entities.Concrete.Statuses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class ServiceStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ServiceStationStatus ServiceStationStatus { get; set; }
        public ICollection<ServiceStationStatus> ServiceStationStatuses { get; set; }
        public ServiceStation()
        {
            ServiceStationStatuses = new List<ServiceStationStatus>();
        }
    }
}
