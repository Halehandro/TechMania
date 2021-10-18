using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class SD
    {
        public const string Role_Admin = "Admin";
        public const string Role_Customer = "Customer";
        public const string Role_Employee = "Employee";

        public const string Local_InitialBooking = "InitialPhoneOrderingInfo";
        public const string Local_PhoneOrderDetails = "PhoneOrderDetails";
        public const string Local_Token = "JWT Token";
        public const string Local_UserDetails = "User Details";

        public const string Status_Pending = "Pending";
        public const string Status_Ordered = "Ordered";
        public const string Status_OrderConfirmed = "Order Confirmed";
        public const string Status_Order_Completed = "Order Sent";
        public const string Status_NoShow = "NoShow";
        public const string Status_Cancelled = "Cancelled Order";
    }
}
