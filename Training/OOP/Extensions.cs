using System.Security.Cryptography.X509Certificates;

namespace Training.OOP
{
    public static class Extensions 
    {
        public static T sum<T>(this T[] array)
        {
            dynamic sum = 0; 
            foreach (var item in array)
            {
                sum += item; 
            }
            return sum;
        }

        delegate T Operation<T> (T a, T b);

        static T substraction<T>(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }


    }
}
