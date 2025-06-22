using JFramework.Package;
using System.Collections.Generic;
using System;
using Adic;

///游戏可以服用
namespace Game.Common
{
    /// <summary>
    /// 并行执行器
    /// </summary>
    public class ParallelLauncher : BaseRunable
    {
        /// <summary>
        /// 内部运行对象
        /// </summary>
        protected List<IRunable> internalRunables;


        public ParallelLauncher() 
        { 
        }

        [Inject]
        public ParallelLauncher(List<IRunable> runables)
        {
            this.internalRunables = runables;
        }

        /// <summary>
        /// 运行
        /// </summary>
        protected override void OnRun(RunableExtraData extraData = null)
        {
            base.OnRun(extraData);

            foreach(var runable in this.internalRunables)
            {
                runable.onComplete += Runable_onComplete;
                runable.Run(extraData);
            }
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
