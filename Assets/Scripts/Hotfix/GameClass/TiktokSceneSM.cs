using Cysharp.Threading.Tasks;
using JFramework;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Tiktok
{
    public class TiktokSceneSM : BaseSMAsync<TiktokSceneSMContext, TiktokSceneState, TiktokSceneSMTrigger>
    {
        TiktokSceneInitState initState;
        TiktokSceneMenuState menuState;
        TiktokSceneGameState gameState;

        protected override List<TiktokSceneState> GetAllStates()
        {
            var states = new List<TiktokSceneState>();

            initState = container.Resolve<TiktokSceneInitState>();
            if (initState == null)
                throw new Exception("Resolve TiktokSceneInitState is null");

            menuState = container.Resolve<TiktokSceneMenuState>();
            if (menuState == null)
                throw new Exception("Resolve TiktokSceneMenuState is null");

            gameState = container.Resolve<TiktokSceneGameState>();
            if (gameState == null)
                throw new Exception("Resolve TiktokSceneGameState is null");

            states.Add(initState);
            states.Add(menuState);
            states.Add(gameState);

            return states;
        }

        protected override Dictionary<string, SMConfig> GetConfigs()
        {
            var configs = new Dictionary<string, SMConfig>();

            var initName = initState.Name;
            var initConfig = new SMConfig();
            initConfig.state = initState;
            initConfig.dicPermit = new Dictionary<TiktokSceneSMTrigger, TiktokSceneState>();
            initConfig.dicPermit.Add(TiktokSceneSMTrigger.Menu, menuState);
            configs.Add(initName, initConfig);


            var menuName = menuState.Name;
            var menuConfig = new SMConfig();
            menuConfig.state = menuState;
            menuConfig.dicPermit = new Dictionary<TiktokSceneSMTrigger, TiktokSceneState>();
            menuConfig.dicPermit.Add(TiktokSceneSMTrigger.Game, gameState);
            configs.Add(menuName, menuConfig);

            var gameName = gameState.Name;
            var gameConfig = new SMConfig();
            gameConfig.state = gameState;
            gameConfig.dicPermit = new Dictionary<TiktokSceneSMTrigger, TiktokSceneState>();
            configs.Add(gameName, gameConfig);


            return configs;
        }

        public UniTask SwitchToMenu()
        {
            return machine.FireAsync(TiktokSceneSMTrigger.Menu);
        }

        public UniTask SwitchToGame()
        {
            return machine.FireAsync(TiktokSceneSMTrigger.Game);
        }
    }
}
