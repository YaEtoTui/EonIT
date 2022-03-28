using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    //Наш объект.
    public GameObject Circle;

    //Количество ходов.
    private int NumbersOfMoves;

    private int ActualMove;

    private int CurrentCell = -1;

    //Метод который будет выполнятся по нажатию нашей кнопки.
    public void OnButtonDown()
    {
        //текущая ячейка(от 0 -> макс 3(по логике макс 4)
        if (CurrentCell != 3)
            CurrentCell++;
        else
            CurrentCell = 0;

        /*по нажатию кнопки пермещается по координатам ниже с интервалом _ или _ секунды(недопонял)
         * */
        if (CurrentCell == 0)
            Circle.transform.position = new Vector3(4, 0, Time.deltaTime);
        else if (CurrentCell == 1)
            Circle.transform.position = new Vector3(4, -4, Time.deltaTime);
        else if (CurrentCell == 2)
            Circle.transform.position = new Vector3(0, -4, Time.deltaTime);
        else if (CurrentCell == 3)
            Circle.transform.position = new Vector3(0, 0, Time.deltaTime);


        //if (NumbersOfMoves != ActualMove)
        //{
        //    ActualMove++;
        InvokeRepeating("OnButtonDown", 4, 2);
    //}
    //    else
    //        ActualMove = 0;
    }

    public void Start()
    {
        //Рандомные ходы от 1 до 6
        NumbersOfMoves = Random.Range(1, 6);
    }

    public void Update()
    {

    }

    //public Vector3 fromPosition = new Vector3(0,0,0);
    //public Vector3 toPosition = new Vector3(1,1,0);
}
