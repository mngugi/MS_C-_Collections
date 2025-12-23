using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

class Records
{
    static void Main()
    {
        int currentAssignments = 5;

        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        double sophiaAverage = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / (double)currentAssignments;

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        double nicolasAverage = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / (double)currentAssignments;

        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        double zahirahAverage = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / (double)currentAssignments;

        int jeong1 = 91;
        int jeong2 = 95;
        int jeong3 = 97;
        int jeong4 = 93;
        int jeong5 = 94;

        double jeongAverage = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / (double)currentAssignments;

        Console.WriteLine($"{"Id",-5} {"Name",-6} {"Average",-8} Grade");


    }
}