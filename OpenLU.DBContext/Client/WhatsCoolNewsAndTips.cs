﻿using System;
using System.Collections.Generic;

namespace OpenLU.DBContext.Client
{
    public partial class WhatsCoolNewsAndTips
    {
        public long? Id { get; set; }
        public long? IconId { get; set; }
        public long? Type { get; set; }
        public long? Localize { get; set; }
        public string GateVersion { get; set; }
        public long? LocStatus { get; set; }
    }
}
