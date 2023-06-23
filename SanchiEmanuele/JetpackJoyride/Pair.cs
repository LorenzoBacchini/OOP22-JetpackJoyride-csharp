namespace SanchiEmanuele.JetpackJoyride;

/// <summary>
/// Class to contain a pair of generic objects
/// </summary>
public class Pair<X, Y>
{
    public X x { get; private set; }
    public Y y { get; private set; }
    
    /// <summary>
    /// Constructor of the class Pair
    /// </summary>
    /// <param name="x">First object</param>
    /// <param name="y">Second object</param>
    public Pair(X x, Y y)
    {
        this.x = x;
        this.y = y;
    }

    public override int GetHashCode()
    {
        int prime = 31;
        int result = 1;
        result = prime * result + ((x == null) ? 0 : x.GetHashCode());
        result = prime * result + ((y == null) ? 0 : y.GetHashCode());
        return result;
    }

    public override bool Equals(Object obj)
    {
        if (this == obj)
        {
            return true;
        }
        if (obj == null)
        {
            return false;
        }
        if (this.GetType() != obj.GetType())
        {
            return false;
        }

        Pair<X, Y> other = (Pair<X,Y>)obj;
        if (x == null) {
            if (other.x != null) {
                return false;
            }
        } else if (!x.Equals(other.x)) {
            return false;
        }
        if (y == null) {
            if (other.y != null) {
                return false;
            }
        } else if (!y.Equals(other.y)) {
            return false;
        }
        return true;
    }
}