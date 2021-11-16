using UnityEngine;
using System.Collections;

public class SpellWord : State
{
    private bool active = true;
    public SpellWord(GameController controller) : base(controller)
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
        Controller.SetState(new WordSelect(Controller));
        yield break;
    }


}