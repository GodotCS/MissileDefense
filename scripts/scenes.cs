using Godot;
using System;

public class scenes : Node
{
    public PackedScene _sceneBullet = (PackedScene)GD.Load("res://scenes/bullet.tscn");
    public PackedScene _sceneExplosion = (PackedScene)GD.Load("res://scenes/explosion.tscn");
    public PackedScene _sceneBulletStopper = (PackedScene)GD.Load("res://scenes/bulletStopper.tscn");
    public PackedScene _sceneCloud = (PackedScene)GD.Load("res://scenes/cloud.tscn");
}
