using Godot;
using System;

public class bulletStopper : Area2D
{
    bulletBrain bulletBrain;
    player player;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        bulletBrain = (bulletBrain)GetNode("/root/game/bullets/bulletBrain");
        player = (player)GetNode("/root/game/player");
        
    }

    public void _on_bulletStopper_area_entered(Area2D bullet)
    {
        var bulletType = (AnimatedSprite)bullet.GetNodeOrNull("AnimatedSprite");
        if((bulletType != null) && (bulletType.Animation == "player") && (bullet is bullet))
        {
            //bulletBrain.spawnExplosion(GlobalPosition,"player");
            bulletBrain.CallDeferred("spawnExplosion",GlobalPosition,"player");
            bullet.QueueFree();
            QueueFree(); //Destroys bulletStopper

            player.canShoot = true;
        }



    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
