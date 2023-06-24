using System;
using AnnibaliniLorenzo.JetpackJoyride.Api;
using BacchiniLorenzo.JetpackJoyride.Api.IGameObject;
using BurelliMattia.JetpackJoyride.Api.IHitbox;

namespace AnnibaliniLorenzo.JetpackJoyride.Impl;

/// <summary>
/// Standard scientist implementation.
/// </summary>
public  class ScientistImpl : GameObjectImpl
{

    private Direction _direction;
    private bool _life;

    /// <summary>
    /// Standard constructor for the scientist.
    /// </summary>
    /// <param name="direction"> direction of the scientist </param>
    /// <param name="point"> point2D object </param>
    /// <param name="velocity"> velocity vector </param>
    /// <param name="hitbox"> hitbox object </param>
    public ScientistImpl( Direction direction,  Point2d point,  Vector2d velocity,  IHitbox hitbox) {
        super(point, velocity, hitbox);
        if (direction == null) {
            throw new IllegalArgumentException("Input can't be empty");
        } else {
            this._direction = direction;
            this._life = true;
        }
    }

    public Direction GetDirection() {
        return this._direction;
    }

    public Boolean IsAlive() {
        return this._life;
    }

    public void KillScientist() {
        this._life = false;
    }

   public void NextPosition() {
        if (_direction == Direction.Left) {
            super.SetPos(super.GetCurrentPos().Sub(super.GetCurrentVel()));
        } else if (_direction == Direction.Right) {
            super.SetPos(super.GetCurrentPos().Sum(super.GetCurrentVel()));
        }
    }
}