using JFrame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YooAsset;

public class PatchArgs
{
    public EPlayMode playMode;
    public string url;
    public string packageName;
}

public class Launcher : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// ����ģʽ��������Դ���ط�ʽ
    /// </summary>
    public EPlayMode PlayMode = EPlayMode.EditorSimulateMode;

    /// <summary>
    /// �ȸ���ַ
    /// </summary>
    public string HotfixUrl;

    /// <summary>
    /// �ȸ���Դ����
    /// </summary>
    public string PackageName;

    void Start()
    {
        var extraData = new RunableExtraData() { Data = new PatchArgs() { playMode = PlayMode, url = HotfixUrl, packageName = PackageName} };

        var initManager = new InitManager();
        //var routeManager = new RouteManager();
        var patchManager = new PatchManager();
        var gameManager = new GameManager();

        Queue<IRunable> runables = new Queue<IRunable>();
        runables.Enqueue(initManager);
        runables.Enqueue(patchManager);
        runables.Enqueue(gameManager);

        var launcher = new CommonLauncher(runables);
        launcher.Run(extraData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}