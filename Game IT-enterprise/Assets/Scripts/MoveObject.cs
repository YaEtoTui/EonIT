using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    //Наш объект.
    public GameObject Circle;

    //хотел хранить координаты через словарь, отсылаясь на другой скрипт
    //public Dictionary<int, Dictionary<string, Vector3>> dictObject = BasicСonstants.dictObject;

    //Количество ходов.
    public int NumbersOfMoves;

    private int ActualMove;

    private int CurrentCell = 0;

    //Метод который будет выполнятся по нажатию нашей кнопки.Я делал через рекурсию
    public void OnButtonDown()
    {
        //Рандомные ходы от 1 до 6
        NumbersOfMoves = Random.Range(1, 6);//надо как-то сделать, чтобы по нажатию генерировалось число

        /*по нажатию кнопки пермещается по координатам ниже с интервалом _ или _ секунды(недопонял)
         * */
        if (CurrentCell == 0)
            Circle.transform.position = new Vector3(4, 0, Time.deltaTime);
        else if (CurrentCell == 1)
            Circle.transform.position = new Vector3(4, -4, Time.deltaTime);
        else if (CurrentCell == 2)
            Circle.transform.position = new Vector3(0, -4, Time.deltaTime);
        else
            Circle.transform.position = new Vector3(0, 0, Time.deltaTime);

        //Circle.transform.position = dictObject[CurrentCell]["red"];//вот так думал получится, но нет(

        //текущая ячейка(от 0 -> макс 3(по логике макс 4)
        if (CurrentCell == 3)
            CurrentCell = 0;
        else
            CurrentCell++;

        //тут планировалось сделать рекурсию
        //вместе с номером кубика, но не получилось
        if (NumbersOfMoves != ActualMove)
        {
            ActualMove++;
            Invoke("OnButtonDown", 1);
        }
        else
            ActualMove = 0;
    }

    public void Start()
    {
    }

    public void Update()
    {

    }

    //public Vector3 fromPosition = new Vector3(0,0,0);
    //public Vector3 toPosition = new Vector3(1,1,0);
}
