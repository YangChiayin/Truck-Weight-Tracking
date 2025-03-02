using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiayin_Yang_Truck
{
    internal class TruckWeightRecord
    {
        public int RecordId { get; set; }
        public int TruckId { get; set; }
        public DateTime DateMeasured { get; set; }
        public decimal GrossWeight { get; set; }
        public decimal TareWeight { get; set; }

        public TruckWeightRecord(int recordId, int truckId, DateTime dateMeasured, decimal grossWeight, decimal tareWeight)
        {
            RecordId = recordId;
            TruckId = truckId;
            DateMeasured = dateMeasured;
            GrossWeight = grossWeight;
            TareWeight = tareWeight;
        }
    }
}
