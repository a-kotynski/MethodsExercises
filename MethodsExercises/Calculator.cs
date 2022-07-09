//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2484612#content
namespace MethodsExercises
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}