using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer.Entities
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Reservaion
    {

        public int ReservationtId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public int NumberOfGuest { get; set; }
        public string StreetAddress { get; set; }
        public string AprtSuite { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string RoomType { get; set; }
        public string RoomFloor { get; set; }
        public string RoomNumber { get; set; }
        public float TotalBill { get; set; }
        public string PaymentType { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string CardExp { get; set; }
        public string CardCVC { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime LeaveTime { get; set; }
        public bool CheckIn { get; set; }
        public int BreakFast { get; set; }
        public int Lunch { get; set; }
        public int Dinner { get; set; }
        public bool Cleaning { get; set; }
        public bool Towel { get; set; }
        public bool SSurprise { get; set; }
        public bool SupplyStatus { get; set; }
        public int FoodBill { get; set; }


    }
}
