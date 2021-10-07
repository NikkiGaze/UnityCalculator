using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            // Debug.Log(i);
        }
        // PrintMultiplyTable();
        int factorial = GetFactorial(3);
        Debug.Log(factorial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int GetFactorial(int n)
    {
        if (n > 1)
        {
            return n * GetFactorial(n - 1);
        }
        else
        {
            return 1;
        }
    }

    void PrintMultiplyTable()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Debug.Log($"{i} * {j} = {i * j}");
            }
        }
    }
}
