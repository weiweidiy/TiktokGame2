using JFrame;
using UnityEngine;

public class InitManager : BaseRunable
{
    protected override void OnRun(RunableExtraData extraData)
    {
        base.OnRun(extraData);

        Debug.Log("init");
        NotifyComplete(this);
    }
}
