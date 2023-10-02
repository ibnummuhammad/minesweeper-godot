using Godot;
using System;
using System.Collections.Generic;
using System.Numerics;

public partial class mines_grid : TileMap
{
	int angkaX;
	int angkaY;
	Dictionary<string, string> CELLS = new Dictionary<string, string>() {
		{"1", "Vector2I"},
		{"2", "Vector2I"},
		{"3", "Vector2I"},
		{"4", "Vector2I"},
		{"5", "Vector2I"},
		{"6", "Vector2I"},
		{"7", "Vector2I"},
		{"8", "Vector2I"},
		{"CLEAR", "Vector2I"},
		{"MINE_RED", "Vector2I"},
		{"FLAG", "Vector2I"},
		{"MINE", "Vector2I"},
		{"DEFAULT", "Vector2I"},
	};

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
