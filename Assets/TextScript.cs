using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{

    Renderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro firstText = GetComponent<TextMeshPro>();
        firstText.SetText("±èµ¿Çö ¾È³ç");

        m_Renderer = GetComponent<Renderer>();
        // m_Renderer.enabled = false;

        if (m_Renderer.isVisible)
        {
            print("Object is visible");
        }
        else print("Object is no longer visible");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 