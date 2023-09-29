using Godot;
using System;

public partial class mines_grid : TileMap
{
	public float columns = 8;
	public float rows = 8;
	public float number_of_mines = 8;

	var TILE_SET_ID = 0;
	var DEFAULT_LAYER = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ClearLayer(DEFAULT_LAYER);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
