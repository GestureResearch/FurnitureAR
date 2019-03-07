using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    public GameObject next, prev, it, slider;
    
    static int current = 0;
    
    public void NextModel()
    {
        current = (current + 1)%4;
        SwitchModel();        
    }
    
    public void PrevModel()
    {
        current = (current - 1)%4;
        if(current == -1)
            current = 3;
        SwitchModel();        
    }
    
    public void ScaleObject(float factor)
    {
        it.transform.GetChild(current).localScale = new Vector3(factor, factor, factor);;    
    }
    
    void SwitchModel()
    {
        for(int i = 0; i < 4; i++)
        {                               
            it.transform.GetChild(i).gameObject.SetActive(false);
            if(i == current)
                it.transform.GetChild(i).gameObject.SetActive(true);        
        }     
    }
}
