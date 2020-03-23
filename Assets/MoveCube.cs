using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hei, jeg er MoveCube");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, Time.deltaTime * 1f, 0);
    }
}
