using Godot;
using System;

public class cloud : AnimatedSprite
{
    public int speed = 400;
    Vector2 velocity = new Vector2(0,0);

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        speed = Convert.ToInt32(GD.RandRange(100,200));
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float _delta)
    {
        velocity = Vector2.Right.Rotated(Rotation) * speed * _delta;
        Translate(velocity);
    }
}
