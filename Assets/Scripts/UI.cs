using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{

    public Text m_Text;
    public bool isShootType = false;
    // Start is called before the first frame update

    void Start()
    {
        m_Text.text = "�ܹ�";
    }
    // Update is called once per frame
    void Update()
    {
       


        if (Input.GetKeyDown(KeyCode.B))
        {
            isShootType = !isShootType;
            m_Text.text = isShootType ? "����" : "�ܹ�";

        }

       
    }
}
