using Godot;
using System;

public partial class Player : Area2D
{
	[Export]
	public int Speed { get; set; } = 400;

	public Vector2 ScreenSize { get; set; }
}
