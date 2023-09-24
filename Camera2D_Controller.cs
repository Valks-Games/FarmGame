using FarmGame;
using Godot;
using System;

public partial class Camera2D_Controller : Camera2D
{

	public CharacterBody2D Player;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        Player = (CharacterBody2D)GetNode("../Node2D_Player/Player");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        // Set main camera to center of players position
		Position = Player.GlobalPosition;
	}
}
