using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playfield
{
	
	public static int w = 10; // this is the width
	public static int h = 10; // this is the height
	public static Element[,] elements = new Element[w, h];
	
	// Uncover all Mines
	public static void uncoverMines()
	{
		foreach (Element elem in elements)
			if (elem.mine >= 1) elem.loadTexture(0);
	}
}


