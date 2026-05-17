class Program
{
    static string FindShortestTime(List<double> listOfTimes)
    {
        double time = listOfTimes[0];
        
        foreach (double n in listOfTimes)
        {
            double current = n;
            if (time > current)
            {
                time = current;
            }
        }
        return $"The shortest time is {time}.";
    }
    static void Main(string[] args)
    {
        List<double> runTimes = [9.1, 10.0];
        Console.WriteLine(FindShortestTime(runTimes));
    }
}