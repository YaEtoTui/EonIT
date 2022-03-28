using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    //��� ������.
    public GameObject Circle;

    //����� ������� ���������� ����� �������, ��������� �� ������ ������
    //public Dictionary<int, Dictionary<string, Vector3>> dictObject = Basic�onstants.dictObject;

    //���������� �����.
    public int NumbersOfMoves;

    private int ActualMove;

    private int CurrentCell = 0;

    //����� ������� ����� ���������� �� ������� ����� ������.� ����� ����� ��������
    public void OnButtonDown()
    {
        //��������� ���� �� 1 �� 6
        NumbersOfMoves = Random.Range(1, 6);//���� ���-�� �������, ����� �� ������� �������������� �����

        /*�� ������� ������ ����������� �� ����������� ���� � ���������� _ ��� _ �������(���������)
         * */
        if (CurrentCell == 0)
            Circle.transform.position = new Vector3(4, 0, Time.deltaTime);
        else if (CurrentCell == 1)
            Circle.transform.position = new Vector3(4, -4, Time.deltaTime);
        else if (CurrentCell == 2)
            Circle.transform.position = new Vector3(0, -4, Time.deltaTime);
        else
            Circle.transform.position = new Vector3(0, 0, Time.deltaTime);

        //Circle.transform.position = dictObject[CurrentCell]["red"];//��� ��� ����� ���������, �� ���(

        //������� ������(�� 0 -> ���� 3(�� ������ ���� 4)
        if (CurrentCell == 3)
            CurrentCell = 0;
        else
            CurrentCell++;

        //��� ������������� ������� ��������
        //������ � ������� ������, �� �� ����������
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
