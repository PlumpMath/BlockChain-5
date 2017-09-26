﻿using Nethereum.ABI.FunctionEncoding.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingAPI.Models
{
    public class TrackingDetails
    {

        [Parameter("address", "containerId", 1, false)]
        public string Id { get; set; }

        [Parameter("int", "weight", 2, false)]
        public int Weight { get; set; }
        [Parameter("string", "desc", 3, false)]
        public string Description { get; set; }
        [Parameter("string", "datetime", 4, false)]
        public string TransactionTime { get; set; }

        [Parameter("int", "Status", 5, false)]
        public int Status
        {
            get; set;
        }
        [Parameter("string", "name", 6, false)]
        public string ContainerName { get; set; }
        [Parameter("string", "source", 7, false)]
        public string Source { get; set; }
        [Parameter("string", "destination", 8, false)]
        public string Destination { get; set; }
    }
}