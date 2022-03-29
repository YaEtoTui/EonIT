using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using UnityEngine.UI;

public class playerMove : MonoBehaviour {

	private bool isDoStepDown = false;
	private float progress = 0;
	public float Step;
	private bool isComplete = true;
	private int randomCountSteps;
	private int stepsCounter = 0;
	private int nextCellsIndex = 1;

	public Text text;
	// Use this for initialization
	void Start () {
		transform.position = Data.Cells[Data.CurrentCellsIndex];
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    isComplete = false;
        //    randomCountSteps = Data.RandomCountSteps.Next(1, 6);
        //    stepsCounter = 0;
        //}
		if (isDoStepDown)
		{
			isComplete = false;
			randomCountSteps = Data.RandomCountSteps.Next(1, 6);
			text.text = randomCountSteps.ToString();//пишет кол-во ходов
			stepsCounter = 0;
			isDoStepDown = false;
		}
		if (!isComplete)
        {
			transform.position = Vector2.Lerp(Data.Cells[Data.CurrentCellsIndex], Data.Cells[nextCellsIndex], progress);
			progress += Step;
		}
		if (Data.Cells[nextCellsIndex].x == transform.position.x  && Data.Cells[nextCellsIndex].y == transform.position.y)
        {
			stepsCounter++;
			Data.CurrentCellsIndex = nextCellsIndex;
			nextCellsIndex++;
			progress = 0;
			if (randomCountSteps == stepsCounter)
            {
				isComplete = true;
            }
			if (nextCellsIndex == Data.Cells.Length)
				nextCellsIndex = 0;
			Thread.Sleep(100);
        }
	}

	public void OnDoStepDuttonDown()
	{
		if (isComplete)
        {
			isDoStepDown = true;
		}
	}
}

public static class Data
{
	public static System.Random RandomCountSteps = new System.Random();
	public static int CurrentCellsIndex = 0;
	public static Vector2[] Cells = new Vector2[] 
	{
		new Vector2(1.14f, -4.71f),
		new Vector2(1.95f, -4.71f),
		new Vector2(2.91f, -4.71f),
		new Vector2(3.66f, -4.11f),
		new Vector2(3.67f, -3.05f),
		new Vector2(4.02f, -2.38f),
		new Vector2(4.88f, -2.14f),
		new Vector2(5.93f, -1.84f),
		new Vector2(6.59f, -1.13f),
		new Vector2(6.41f, -0.28f),
		new Vector2(6.05f, 0.54f),
		new Vector2(5.95f, 1.47f),
		new Vector2(6.45f, 2.31f),
		new Vector2(6.23f, 3.18f),
		new Vector2(5.52f, 3.69f),
		new Vector2(4.65f, 4.14f),
		new Vector2(3.71f, 4.39f),
		new Vector2(2.9f, 4.53f),
		new Vector2(1.98f, 4.59f),
		new Vector2(1.12f, 4.76f),
		new Vector2(0.28f, 4.98f),
		new Vector2(-0.42f, 5.22f),
		new Vector2(-1.17f, 5.4f),
		new Vector2(-1.88f, 5.54f),
		new Vector2(-2.82f, 5.7f),
		new Vector2(-3.82f, 5.71f),
		new Vector2(-4.68f, 5.61f),
		new Vector2(-5.19f, 4.96f),
		new Vector2(-5.12f, 3.97f),
		new Vector2(-4.83f, 3.14f),
		new Vector2(-4.4f, 2.13f),
		new Vector2(-5.38f, 1.55f),
		new Vector2(-6.77f, 1.48f),
		new Vector2(-7.57f, 1f),
		new Vector2(-7.8f, 0.18f),
		new Vector2(-7.66f, -0.76f),
		new Vector2(-7.31f, -1.64f),
		new Vector2(-6.96f, -2.15f),
		new Vector2(-6.63f, -2.65f),
		new Vector2(-6.28f, -3.27f),
		new Vector2(-5.79f, -3.9f),
		new Vector2(-5.25f, -4.37f),
		new Vector2(-4.38f, -4.51f),
		new Vector2(-3.41f, -4.32f),
		new Vector2(-2.4f, -4.25f),
		new Vector2(-1.69f, -4.34f),
		new Vector2(-0.88f, -4.45f),
		new Vector2(0.12f, -4.61f),
	};
}