using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : StateMachine
{
    public bool debugMode = false;
    public state debugState;
    public UIManager UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GetComponent<UIManager>();

        if (!debugMode)
        {
            SetState(new WordSelect(this));
        } else
        {
            switch (debugState)
            {
                case state.SelectWord:

                    SetState(new WordSelect(this));
                    break;

                case state.CrossHair:

                    SetState(new Crosshair(this));
                    break;

                case state.SpellWord:

                    SetState(new SpellWord(this));
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum state
    {
        SelectWord, CrossHair, SpellWord
    }
}
