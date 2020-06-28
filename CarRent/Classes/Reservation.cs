using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class Reservation
    {
        public static int IDincrement; 
        private int reservationID;
        private int dealID;
        private int carID;
        private int customerID;
        private DateTime dateFrom;
        private DateTime dateTo;
        private double price;

        public Reservation(int reservationId,int dealID,int carID, int customerID, DateTime dateFrom, DateTime dateTo, double price)
        {
            this.reservationID = reservationId;
            this.dealID = dealID;
            this.carID = carID;
            this.customerID = customerID;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.price = price;
        }
        public Reservation(int dealID, int carID, int customerID, DateTime dateFrom, DateTime dateTo, double price)
        {
            IDincrement++;
            this.reservationID = IDincrement;
            this.dealID = dealID;
            this.carID = carID;
            this.customerID = customerID;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.price = price;
        }
        public Reservation()
        {
            this.reservationID = -1;
            this.dealID = -1;
            this.carID = -1;
            this.customerID = -1;
            this.dateFrom = DateTime.Now;
            this.dateTo = DateTime.Now;
            this.price = 0;
        }
        public int CarID { get => carID; set => carID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public DateTime DateFrom { get => dateFrom; set => dateFrom = value; }
        public DateTime DateTo { get => dateTo; set => dateTo = value; }
        public int DealID { get => dealID; set => dealID = value; }
        public double Price { get => price; set => price = value; }
        public int ReservationId
        {
            get => reservationID;
            set => reservationID = value;
        }

        public override string ToString()
        {
            return $"{ReservationId}, {DealID}, {CarID}, {CustomerID}, {DateFrom.ToShortDateString()}, {DateTo.ToShortDateString()}, {price}, {dateTo.Subtract(dateFrom).TotalDays * price} ";
        }
    }
}
