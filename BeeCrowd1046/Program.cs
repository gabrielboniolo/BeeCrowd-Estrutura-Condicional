namespace BeeCrowd1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startTime, finalTime, duration;
            duration = 0;
            string[] time = Console.ReadLine().Split(' ');
            startTime = int.Parse(time[0]);
            finalTime = int.Parse(time[1]);
            if(startTime >= finalTime)
            {
                duration = (finalTime + 24) - startTime;
            }
            else
            {
                duration = finalTime-startTime;
            }
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duration);
        }
    }
}