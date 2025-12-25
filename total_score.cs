int currentAssignments = 5;

        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        double sophiaSum = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5);

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        double nicolasSum = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5);

        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        double zahirahAverage = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5);

        int jeong1 = 91;
        int jeong2 = 95;
        int jeong3 = 97;
        int jeong4 = 93;
        int jeong5 = 94;

        double jeongAverage = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5);

        Console.WriteLine(new string('-', 40));

        Console.WriteLine($"{"ID",-4} {"Name",-10} {"Total Score",-12} Grade");
        Console.WriteLine(new string('-', 40));

        Console.WriteLine($"{1,-4} {"Sophia",-10} {sophiaSum,-12} A");
        Console.WriteLine($"{2,-4} {"Nicolas",-10} {nicolasSum,-12} B");
        Console.WriteLine($"{3,-4} {"Zahirah",-10} {zahirahAverage,-12} B");
        Console.WriteLine($"{4,-4} {"Jeong",-10} {jeongAverage,-12} A");    