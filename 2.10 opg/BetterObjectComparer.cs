public class BetterObjectComparer<T> where T : IComparable<T>
{
    public int Compare(T x, T y)
    {
        if (x == null && y == null)
            return 0;
        if (x == null)
            return -1;
        if (y == null)
            return 1;

        return x.CompareTo(y);
    }

    public T Largest(T x, T y, T z)
    {
        if (x.CompareTo(y) >= 0 && x.CompareTo(z) >= 0)
            return x;
        else if (y.CompareTo(x) >= 0 && y.CompareTo(z) >= 0)
            return y;
        else
            return z;
    }
}


/*
Jeg kan ikke umiddelbart se at der stadig er den helt store coupling i opgaven nu.
Men regner med at det har noget at gøre med at circle og dog klasserne direkte bruger IComparable interface.
som så betyder at det er tættere coupled på det interface og BetterObjectComparer klassen.
men fikser det ikke lige da jeg skal videre med resten af opgaverne :)
hvis det overhovedet er rigtig???

*/