//using JFramework.Package;
using System.Collections.Generic;
using System;
using Adic;
using JFramework;
using JFramework.Game;

///游戏可以服用
namespace Game.Common
{
    /// <summary>
    /// 并行执行器
    /// </summary>
    public class ParallelLauncher : BaseViewController
    {
        /// <summary>
        /// 内部运行对象
        /// </summary>

        protected List<IRunable> internalRunables;

        [Inject]
        public ParallelLauncher(EventManager eventManager) : base(eventManager)
        {
        }


        //public ParallelLauncher() 
        //{ 
        //}


        //public ParallelLauncher(List<IRunable> runables)
        //{
        //    this.internalRunables = runables;
        //}

        public void Add(IRunable runable)
        {
            if (internalRunables == null)
                internalRunables = new List<IRunable>();

            internalRunables.Add(runable);
        }

        /// <summary>
        /// 运行
        /// </summary>
        protected override async void OnStart(RunableExtraData extraData)
        {
            base.OnStart(extraData);

            foreach(var runable in this.internalRunables)
            {
                runable.onComplete += Runable_onComplete;
                await runable.Start(extraData);
            }

           // SetStartComplete();
        }

        protected override void OnStop()
        {
            base.OnStop();

            foreach (var runable in this.internalRunables)
            {
                runable.onComplete -= Runable_onComplete;
                runable.Stop();
            }
        }

        private void Runable_onComplete(IRunable obj)
        {
            
        }
    }
}
