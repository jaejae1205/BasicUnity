using UnityEngine;

public class LoopExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for (int i = 1; i <= 10; i++)
        //{
        //    Debug.Log("Count : " + i);
        //}

        int counter = 0;

        while (counter < 5)
        {
            Debug.Log("While Count : " + counter);
            counter++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
