using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSelect : State
{

    private bool active = true;
    public WordSelect(GameController controller) : base(controller)
    {
    }

    // Start is called before the first frame update
    public override IEnumerator Begin()
    {
        Controller.UI.SetCamera();
        active = false;
        yield return new WaitForSeconds(2);
        active = true;

    }

    public override IEnumerator Exit()
    {
        Controller.SetState(new Crosshair(Controller));
        yield break;
    }

}
