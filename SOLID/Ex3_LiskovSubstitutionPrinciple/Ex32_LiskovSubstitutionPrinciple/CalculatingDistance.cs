using System;

namespace Ex32_LiskovSubstitutionPrinciple
{
    public class CalculatingDistance
    {
        int time;
        public CalculatingDistance(int time)
        {
            this.time = time;
        }

        public void Calculate(Bird bird)
        {
            for (int i = 0; i < time; i++)
            {
                bird.Move();
            }

            Console.Title = ($"\n\n\nРасстояние:  {bird.Spacing} {bird.Position}");
        }

    }
}
