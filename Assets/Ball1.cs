using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //奥へ
        //transform.Translate(0f,0f,0.01f);
        //下へ
        transform.Translate(0f,-0.01f,0f);

    }
}
