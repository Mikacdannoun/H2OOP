
public class PiCalc
{
    /// <summary>
    /// Executes the calculation of an 
    /// approximate value of pi.
    /// </summary>
    /// <param name="iterations">Number of iterations to perform</param>
    /// <returns>Approximate value of pi</returns>
    /// 

    public double Calculate(int iterations)
    {
        int insideUnitCircle = Iterate(iterations);
        return insideUnitCircle * 4.0 / iterations;
    }
    public double CalculateWith4People(int iterations)
    {
        int[] insideCircleCounts = new int[4]; // Array to store circle count for each person
        Task[] tasks = new Task[4]; // Create 4 tasks, 1 for each person doing a job

        int iterationsPerPerson = iterations / 4; // Divide iterations among the 4 people

        for (int i = 0; i < 4; i++) // Start the iterations(throwing darts) tasks for each person
        {
            int index = i; 
            tasks[i] = Task.Run(() =>
            {
                insideCircleCounts[index] = Iterate(iterationsPerPerson);
            });
        }

        Task.WaitAll(tasks); // wait for all

        int totalInsideCircle = 0;
        for (int i = 0; i < 4; i++) // sum up circle count from all 4 people
        {
            totalInsideCircle += insideCircleCounts[i];
        }

        return totalInsideCircle * 4.0 / iterations;
    }

    /// <summary>
    /// Perform a number of "dart-throwing" simulations.
    /// </summary>
    /// <param name="iterations">Number of dart-throws to perform</param>
    /// <returns>Number of throws within the unit circle</returns>
    public int Iterate(int iterations)
    {
        Random _generator = new Random(Guid.NewGuid().GetHashCode());
        int insideUnitCircle = 0;

        for (int i = 0; i < iterations; i++)
        {
            double x = _generator.NextDouble();
            double y = _generator.NextDouble();

            if (x * x + y * y < 1.0)
            {
                insideUnitCircle++;
            }
        }

        return insideUnitCircle;
    }
}
