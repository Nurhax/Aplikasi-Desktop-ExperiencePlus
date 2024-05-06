
namespace LibraryTubes.Searching
{
    public static class Searchings
    {
        
     
            public static T Search<T>(T[] array, Func<T, bool> predicate)
            {
                foreach (var item in array)
                {
                    if (predicate(item))
                    {
                        return item;
                    }
                }
                return default(T);
            }
   
    }
}
