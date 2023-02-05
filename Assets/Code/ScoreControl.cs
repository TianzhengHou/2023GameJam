using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreControl : MonoBehaviour
{
    private TMP_Text m_TextComponent;
    public float scoreAmount;
    public float incresePerSecond;
    public RootControl rootControl;

    // Start is called before the first frame update
    void Start()
    {
        m_TextComponent = GetComponent<TMP_Text>();
        scoreAmount = 0f;
        incresePerSecond = 1f;
        rootControl = GameObject.FindObjectOfType<RootControl>();
    }

    // Update is called once per frame
    void Update()
    {
        m_TextComponent.text = "Score: " + (int)scoreAmount;
        scoreAmount = -1 * rootControl.transform.position.y;
    }
}
