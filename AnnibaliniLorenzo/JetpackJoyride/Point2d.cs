using System;
using AnnibaliniLorenzo.JetpackJoyride;

namespace AnnibaliniLorenzo.JetpackJoyride
{
    
}
/// <summary>
/// This is a class to model two-dimensional point.
/// </summary>
public class Point2d {

    private double _x, _y;

    /// <summary> getter for x. </summary>
    /// <return> x coordinate </return>
    public double GetX() {
        return _x;
    }

    /// <summary> setter for x. </summary>
    /// <param name="x"> x coordinate </param>
    public void SetX( double x) {
        this._x = x;
    }

    /// <summary> getter for y. </summary>
    /// <return> y coordinate </return>
    public double GetY() {
        return _y;
    }

    /// <summary> setter for y. </summary>
    /// <param name="y"> y coordinate </param>
    public void SetY( double y) {
        this._y = y;
    }

    /// <summary> Constructor to create a 2d point (x,y). </summary>
    /// <param name="x"> x coordinate </param>
    /// <param name="y"> y coordinate </param>
    public Point2d( double x,  double y) {
        this._x = x;
        this._y = y;
    }

    /// <summary> Method to sum a vector v to this point. </summary>
    /// <param name="v"> vector to sum </param>
    /// <return> new point </return>
    public Point2d Sum( Vector2d v) {
        return new Point2d(this._x + v.GetX(), this._y + v.GetY());
    }

    /// <summary> Method to subtract a vector v to this point. </summary>
    /// <param name="v"> vector to subtract </param>
    /// <return> new point </return>
    public Point2d Sub( Vector2d v) {
        return new Point2d(this._x - v.GetX(), this._y - v.GetY());
    }

    /// <summary> Method to print this point. </summary>
    /// <return> this point as a string </return>
    public String ToString() {
        return "Point2d(" + this._x + "," + this._y + ")";
    }

}