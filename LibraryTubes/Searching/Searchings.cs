namespace LibraryTubes.Searching
{
    public class Searchings<T>
    {
        public int SequentialSearch(List<T> arr, string target)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Equals(target))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
