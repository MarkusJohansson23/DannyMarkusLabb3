using System;
using System.Collections.Generic;

#nullable disable

namespace DannyMarkusLabb3.Models
{
    public partial class MoonMission
    {
        public string Spacecraft { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string CarrierRocket { get; set; }
        public string Operator { get; set; }
        public string MissionType { get; set; }
        public string Outcome { get; set; }
        public string Comment { get; set; }
    }
}
