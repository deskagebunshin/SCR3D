using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : StateMachine
{

    public UIManager UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GetComponent<UIManager>();
        SetState(new WordSelect(this));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
