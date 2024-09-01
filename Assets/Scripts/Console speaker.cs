using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consolespeaker : MonoBehaviour
{
    bool counter = false;
    int number = 0;
    
    void Start()
    {
        print("Starting of counter:");
        StartCoroutine(CountWithDelay());
    }

    IEnumerator CountWithDelay()
    {
        while (!counter)
        {
            yield return new WaitForSeconds(1); // Пауза в одну секунду
            print(number + 1);
            number++;

            if (number >= 10)
            {
                counter = true;
                Debug.Log("Counting is ended - this is test log");
                Debug.LogWarning("Counting is ended - this is test log warning");
                // Debug.LogError("Counting is ended - this is test log error");
            }
        }
    }
}