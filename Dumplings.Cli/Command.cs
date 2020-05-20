﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dumplings.Cli
{
    public enum Command
    {
        Sync,             // Syncs the Scanner files from where it was left off.
        Resync,           // Resync the Scanner files from Wasabi's launch.
        Check,            // Cross checks the Scanner files to make sure of no bugs.
        MonthlyVolumes,   // Calculate the monthly volumes of different kind of coinjoins.
        FreshBitcoins,    // Calculate how much previously not coinjoined bitcoins come to different kind of coinjoins monthly.
        NeverMixed,       // Calculate monthly volume of bitcoins those were intended to be mixed, but never got mixed.
        CoinJoinEquality  // Calculate monthly volume of equality gained on bitcoins.
    }
}
