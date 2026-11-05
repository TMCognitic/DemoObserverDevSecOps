//Cours de Linq
namespace CollectionTools
{
    public static class MyEnumerable
    {
        public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            IList<TSource> result = new List<TSource>();

            foreach (TSource i in source)
            {
                if (predicate(i))
                    result.Add(i);
            }

            return result;
        }

        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            IList<TResult> result = new List<TResult>();

            foreach (TSource i in source)
            {
                result.Add(selector(i));
            }

            return result;
        }
    }
}
