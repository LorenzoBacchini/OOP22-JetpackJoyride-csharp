using AnnibaliniLorenzo.JetpackJoyride.Api;
using BacchiniLorenzo.JetpackJoyride.Impl;
using BurreliMattia.JetpackJoyride.Api;

namespace AnnibaliniLorenzo.JetpackJoyride.Impl;

/// <summary>
/// Standard scientist implementation.
/// </summary>
public  class ScientistImpl : GameObjectImpl, IScientist
{

    private IDirection _direction;
    private bool _life;

    /// <summary>
    /// Standard constructor for the scientist.
    /// </summary>
    /// <param name="direction"> direction of the scientist </param>
    /// <param name="point"> point2D object </param>
    /// <param name="velocity"> velocity vector </param>
    /// <param name="hitbox"> hitbox object </param>
    public ScientistImpl( IDirection direction,  Point2d point,  Vector2d velocity,  IHitbox hitbox) : base(point, velocity, hitbox)
    {
        if (direction == null) {
            throw new ArgumentException("Input can't be empty");
        } else {
            this._direction = direction;
            this._life = true;
        }
    }

    public IDirection GetDirection() {
        return this._direction;
    }

    public bool IsAlive() {
        return this._life;
    }

    public void KillScientist() {
        this._life = false;
    }

   public void NextPosition() {
        if (_direction == IDirection.Left)
        {
            Pos = Pos.Sub(Vel);
        } else if (_direction == IDirection.Right)
        {
            Pos = Pos.Sum(Vel);
        }
    }
}