namespace CSharpExercises.Math
{
   
    public class Calculator
    {
        public int add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int subtract(int a, int b)
        {
            return a - b;
        }
    }
}
