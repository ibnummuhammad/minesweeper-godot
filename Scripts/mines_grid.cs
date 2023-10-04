using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

class Dog
{
	public string Name { get; set; }
	public int Age { get; set; }
}

public partial class mines_grid : TileMap
{
	int angkaX;
	int angkaY;
	Dictionary<string, Godot.Vector2I> CELLS = new Dictionary<string, Godot.Vector2I>();

	public int columns = 8;
	public int rows = 8;
	public int numberOfMines = 8;

	int TILE_SET_ID = 0;
	int DEFAULT_LAYER = 0;

	List<Vector2I> cellWithMines = new List<Vector2I>() { };

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
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

		ClearLayer(DEFAULT_LAYER);

		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				Godot.Vector2I cell_coord = new Godot.Vector2I(i - rows / 2, j - columns / 2);
				SetTileCell(cell_coord, "DEFAULT");
			}
		}

		PlaceMine();
	}

	private void SetTileCell(Godot.Vector2I cell_coord, string cell_type)
	{
		SetCell(DEFAULT_LAYER, cell_coord, TILE_SET_ID, CELLS[cell_type]);
	}

	private void PlaceMine()
	{
		RandomNumberGenerator random = new RandomNumberGenerator();
		for (int i = 0; i < numberOfMines; i++)
		{
			Vector2I cellCoordinates = new Vector2I(random.RandiRange(-rows / 2, rows / 2 - 1), random.RandiRange(-columns / 2, columns / 2 - 1));

			while (cellWithMines.Contains(cellCoordinates))
			{
				cellCoordinates = new Vector2I(random.RandiRange(-rows / 2, rows / 2 - 1), random.RandiRange(-columns / 2, columns / 2 - 1));
			}

			cellWithMines.Add(cellCoordinates);
		}

		foreach (var cell in cellWithMines)
		{
			EraseCell(DEFAULT_LAYER, cell);
			SetCell(DEFAULT_LAYER, cell, TILE_SET_ID, CELLS["DEFAULT"], 1);
		}
	}

	public override void _Input(InputEvent @event)
	{
		if (@event == new InputEventMouseButton() || !@event.IsPressed())
		{
			return;
		}

		Vector2I clickedCellCoor = LocalToMap(GetLocalMousePosition());

		GD.Print(@event.GetType());

		if (@event is InputEventMouseButton eventMouseButton)
		{
			if (eventMouseButton.ButtonIndex.ToString() == "Left")
			{
				GD.Print("yang kiri");
				OnCellClicked(clickedCellCoor);
			}
			else if (eventMouseButton.ButtonIndex.ToString() == "Right")
			{
				GD.Print("yang kanan");
			}
		}
	}

	private void OnCellClicked(Vector2I cellCoor)
	{
		// GD.Print(cellWithMines);

		// GD.Print(cellCoor);
		// GD.Print(cellCoor.X);
		// GD.Print(cellCoor.Y);

		// GD.Print("dibawah");

		foreach (var cell in cellWithMines)
		{
			// GD.Print(cell);
			// GD.Print(cell.X);
			// GD.Print(cell.Y);
			// GD.Print("===========");
		}

		// GD.Print("diatas");

		var is_dead = cellWithMines.Any(cell => cell.X == cellCoor.X) || cellWithMines.Any(cell => cell.Y == cellCoor.Y);
		GD.Print(is_dead);
		GD.Print(is_dead.GetType());

		List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
		List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
		foreach (var num in evenNumbers)
		{
			// GD.Print(num);
		}

		List<Dog> dogs = new List<Dog>() {
			new Dog { Name = "Rex", Age = 4 },
			new Dog { Name = "Sean", Age = 0 },
			new Dog { Name = "Stacy", Age = 3 }
		 };
		var names = dogs.Select(x => x.Name);
		foreach (var name in names)
		{
			// GD.Print(name);

		}

		List<Dog> dogs1 = new List<Dog>() {
			new Dog { Name = "Rex", Age = 4 },
			new Dog { Name = "Sean", Age = 0 },
			new Dog { Name = "Stacy", Age = 3 }
		};
		var newDogsList = dogs1.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
		foreach (var item in newDogsList)
		{
			// GD.Print(item);
		}

		string[] namesTest = { "Bob", "Ned", "Amy", "Bill" };
		var result = namesTest.Any(n => n.StartsWith("B"));
		GD.Print(result);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
