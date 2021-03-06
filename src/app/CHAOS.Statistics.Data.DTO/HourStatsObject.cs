﻿using System;
using System.Collections.Generic;
using System.Text;
using CHAOS.Portal.DTO.Standard;
using CHAOS.Serialization;

namespace CHAOS.Statistics.Data.DTO
{
    public class HourStatsObject : Result
    {
        [Serialize("Count")]
        public uint Count { get; set; }

        [Serialize("StatsObjectID")]
        public uint StatsObjectID { get; set; }

        [Serialize("StatsObjectIdentifier")]
        public string StatsObjectIdentifier { get; set; }

        [Serialize("StatsObjectTypeID")]
        public uint StatsObjectTypeID { get; set; }

        [Serialize("StatsObjectTitle")]
        public string StatsObjectTitle { get; set; }


        public HourStatsObject(uint count, uint statsObjectID, string statsObjectIdentifier, uint statsObjectTypeID, string statsObjectTitle)
        {
            Count = count;
            StatsObjectID = statsObjectID;
            StatsObjectIdentifier = statsObjectIdentifier;
            StatsObjectTypeID = statsObjectTypeID;
            StatsObjectTitle = statsObjectTitle;
        }

        public HourStatsObject()
        {

        }

    }
}
