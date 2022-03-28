using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicСonstants : MonoBehaviour
{
    public static Dictionary<int, Dictionary<string, Vector3>> dictObject;

    // Start is called before the first frame update
    void Start()
    {
        dictObject = new Dictionary<int, Dictionary<string, Vector3>>();
        dictObject.Add(0, new Dictionary<string, Vector3>());
        dictObject[0].Add("red", new Vector3(0, 0, Time.deltaTime));

        dictObject.Add(1, new Dictionary<string, Vector3>());
        dictObject[1].Add("red", new Vector3(4, 0, Time.deltaTime));

        dictObject.Add(2, new Dictionary<string, Vector3>());
        dictObject[2].Add("red", new Vector3(4, -4, Time.deltaTime));

        dictObject.Add(3, new Dictionary<string, Vector3>());
        dictObject[3].Add("red", new Vector3(0, -4, Time.deltaTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
