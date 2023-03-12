using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTwo : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 12; i++)
        {
            if (i == 9)
            {
                Debug.Log("It's my birthday month!");

                for (int j = 1; j <= 30; j++)
                {
                    if (j == 9)
                    {
                        Debug.Log("It's my birthday!");
                    }
                    else
                    {
                        Debug.Log(j);
                    }
                }
            }
            else
            {
                Debug.Log(i);
            }
        }
    }

    void Update()
    {

    }
}