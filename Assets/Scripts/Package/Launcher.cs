using JFrame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var initManager = new InitManager();
        var patchManager = new PatchManager();
        Queue<IRunable> runables = new Queue<IRunable>();
        runables.Enqueue(initManager);
        runables.Enqueue(patchManager);

        var launcher = new CommonLauncher(runables);
        launcher.Run(new RunableExtraData());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
