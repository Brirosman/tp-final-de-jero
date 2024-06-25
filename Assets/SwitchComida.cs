using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchComida : MonoBehaviour
{
    public GameObject[] comida;
    public int CurrentIndex =-1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            CurrentIndex++;
            if (CurrentIndex < comida.Length)
            {
                activateByIndex(CurrentIndex);
                    desactivateByIndex(CurrentIndex);
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentIndex--;
            if(CurrentIndex < comida.Length)
            {
                activateByIndex(CurrentIndex);
                desactivateByIndex(CurrentIndex);
            }
        }
    }
    void DesactivateAll()
    {
        for (int i = 0; i < comida.Length; i++)
        {
            comida[i].SetActive(false); 
        }
    }
    void activateByIndex(int index)
    {
        comida[index].SetActive(true);
    }
    void desactivateByIndex( int index)
    {
        comida[index - 1].SetActive(false);
    }
}
