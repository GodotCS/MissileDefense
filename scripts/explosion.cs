using Godot;
using System;

public class explosion : Area2D
{
    bulletBrain bulletBrain;
    player player;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        bulletBrain = (bulletBrain)GetNode("/root/game/bullets/bulletBrain");
        player = (player)GetNode("/root/game/player");
    }

    public void _on_explosion_area_entered(Area2D bullet)
    {
        var bulletType = (AnimatedSprite)bullet.GetNodeOrNull("AnimatedSprite");
        var explosionType = (AnimatedSprite)GetNode("AnimatedSprite");
        if((bulletType != null) && (bulletType.Animation == "enemy") && (bullet is bullet))
        {
            //bulletBrain.spawnExplosion(bullet.GlobalPosition,"enemy");
            bulletBrain.CallDeferred("spawnExplosion",bullet.GlobalPosition,"enemy");
            bullet.QueueFree();
            player.addScore();
        }
    }

    public void _on_AnimatedSprite_animation_finished()
    {
        QueueFree();
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
