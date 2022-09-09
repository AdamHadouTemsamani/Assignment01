namespace MyApp;

public static class Iterators
{
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
    {
        foreach(IEnumerable<T> i in items)
        {
            foreach(var v in i)
            {
                yield return v;
            }
        }
        
        
    }

    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
    {
        predicate = Predicate
        foreach(IEnumerable<T> i in items)
        {
            if(predicate){
                yield return i;
            }
        }
    }
    public delegate bool Predicate<in T>(T obj);



    
}