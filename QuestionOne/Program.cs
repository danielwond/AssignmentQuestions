Console.Write("Please Enter the hour: ");
int hour = int.Parse(Console.ReadLine());
Console.Write("Enter the Minutes: ");
int minute = int.Parse(Console.ReadLine());

double result = CalculateHour(hour, minute);

//to find the smaller angle
if (result > 180)
{
    result = 360 - result;
}

Console.WriteLine($"The Angle is {result} degrees");
Console.ReadKey();

double CalculateHour(int hour, double min)
{
    //the formula that we use to calculate the hour is 30 * h
    //and the formula to calculate the minute of the hour is 0.5 * m

    //and the formula to calculate the minute is 6m
    //so we can condence it into the total.. meaning we can add the hour and the minute of the hour.. and subtract the minute from it..
    //meaning it can be 30h + 0.5m - 6m

    //hence the formula comes to 30h - 5.5m
    var hr = (hour * 30) - 5.5 * min;
    return hr;
}