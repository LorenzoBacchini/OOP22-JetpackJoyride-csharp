namespace AnnibaliniLorenzo.JetpackJoyride;


/// <summary> This is a class to model two-dimensional vector. </summary>

public class Vector2d {

    private double _x, _y;

    /// <summary> setter for x. </summary>
    /// <param name="x"> x coordinate </param>
    public void SetX( double x) {
        this._x = x;
    }

    /// <summary> setter for y. </summary>
    /// <param name="y"> y coordinate </param>
    public void SetY( double y) {
        this._y = y;
    }

    /// <summary> getter for x. </summary>
    /// <return name="x"> x coordinate </return>
    public double GetX() {
        return _x;
    }

    /// <summary> getter for y. </summary>
    /// <return name="y"> y coordinate </return>
    public double GetY() {
        return _y;
    }

    /// <summary> Constructor to create a 2d vector (x,y). </summary>
    /// <param name="x"> x coordinate </param>
    /// <param name="y"> y coordinate </param>
    public Vector2d( double x,  double y) {
        this._x = x;
        this._y = y;
    }

    /// <summary> Constructor to create a 2d vector from two points. </summary>
    /// <param name="to"> to point </param>
    /// <param name="from"> from point </param>
    public Vector2d( Point2d to,  Point2d from) {
        this._x = to.GetX() - from.GetX();
        this._y = to.GetY() - from.GetY();
    }

    /// <summary> Method to sum a vetcor v to this vector. </summary>
    /// <param name="v"> vector to sum </param>
    /// <return> a new vector </return>
    public Vector2d Sum( Vector2d v) {
        return new Vector2d(this._x + v._x, this._y + v._y);
    }

    /// <summary> Method to get the module of this vector. </summary>
    /// <return> the module of this vector </return>
    public double Module() {
        return (double) Math.Sqrt(this._x * this._x + this._y * this._y);
    }

    /// <summary> Method to get the normalized vector of this vector. </summary>
    /// <return> a new vector </return>
    public Vector2d GetNormalized() {
         double module = this.Module();
        return new Vector2d(this._x / module, this._y / module);
    }

    /// <summary> Method to multiply this vector for a fact factor. </summary>
    /// <param name="fact"> double fact</param>
    /// <return> a new vector </return>
    public Vector2d Mul( double fact) {
        return new Vector2d(this._x * fact, this._y * fact);
    }

    /// <summary> Method to print this vector. </summary>
    /// <return> this vector as a string </return>
    public String ToString() {
        return "Vector2d(" + this._x + "," + this._y + ")";
    }
}
