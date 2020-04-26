using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class Members
    {
        public int MemberId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Active { get; set; }
        public string ResetToken { get; set; }
        public string ResetComplete { get; set; }
        public string Lat { get; set; }
        public string Longi { get; set; }
        public string Rol { get; set; }
    }
}
