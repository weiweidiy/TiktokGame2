﻿using JFrame;
using UnityEngine;
using UnityEngine.SceneManagement;
using YooAsset;

public class TiktokGameManager : BaseRunable
{
    protected override void OnRun(RunableExtraData extraData)
    {
        base.OnRun(extraData);

        //启动第一个场景
        Debug.Log("GameManager");
        LoadGameEntrance();
    }

    void LoadGameEntrance()
    {
        YooAssets.LoadSceneAsync("Persistent");
    }
}