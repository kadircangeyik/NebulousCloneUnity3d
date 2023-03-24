using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainPanel : MonoBehaviour
{
    public string link;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openURL()
    {

        Application.OpenURL(link);
        Debug.Log("is this working?");
    }
}
