using System.Collections;
using UnityEngine;
public class Crosshair : State
{

    private bool active = true;
    public Crosshair(GameController controller) : base(controller)
    {
    }


    public override IEnumerator Begin()
    {
        Controller.UI.SetCamera();
        active = false;
        yield return new WaitForSeconds(2);
        active = true;

    }

    public override IEnumerator Exit()
    {
        Controller.SetState(new SpellWord(Controller));
        yield break;
    }
}