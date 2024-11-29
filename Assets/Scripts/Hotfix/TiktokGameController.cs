using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TiktokGameController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI txtTest;
    void Start()
    {
        txtTest.text = "hello world!!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
