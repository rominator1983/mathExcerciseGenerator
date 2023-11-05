var random = new Random();

for (var i = 0; i < 70; i++)
{
    var excerciseType = random.Next(100);

    if (excerciseType < 50)
    {
        // Addition
        var summand1 = random.Next(13);
        var summand2 = random.Next(13);
        var summand3 = random.Next(6);

        if (random.Next(100) > 90)
            Console.WriteLine($"{summand1} + {summand2} + {summand3} =   ");
        else
            Console.WriteLine($"{summand1} + {summand2} =   ");
    }
    else if (excerciseType < 90)
    {
        // Subtraction
        var minuend = random.Next(13);
        int subtrahend;
        do
        {
            subtrahend = random.Next(13);
        }
        while (subtrahend > minuend);

        Console.WriteLine($"{minuend} - {subtrahend} =   ");
    }
}
