using Godot;
using System.Collections.Generic;

public partial class mines_grid : TileMap
{
	int angkaX;
	int angkaY;
	Dictionary<string, Godot.Vector2I> CELLS = new Dictionary<string, Godot.Vector2I>();
	Dictionary<string, string> myDict = new Dictionary<string, string>();

	public int columns = 8;
	public int rows = 8;
	public int number_of_mines = 8;

	int TILE_SET_ID = 0;
	int DEFAULT_LAYER = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		myDict.Add("Australia", "Canberra");
		myDict.Add("Belgium", "Brussels");
		myDict.Add("Netherlands", "Amsterdam");
		myDict.Add("China", "Beijing");
		myDict.Add("Russia", "Moscow");
		myDict.Add("India", "New Delhi");

		GD.Print(myDict["Australia"]);

		// foreach (KeyValuePair<string, string> kvp in myDict)
		// {
		// 	GD.Print(kvp.Key);
		// 	// Console.WriteLine("Key = {0}, Value = {1}",
		// 	// 				  kvp.Key, kvp.Value);
		// }

		// int value = dictionary.Get("one");

		CELLS.Add("1", new Godot.Vector2I(0, 0));
		CELLS.Add("2", new Godot.Vector2I(1, 0));
		CELLS.Add("3", new Godot.Vector2I(2, 0));
		CELLS.Add("4", new Godot.Vector2I(3, 0));
		CELLS.Add("5", new Godot.Vector2I(4, 0));
		CELLS.Add("6", new Godot.Vector2I(0, 1));
		CELLS.Add("7", new Godot.Vector2I(1, 1));
		CELLS.Add("8", new Godot.Vector2I(2, 1));
		CELLS.Add("CLEAR", new Godot.Vector2I(3, 1));
		CELLS.Add("MINE_RED", new Godot.Vector2I(4, 1));
		CELLS.Add("FLAG", new Godot.Vector2I(0, 2));
		CELLS.Add("MINE", new Godot.Vector2I(1, 2));
		CELLS.Add("DEFAULT", new Godot.Vector2I(2, 2));

		// int value = CELLS.Get("one");
		GD.Print(CELLS["2"]);

		ClearLayer(DEFAULT_LAYER);

		GD.Print("disini");
		// foreach (string key in CELLS.Keys())
		// {
		// 	Console.WriteLine(key);
		// }
		// GD.Print(CELLS);
		GD.Print(CELLS.Count);

		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				Godot.Vector2I cell_coord = new Godot.Vector2I(i - rows / 2, j - columns / 2);
				// GD.Print(new Godot.Vector2I(i - rows / 2, j - columns / 2));
				// GD.Print(new Godot.Vector2I(i - rows / 2, j - columns / 2).GetType());
			}
		}
	}

	// private void SetTileCell(Godot.Vector2I cell_coord, string cell_type)
	// {
	// 	SetCell(DEFAULT_LAYER, cell_coord, TILE_SET_ID, CELLS.ke);
	// }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
