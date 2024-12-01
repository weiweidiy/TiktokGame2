using UnityEngine;

public class InitManager : BaseRunable
{
    protected override void OnRun(RunableExtraData extraData)
    {
        base.OnRun(extraData);

        Debug.Log("init");
        //设置ExtraData
        NotifyComplete(this);
    }
}
