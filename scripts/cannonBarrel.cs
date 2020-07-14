using Godot;
using System;

public class cannonBarrel : Sprite
{
    bulletBrain bulletBrain;
    player player;
    scenes scenes = new scenes();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        bulletBrain = (bulletBrain)GetNode("/root/game/bullets/bulletBrain");
        player = (player)GetNode("/root/game/player");
    }

    public override void _Input(InputEvent _inputEvent)
    {
        if((_inputEvent.IsActionPressed("click")) && (player.canShoot == true))
        {
            shootAtMouse();
        }
    }

    public void shootAtMouse()
    {
        bulletBrain.spawnBullet(GlobalPosition, GetGlobalMousePosition(), "player");
        player.canShoot = false;

        var bulletStopper = (Area2D)scenes._sceneBulletStopper.Instance();
        GetNode("/root/game/bullets").AddChild(bulletStopper);
        bulletStopper.GlobalPosition = GetGlobalMousePosition();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        LookAt(GetGlobalMousePosition());
    }
}
