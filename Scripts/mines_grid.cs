using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public partial class mines_grid : TileMap
{
	int angkaX;
	int angkaY;
	Dictionary<string, Godot.Vector2I> CELLS = new Dictionary<string, Godot.Vector2I>() {
		{"1", new Godot.Vector2I(0, 0)},
		{"2", new Godot.Vector2I(1, 0)},
		{"3", new Godot.Vector2I(2, 0)},
		{"4", new Godot.Vector2I(3, 0)},
		{"5", new Godot.Vector2I(4, 0)},
		{"6", new Godot.Vector2I(0, 1)},
		{"7", new Godot.Vector2I(1, 1)},
		{"8", new Godot.Vector2I(2, 1)},
		{"CLEAR", new Godot.Vector2I(3, 1)},
		{"MINE_RED", new Godot.Vector2I(4, 1)},
		{"FLAG", new Godot.Vector2I(0, 2)},
		{"MINE", new Godot.Vector2I(1, 2)},
		{"DEFAULT", new Godot.Vector2I(2, 2)},
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

		GD.Print("disini");
		GD.Print(CELLS.ElementAt(0));

		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				Godot.Vector2 cell_coord = new Godot.Vector2(i - rows / 2, j - columns / 2);
				GD.Print(cell_coord);
			}
		}
	}

	// private void SetTileCell(Godot.Vector2 cell_coord)
	// {
	// }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
