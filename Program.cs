var random = new Random();

// for pasting in writer with abc font type size 18 to get one page
for (var i = 0; i < 48; i++)
{
    var excerciseType = random.Next(100);

    if (excerciseType < 50)
    {
        // Addition

        if (random.Next(100) > 90)
        {
            var summand1 = random.Next(6);
            var summand2 = random.Next(6);
            var summand3 = random.Next(6);

            Console.WriteLine($"{summand1} + {summand2} + {summand3} =   ");
        }
        else
        {
            var summand1 = random.Next(13);
            var summand2 = random.Next(13);
            Console.WriteLine($"{summand1} + {summand2} =   ");
        }
    }
    else
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
