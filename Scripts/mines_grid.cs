using Godot;
using System;

public partial class mines_grid : TileMap
{
	public int columns = 8;
	public int rows = 8;
	public int number_of_mines = 8;

	int TILE_SET_ID = 0;
	int DEFAULT_LAYER = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ClearLayer(DEFAULT_LAYER);

		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				Console.WriteLine(i);
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
