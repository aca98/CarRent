using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class Deal
    {
        public static int IDincrement;
        private int dealID;
        private int carID;
        private DateTime dateFrom;
        private DateTime dateTo;
        private double pricePerDay;

        public Deal(int dealID, int carID, DateTime dateFrom, DateTime dateTo, double pricePerDay)
        {
            this.dealID = dealID;
            this.carID = carID;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.pricePerDay = pricePerDay;
        }
        public Deal(int carID, DateTime dateFrom, DateTime dateTo, double pricePerDay)
        {
            IDincrement++;
            dealID = IDincrement;
            this.carID = carID;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.pricePerDay = pricePerDay;
        }
        public Deal()
        {
            dealID = -1;
            carID = -1;
            dateFrom = DateTime.Now;
            dateTo = DateTime.Now;
            pricePerDay = 0;
        }
        public int DealID { get => dealID; set => dealID = value; }
        public int CarID { get => carID; set => carID = value; }
        public DateTime DateFrom { get => dateFrom; set => dateFrom = value; }
        public DateTime DateTo { get => dateTo; set => dateTo = value; }
        public double PricePerDay { get => pricePerDay; set => pricePerDay = value; }

        public string NoIDToString()
        {
            return $"{CarID}, {DateFrom.ToShortDateString()}, {DateTo.ToShortDateString()}, {PricePerDay}";

        }

        public override string ToString()
        {
            return $"{DealID}, {CarID}, {DateFrom.ToShortDateString()}, {DateTo.ToShortDateString()}, {PricePerDay}";
        }
    }
}
