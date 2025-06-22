using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"DOTween.dll",
		"MackySoft.XPool.dll",
		"System.Core.dll",
		"UniTask.dll",
		"UnityEngine.CoreModule.dll",
		"YooAsset.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<GameCommands.CommandStartupGame.<InitializeViews>d__8>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.BaseGameObjectPool.<Regist>d__2>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__0>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__1>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.BaseSMAsync.<OnEnter>d__6<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.BaseSMAsync.<OnExit>d__7<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.Common.SMTransitionProvider.<InstantiateAsync>d__1,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.UIManager.<Initialize>d__4>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.YooAssetsLoader.<InstantiateAsync>d__1,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.YooAssetsLoader.<LoadAssetAsync>d__2<object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JFrame.YooAssetsLoader.<LoadSceneAsync>d__3,UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<SMTransition.<TransitionIn>d__4,int>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<SMTransition.<TransitionOut>d__2,int>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.<EnterStateAsync>d__23<object,object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.<HandleReentryTriggerAsync>d__21<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.<HandleTransitioningTriggerAsync>d__22<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.<InternalFireAsync>d__18<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.<InternalFireOneAsync>d__20<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.<InternalFireQueuedAsync>d__19<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.OnTransitionedEvent.<InvokeAsync>d__5<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.StateRepresentation.<ActivateAsync>d__5<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.StateRepresentation.<DeactivateAsync>d__6<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.StateRepresentation.<EnterAsync>d__9<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.StateRepresentation.<ExecuteActivationActionsAsync>d__7<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.StateRepresentation.<ExecuteDeactivationActionsAsync>d__8<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.StateRepresentation.<ExecuteEntryActionsAsync>d__11<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.StateRepresentation.<ExecuteExitActionsAsync>d__12<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Stateless.StateMachine.StateRepresentation.<ExitAsync>d__10<object,object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Tiktok.TiktokGameObjectManager.<Initialize>d__4>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Tiktok.TiktokSceneGameState.<OnEnter>d__6>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Tiktok.TiktokSceneMenuState.<OnEnter>d__7>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Tiktok.TiktokSceneMenuState.<OnExit>d__9>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<GameCommands.CommandStartupGame.<InitializeViews>d__8>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.BaseGameObjectPool.<Regist>d__2>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__0>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__1>d<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.BaseSMAsync.<OnEnter>d__6<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.BaseSMAsync.<OnExit>d__7<object,object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.Common.SMTransitionProvider.<InstantiateAsync>d__1,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.UIManager.<Initialize>d__4>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.YooAssetsLoader.<InstantiateAsync>d__1,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.YooAssetsLoader.<LoadAssetAsync>d__2<object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JFrame.YooAssetsLoader.<LoadSceneAsync>d__3,UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<SMTransition.<TransitionIn>d__4,int>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<SMTransition.<TransitionOut>d__2,int>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.<EnterStateAsync>d__23<object,object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.<HandleReentryTriggerAsync>d__21<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.<HandleTransitioningTriggerAsync>d__22<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.<InternalFireAsync>d__18<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.<InternalFireOneAsync>d__20<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.<InternalFireQueuedAsync>d__19<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.OnTransitionedEvent.<InvokeAsync>d__5<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.StateRepresentation.<ActivateAsync>d__5<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.StateRepresentation.<DeactivateAsync>d__6<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.StateRepresentation.<EnterAsync>d__9<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.StateRepresentation.<ExecuteActivationActionsAsync>d__7<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.StateRepresentation.<ExecuteDeactivationActionsAsync>d__8<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.StateRepresentation.<ExecuteEntryActionsAsync>d__11<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.StateRepresentation.<ExecuteExitActionsAsync>d__12<object,object>>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Stateless.StateMachine.StateRepresentation.<ExitAsync>d__10<object,object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Tiktok.TiktokGameObjectManager.<Initialize>d__4>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Tiktok.TiktokSceneGameState.<OnEnter>d__6>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Tiktok.TiktokSceneMenuState.<OnEnter>d__7>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Tiktok.TiktokSceneMenuState.<OnExit>d__9>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<int>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>
	// Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<int>
	// Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<object>
	// Cysharp.Threading.Tasks.ITaskPoolNode<object>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,int>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.IUniTaskSource<int>
	// Cysharp.Threading.Tasks.IUniTaskSource<object>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,int>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<int>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<object>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,int>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<int>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<object>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,int>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<int>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<object>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,int>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask<UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.UniTask<int>
	// Cysharp.Threading.Tasks.UniTask<object>
	// Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit>
	// Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<UnityEngine.SceneManagement.Scene>
	// Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<int>
	// Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object>
	// DG.Tweening.Core.DOGetter<UnityEngine.Color>
	// DG.Tweening.Core.DOGetter<UnityEngine.Quaternion>
	// DG.Tweening.Core.DOGetter<UnityEngine.Vector2>
	// DG.Tweening.Core.DOGetter<UnityEngine.Vector3>
	// DG.Tweening.Core.DOGetter<float>
	// DG.Tweening.Core.DOGetter<int>
	// DG.Tweening.Core.DOGetter<object>
	// DG.Tweening.Core.DOSetter<UnityEngine.Color>
	// DG.Tweening.Core.DOSetter<UnityEngine.Quaternion>
	// DG.Tweening.Core.DOSetter<UnityEngine.Vector2>
	// DG.Tweening.Core.DOSetter<UnityEngine.Vector3>
	// DG.Tweening.Core.DOSetter<float>
	// DG.Tweening.Core.DOSetter<int>
	// DG.Tweening.Core.DOSetter<object>
	// DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions>
	// DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>
	// DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<DG.Tweening.Color2,DG.Tweening.Color2,DG.Tweening.Plugins.Options.ColorOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion,UnityEngine.Vector3,DG.Tweening.Plugins.Options.QuaternionOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Rect,UnityEngine.Rect,DG.Tweening.Plugins.Options.RectOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.Vector3ArrayOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector4,UnityEngine.Vector4,DG.Tweening.Plugins.Options.VectorOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<double,double,DG.Tweening.Plugins.Options.NoOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<float,float,DG.Tweening.Plugins.Options.FloatOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<int,int,DG.Tweening.Plugins.Options.NoOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<long,long,DG.Tweening.Plugins.Options.NoOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<object,object,DG.Tweening.Plugins.Options.NoOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<object,object,DG.Tweening.Plugins.Options.StringOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<uint,uint,DG.Tweening.Plugins.Options.UintOptions>
	// DG.Tweening.Plugins.Core.ABSTweenPlugin<ulong,ulong,DG.Tweening.Plugins.Options.NoOptions>
	// MackySoft.XPool.FactoryPool<object>
	// MackySoft.XPool.ObjectModel.PoolBase<object>
	// MackySoft.XPool.Unity.UnityObjectPool<object>
	// System.Action<Consolation.TestConsole.Log>
	// System.Action<DG.Tweening.Plugins.Options.PathOptions,object,UnityEngine.Quaternion,object>
	// System.Action<JFrame.HandlerWrapper>
	// System.Action<LitJson.PropertyMetadata>
	// System.Action<SMTetrisTransition.Tile>
	// System.Action<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Action<UnityEngine.Rendering.ScriptableRenderContext,object>
	// System.Action<UnityEngine.Vector2,object>
	// System.Action<UnityEngine.Vector3,object>
	// System.Action<byte>
	// System.Action<float>
	// System.Action<object,int,object>
	// System.Action<object,int>
	// System.Action<object,object,object,object>
	// System.Action<object,object,object>
	// System.Action<object,object>
	// System.Action<object>
	// System.Buffers.ArrayPool<int>
	// System.Buffers.TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>
	// System.Buffers.TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<int>
	// System.Buffers.TlsOverPerCoreLockedStacksArrayPool<int>
	// System.ByReference<int>
	// System.ByReference<ushort>
	// System.Collections.Generic.ArraySortHelper<Consolation.TestConsole.Log>
	// System.Collections.Generic.ArraySortHelper<JFrame.HandlerWrapper>
	// System.Collections.Generic.ArraySortHelper<LitJson.PropertyMetadata>
	// System.Collections.Generic.ArraySortHelper<SMTetrisTransition.Tile>
	// System.Collections.Generic.ArraySortHelper<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.ArraySortHelper<object>
	// System.Collections.Generic.Comparer<Consolation.TestConsole.Log>
	// System.Collections.Generic.Comparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.Comparer<LitJson.PropertyMetadata>
	// System.Collections.Generic.Comparer<SMTetrisTransition.Tile>
	// System.Collections.Generic.Comparer<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.Comparer<System.Guid>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,int>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.Comparer<UnityEngine.SceneManagement.Scene>
	// System.Collections.Generic.Comparer<byte>
	// System.Collections.Generic.Comparer<int>
	// System.Collections.Generic.Comparer<object>
	// System.Collections.Generic.Dictionary.Enumerator<int,UnityEngine.Color>
	// System.Collections.Generic.Dictionary.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.Enumerator<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.Enumerator<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.Dictionary.Enumerator<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.Dictionary.Enumerator<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.Dictionary.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,UnityEngine.Color>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection<int,UnityEngine.Color>
	// System.Collections.Generic.Dictionary.KeyCollection<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.KeyCollection<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.Dictionary.KeyCollection<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.Dictionary.KeyCollection<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.Dictionary.KeyCollection<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,UnityEngine.Color>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection<int,UnityEngine.Color>
	// System.Collections.Generic.Dictionary.ValueCollection<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.ValueCollection<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.Dictionary.ValueCollection<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.Dictionary.ValueCollection<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.Dictionary.ValueCollection<object,object>
	// System.Collections.Generic.Dictionary<int,UnityEngine.Color>
	// System.Collections.Generic.Dictionary<int,object>
	// System.Collections.Generic.Dictionary<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.Dictionary<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.Dictionary<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.Dictionary<object,object>
	// System.Collections.Generic.EqualityComparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.EqualityComparer<LitJson.ArrayMetadata>
	// System.Collections.Generic.EqualityComparer<LitJson.ObjectMetadata>
	// System.Collections.Generic.EqualityComparer<LitJson.PropertyMetadata>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,int>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.EqualityComparer<UnityEngine.Color>
	// System.Collections.Generic.EqualityComparer<UnityEngine.SceneManagement.Scene>
	// System.Collections.Generic.EqualityComparer<byte>
	// System.Collections.Generic.EqualityComparer<int>
	// System.Collections.Generic.EqualityComparer<object>
	// System.Collections.Generic.HashSet.Enumerator<object>
	// System.Collections.Generic.HashSet<object>
	// System.Collections.Generic.HashSetEqualityComparer<object>
	// System.Collections.Generic.ICollection<Consolation.TestConsole.Log>
	// System.Collections.Generic.ICollection<JFrame.HandlerWrapper>
	// System.Collections.Generic.ICollection<LitJson.PropertyMetadata>
	// System.Collections.Generic.ICollection<SMTetrisTransition.Tile>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,UnityEngine.Color>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,JFrame.HandlerWrapper>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,LitJson.ArrayMetadata>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,LitJson.ObjectMetadata>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,LitJson.PropertyMetadata>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.ICollection<object>
	// System.Collections.Generic.IComparer<Consolation.TestConsole.Log>
	// System.Collections.Generic.IComparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.IComparer<LitJson.PropertyMetadata>
	// System.Collections.Generic.IComparer<SMTetrisTransition.Tile>
	// System.Collections.Generic.IComparer<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IComparer<System.Guid>
	// System.Collections.Generic.IComparer<int>
	// System.Collections.Generic.IComparer<object>
	// System.Collections.Generic.IDictionary<int,object>
	// System.Collections.Generic.IDictionary<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.IDictionary<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.IDictionary<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.IDictionary<object,object>
	// System.Collections.Generic.IEnumerable<Consolation.TestConsole.Log>
	// System.Collections.Generic.IEnumerable<JFrame.HandlerWrapper>
	// System.Collections.Generic.IEnumerable<LitJson.PropertyMetadata>
	// System.Collections.Generic.IEnumerable<SMTetrisTransition.Tile>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.UIntPtr,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,UnityEngine.Color>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,JFrame.HandlerWrapper>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,LitJson.ArrayMetadata>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,LitJson.ObjectMetadata>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,LitJson.PropertyMetadata>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<object>
	// System.Collections.Generic.IEnumerator<Consolation.TestConsole.Log>
	// System.Collections.Generic.IEnumerator<JFrame.HandlerWrapper>
	// System.Collections.Generic.IEnumerator<LitJson.PropertyMetadata>
	// System.Collections.Generic.IEnumerator<SMTetrisTransition.Tile>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.UIntPtr,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,UnityEngine.Color>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,JFrame.HandlerWrapper>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,LitJson.ArrayMetadata>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,LitJson.ObjectMetadata>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,LitJson.PropertyMetadata>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<object>
	// System.Collections.Generic.IEqualityComparer<int>
	// System.Collections.Generic.IEqualityComparer<object>
	// System.Collections.Generic.IList<Consolation.TestConsole.Log>
	// System.Collections.Generic.IList<JFrame.HandlerWrapper>
	// System.Collections.Generic.IList<LitJson.PropertyMetadata>
	// System.Collections.Generic.IList<SMTetrisTransition.Tile>
	// System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IList<object>
	// System.Collections.Generic.KeyValuePair<System.UIntPtr,object>
	// System.Collections.Generic.KeyValuePair<int,UnityEngine.Color>
	// System.Collections.Generic.KeyValuePair<int,object>
	// System.Collections.Generic.KeyValuePair<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.KeyValuePair<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.KeyValuePair<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.KeyValuePair<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.List.Enumerator<Consolation.TestConsole.Log>
	// System.Collections.Generic.List.Enumerator<JFrame.HandlerWrapper>
	// System.Collections.Generic.List.Enumerator<LitJson.PropertyMetadata>
	// System.Collections.Generic.List.Enumerator<SMTetrisTransition.Tile>
	// System.Collections.Generic.List.Enumerator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.List.Enumerator<object>
	// System.Collections.Generic.List<Consolation.TestConsole.Log>
	// System.Collections.Generic.List<JFrame.HandlerWrapper>
	// System.Collections.Generic.List<LitJson.PropertyMetadata>
	// System.Collections.Generic.List<SMTetrisTransition.Tile>
	// System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.List<object>
	// System.Collections.Generic.ObjectComparer<Consolation.TestConsole.Log>
	// System.Collections.Generic.ObjectComparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.ObjectComparer<LitJson.PropertyMetadata>
	// System.Collections.Generic.ObjectComparer<SMTetrisTransition.Tile>
	// System.Collections.Generic.ObjectComparer<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.ObjectComparer<System.Guid>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,int>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.ObjectComparer<UnityEngine.SceneManagement.Scene>
	// System.Collections.Generic.ObjectComparer<byte>
	// System.Collections.Generic.ObjectComparer<int>
	// System.Collections.Generic.ObjectComparer<object>
	// System.Collections.Generic.ObjectEqualityComparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.ObjectEqualityComparer<LitJson.ArrayMetadata>
	// System.Collections.Generic.ObjectEqualityComparer<LitJson.ObjectMetadata>
	// System.Collections.Generic.ObjectEqualityComparer<LitJson.PropertyMetadata>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,int>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.ObjectEqualityComparer<UnityEngine.Color>
	// System.Collections.Generic.ObjectEqualityComparer<UnityEngine.SceneManagement.Scene>
	// System.Collections.Generic.ObjectEqualityComparer<byte>
	// System.Collections.Generic.ObjectEqualityComparer<int>
	// System.Collections.Generic.ObjectEqualityComparer<object>
	// System.Collections.Generic.Queue.Enumerator<deVoid.UIFramework.WindowHistoryEntry>
	// System.Collections.Generic.Queue.Enumerator<object>
	// System.Collections.Generic.Queue<deVoid.UIFramework.WindowHistoryEntry>
	// System.Collections.Generic.Queue<object>
	// System.Collections.Generic.Stack.Enumerator<deVoid.UIFramework.WindowHistoryEntry>
	// System.Collections.Generic.Stack.Enumerator<int>
	// System.Collections.Generic.Stack.Enumerator<object>
	// System.Collections.Generic.Stack<deVoid.UIFramework.WindowHistoryEntry>
	// System.Collections.Generic.Stack<int>
	// System.Collections.Generic.Stack<object>
	// System.Collections.Generic.ValueListBuilder<int>
	// System.Collections.ObjectModel.ReadOnlyCollection<Consolation.TestConsole.Log>
	// System.Collections.ObjectModel.ReadOnlyCollection<JFrame.HandlerWrapper>
	// System.Collections.ObjectModel.ReadOnlyCollection<LitJson.PropertyMetadata>
	// System.Collections.ObjectModel.ReadOnlyCollection<SMTetrisTransition.Tile>
	// System.Collections.ObjectModel.ReadOnlyCollection<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.ObjectModel.ReadOnlyCollection<object>
	// System.Comparison<Consolation.TestConsole.Log>
	// System.Comparison<JFrame.HandlerWrapper>
	// System.Comparison<LitJson.PropertyMetadata>
	// System.Comparison<SMTetrisTransition.Tile>
	// System.Comparison<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Comparison<object>
	// System.EventHandler<object>
	// System.Func<Cysharp.Threading.Tasks.UniTask>
	// System.Func<System.Collections.Generic.KeyValuePair<int,object>,byte>
	// System.Func<System.Collections.Generic.KeyValuePair<int,object>,int>
	// System.Func<System.Collections.Generic.KeyValuePair<int,object>,object>
	// System.Func<System.Collections.Generic.KeyValuePair<object,object>,byte>
	// System.Func<System.Collections.Generic.KeyValuePair<object,object>,object>
	// System.Func<System.Threading.Tasks.VoidTaskResult>
	// System.Func<byte>
	// System.Func<float,object,float>
	// System.Func<int,object,byte>
	// System.Func<int,object>
	// System.Func<int>
	// System.Func<object,Cysharp.Threading.Tasks.UniTask>
	// System.Func<object,System.Guid>
	// System.Func<object,System.Threading.Tasks.VoidTaskResult>
	// System.Func<object,byte>
	// System.Func<object,int,Cysharp.Threading.Tasks.UniTask>
	// System.Func<object,int,object,Cysharp.Threading.Tasks.UniTask>
	// System.Func<object,int>
	// System.Func<object,object,Cysharp.Threading.Tasks.UniTask>
	// System.Func<object,object,byte>
	// System.Func<object,object,object,Cysharp.Threading.Tasks.UniTask>
	// System.Func<object,object,object,byte>
	// System.Func<object,object,object,object,Cysharp.Threading.Tasks.UniTask>
	// System.Func<object,object,object,object>
	// System.Func<object,object,object>
	// System.Func<object,object>
	// System.Func<object>
	// System.IEquatable<object>
	// System.Linq.Buffer<object>
	// System.Linq.Enumerable.<ConcatIterator>d__59<object>
	// System.Linq.Enumerable.<DistinctIterator>d__68<object>
	// System.Linq.Enumerable.<ExceptIterator>d__77<object>
	// System.Linq.Enumerable.<OfTypeIterator>d__97<object>
	// System.Linq.Enumerable.<SelectManyIterator>d__17<System.Collections.Generic.KeyValuePair<object,object>,object>
	// System.Linq.Enumerable.<SelectManyIterator>d__17<object,object>
	// System.Linq.Enumerable.<TakeIterator>d__25<object>
	// System.Linq.Enumerable.<UnionIterator>d__71<object>
	// System.Linq.Enumerable.Iterator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Linq.Enumerable.Iterator<object>
	// System.Linq.Enumerable.WhereArrayIterator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Linq.Enumerable.WhereArrayIterator<object>
	// System.Linq.Enumerable.WhereEnumerableIterator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Linq.Enumerable.WhereEnumerableIterator<object>
	// System.Linq.Enumerable.WhereListIterator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Linq.Enumerable.WhereListIterator<object>
	// System.Linq.Enumerable.WhereSelectArrayIterator<System.Collections.Generic.KeyValuePair<object,object>,object>
	// System.Linq.Enumerable.WhereSelectArrayIterator<object,object>
	// System.Linq.Enumerable.WhereSelectEnumerableIterator<System.Collections.Generic.KeyValuePair<object,object>,object>
	// System.Linq.Enumerable.WhereSelectEnumerableIterator<object,object>
	// System.Linq.Enumerable.WhereSelectListIterator<System.Collections.Generic.KeyValuePair<object,object>,object>
	// System.Linq.Enumerable.WhereSelectListIterator<object,object>
	// System.Linq.EnumerableSorter<object,System.Guid>
	// System.Linq.EnumerableSorter<object,int>
	// System.Linq.EnumerableSorter<object>
	// System.Linq.GroupedEnumerable<object,int,object>
	// System.Linq.IdentityFunction.<>c<object>
	// System.Linq.IdentityFunction<object>
	// System.Linq.Lookup.<GetEnumerator>d__12<int,object>
	// System.Linq.Lookup.Grouping.<GetEnumerator>d__7<int,object>
	// System.Linq.Lookup.Grouping<int,object>
	// System.Linq.Lookup<int,object>
	// System.Linq.OrderedEnumerable.<GetEnumerator>d__1<object>
	// System.Linq.OrderedEnumerable<object,System.Guid>
	// System.Linq.OrderedEnumerable<object,int>
	// System.Linq.OrderedEnumerable<object>
	// System.Linq.Set<object>
	// System.Nullable<UnityEngine.Vector3>
	// System.Predicate<Consolation.TestConsole.Log>
	// System.Predicate<JFrame.HandlerWrapper>
	// System.Predicate<LitJson.PropertyMetadata>
	// System.Predicate<SMTetrisTransition.Tile>
	// System.Predicate<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Predicate<object>
	// System.ReadOnlySpan<int>
	// System.ReadOnlySpan<ushort>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.VoidTaskResult>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Threading.Tasks.VoidTaskResult>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<int>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<object>
	// System.Runtime.CompilerServices.TaskAwaiter<System.Threading.Tasks.VoidTaskResult>
	// System.Runtime.CompilerServices.TaskAwaiter<int>
	// System.Runtime.CompilerServices.TaskAwaiter<object>
	// System.Span<int>
	// System.Span<ushort>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<System.Threading.Tasks.VoidTaskResult>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<int>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<object>
	// System.Threading.Tasks.Task<System.Threading.Tasks.VoidTaskResult>
	// System.Threading.Tasks.Task<int>
	// System.Threading.Tasks.Task<object>
	// System.Threading.Tasks.TaskFactory.<>c__DisplayClass35_0<System.Threading.Tasks.VoidTaskResult>
	// System.Threading.Tasks.TaskFactory.<>c__DisplayClass35_0<int>
	// System.Threading.Tasks.TaskFactory.<>c__DisplayClass35_0<object>
	// System.Threading.Tasks.TaskFactory<System.Threading.Tasks.VoidTaskResult>
	// System.Threading.Tasks.TaskFactory<int>
	// System.Threading.Tasks.TaskFactory<object>
	// System.Tuple<object,object>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,int>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>>
	// System.ValueTuple<byte,System.ValueTuple<byte,int>>
	// System.ValueTuple<byte,System.ValueTuple<byte,object>>
	// System.ValueTuple<byte,UnityEngine.SceneManagement.Scene>
	// System.ValueTuple<byte,int>
	// System.ValueTuple<byte,object>
	// }}

	public void RefMethods()
	{
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,GameCommands.CommandStartupGame.<InitializeViews>d__8>(Cysharp.Threading.Tasks.UniTask.Awaiter&,GameCommands.CommandStartupGame.<InitializeViews>d__8&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__0>d<object,object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__0>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__1>d<object,object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__1>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,JFrame.BaseSMAsync.<OnEnter>d__6<object,object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,JFrame.BaseSMAsync.<OnEnter>d__6<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,JFrame.BaseSMAsync.<OnExit>d__7<object,object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,JFrame.BaseSMAsync.<OnExit>d__7<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.<HandleReentryTriggerAsync>d__21<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.<HandleReentryTriggerAsync>d__21<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.<HandleTransitioningTriggerAsync>d__22<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.<HandleTransitioningTriggerAsync>d__22<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.<InternalFireAsync>d__18<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.<InternalFireAsync>d__18<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.<InternalFireOneAsync>d__20<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.<InternalFireOneAsync>d__20<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.<InternalFireQueuedAsync>d__19<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.<InternalFireQueuedAsync>d__19<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.OnTransitionedEvent.<InvokeAsync>d__5<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.OnTransitionedEvent.<InvokeAsync>d__5<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.StateRepresentation.<ActivateAsync>d__5<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.StateRepresentation.<ActivateAsync>d__5<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.StateRepresentation.<DeactivateAsync>d__6<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.StateRepresentation.<DeactivateAsync>d__6<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.StateRepresentation.<EnterAsync>d__9<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.StateRepresentation.<EnterAsync>d__9<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.StateRepresentation.<ExecuteActivationActionsAsync>d__7<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.StateRepresentation.<ExecuteActivationActionsAsync>d__7<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.StateRepresentation.<ExecuteDeactivationActionsAsync>d__8<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.StateRepresentation.<ExecuteDeactivationActionsAsync>d__8<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.StateRepresentation.<ExecuteEntryActionsAsync>d__11<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.StateRepresentation.<ExecuteEntryActionsAsync>d__11<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.StateRepresentation.<ExecuteExitActionsAsync>d__12<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.StateRepresentation.<ExecuteExitActionsAsync>d__12<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Tiktok.TiktokGameObjectManager.<Initialize>d__4>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Tiktok.TiktokGameObjectManager.<Initialize>d__4&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Tiktok.TiktokSceneGameState.<OnEnter>d__6>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Tiktok.TiktokSceneGameState.<OnEnter>d__6&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Tiktok.TiktokSceneMenuState.<OnEnter>d__7>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Tiktok.TiktokSceneMenuState.<OnEnter>d__7&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Tiktok.TiktokSceneMenuState.<OnExit>d__9>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Tiktok.TiktokSceneMenuState.<OnExit>d__9&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.SceneManagement.Scene>,Tiktok.TiktokSceneGameState.<OnEnter>d__6>(Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.SceneManagement.Scene>&,Tiktok.TiktokSceneGameState.<OnEnter>d__6&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.SceneManagement.Scene>,Tiktok.TiktokSceneMenuState.<OnEnter>d__7>(Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.SceneManagement.Scene>&,Tiktok.TiktokSceneMenuState.<OnEnter>d__7&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,JFrame.BaseGameObjectPool.<Regist>d__2>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,JFrame.BaseGameObjectPool.<Regist>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,JFrame.UIManager.<Initialize>d__4>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,JFrame.UIManager.<Initialize>d__4&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,Stateless.StateMachine.<HandleReentryTriggerAsync>d__21<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,Stateless.StateMachine.<HandleReentryTriggerAsync>d__21<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,Stateless.StateMachine.<HandleTransitioningTriggerAsync>d__22<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,Stateless.StateMachine.<HandleTransitioningTriggerAsync>d__22<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.SceneManagement.Scene>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,JFrame.YooAssetsLoader.<LoadSceneAsync>d__3>(Cysharp.Threading.Tasks.UniTask.Awaiter&,JFrame.YooAssetsLoader.<LoadSceneAsync>d__3&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,SMTransition.<TransitionIn>d__4>(Cysharp.Threading.Tasks.UniTask.Awaiter&,SMTransition.<TransitionIn>d__4&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,SMTransition.<TransitionOut>d__2>(Cysharp.Threading.Tasks.UniTask.Awaiter&,SMTransition.<TransitionOut>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,JFrame.YooAssetsLoader.<InstantiateAsync>d__1>(Cysharp.Threading.Tasks.UniTask.Awaiter&,JFrame.YooAssetsLoader.<InstantiateAsync>d__1&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,JFrame.YooAssetsLoader.<LoadAssetAsync>d__2<object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,JFrame.YooAssetsLoader.<LoadAssetAsync>d__2<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.<EnterStateAsync>d__23<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.<EnterStateAsync>d__23<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Stateless.StateMachine.StateRepresentation.<ExitAsync>d__10<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Stateless.StateMachine.StateRepresentation.<ExitAsync>d__10<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,JFrame.Common.SMTransitionProvider.<InstantiateAsync>d__1>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,JFrame.Common.SMTransitionProvider.<InstantiateAsync>d__1&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,Stateless.StateMachine.<EnterStateAsync>d__23<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,Stateless.StateMachine.<EnterStateAsync>d__23<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,Stateless.StateMachine.StateRepresentation.<ExitAsync>d__10<object,object>>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,Stateless.StateMachine.StateRepresentation.<ExitAsync>d__10<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<GameCommands.CommandStartupGame.<InitializeViews>d__8>(GameCommands.CommandStartupGame.<InitializeViews>d__8&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<JFrame.BaseGameObjectPool.<Regist>d__2>(JFrame.BaseGameObjectPool.<Regist>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__0>d<object,object,object>>(JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__0>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__1>d<object,object,object>>(JFrame.BaseSMAsync.<>c__DisplayClass5_0.<<Initialize>b__1>d<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<JFrame.BaseSMAsync.<OnEnter>d__6<object,object,object>>(JFrame.BaseSMAsync.<OnEnter>d__6<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<JFrame.BaseSMAsync.<OnExit>d__7<object,object,object>>(JFrame.BaseSMAsync.<OnExit>d__7<object,object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<JFrame.UIManager.<Initialize>d__4>(JFrame.UIManager.<Initialize>d__4&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.<HandleReentryTriggerAsync>d__21<object,object>>(Stateless.StateMachine.<HandleReentryTriggerAsync>d__21<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.<HandleTransitioningTriggerAsync>d__22<object,object>>(Stateless.StateMachine.<HandleTransitioningTriggerAsync>d__22<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.<InternalFireAsync>d__18<object,object>>(Stateless.StateMachine.<InternalFireAsync>d__18<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.<InternalFireOneAsync>d__20<object,object>>(Stateless.StateMachine.<InternalFireOneAsync>d__20<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.<InternalFireQueuedAsync>d__19<object,object>>(Stateless.StateMachine.<InternalFireQueuedAsync>d__19<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.OnTransitionedEvent.<InvokeAsync>d__5<object,object>>(Stateless.StateMachine.OnTransitionedEvent.<InvokeAsync>d__5<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.StateRepresentation.<ActivateAsync>d__5<object,object>>(Stateless.StateMachine.StateRepresentation.<ActivateAsync>d__5<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.StateRepresentation.<DeactivateAsync>d__6<object,object>>(Stateless.StateMachine.StateRepresentation.<DeactivateAsync>d__6<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.StateRepresentation.<EnterAsync>d__9<object,object>>(Stateless.StateMachine.StateRepresentation.<EnterAsync>d__9<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.StateRepresentation.<ExecuteActivationActionsAsync>d__7<object,object>>(Stateless.StateMachine.StateRepresentation.<ExecuteActivationActionsAsync>d__7<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.StateRepresentation.<ExecuteDeactivationActionsAsync>d__8<object,object>>(Stateless.StateMachine.StateRepresentation.<ExecuteDeactivationActionsAsync>d__8<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.StateRepresentation.<ExecuteEntryActionsAsync>d__11<object,object>>(Stateless.StateMachine.StateRepresentation.<ExecuteEntryActionsAsync>d__11<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Stateless.StateMachine.StateRepresentation.<ExecuteExitActionsAsync>d__12<object,object>>(Stateless.StateMachine.StateRepresentation.<ExecuteExitActionsAsync>d__12<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Tiktok.TiktokGameObjectManager.<Initialize>d__4>(Tiktok.TiktokGameObjectManager.<Initialize>d__4&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Tiktok.TiktokSceneGameState.<OnEnter>d__6>(Tiktok.TiktokSceneGameState.<OnEnter>d__6&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Tiktok.TiktokSceneMenuState.<OnEnter>d__7>(Tiktok.TiktokSceneMenuState.<OnEnter>d__7&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Tiktok.TiktokSceneMenuState.<OnExit>d__9>(Tiktok.TiktokSceneMenuState.<OnExit>d__9&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.SceneManagement.Scene>.Start<JFrame.YooAssetsLoader.<LoadSceneAsync>d__3>(JFrame.YooAssetsLoader.<LoadSceneAsync>d__3&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<int>.Start<SMTransition.<TransitionIn>d__4>(SMTransition.<TransitionIn>d__4&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<int>.Start<SMTransition.<TransitionOut>d__2>(SMTransition.<TransitionOut>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.Start<JFrame.Common.SMTransitionProvider.<InstantiateAsync>d__1>(JFrame.Common.SMTransitionProvider.<InstantiateAsync>d__1&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.Start<JFrame.YooAssetsLoader.<InstantiateAsync>d__1>(JFrame.YooAssetsLoader.<InstantiateAsync>d__1&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.Start<JFrame.YooAssetsLoader.<LoadAssetAsync>d__2<object>>(JFrame.YooAssetsLoader.<LoadAssetAsync>d__2<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.Start<Stateless.StateMachine.<EnterStateAsync>d__23<object,object>>(Stateless.StateMachine.<EnterStateAsync>d__23<object,object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.Start<Stateless.StateMachine.StateRepresentation.<ExitAsync>d__10<object,object>>(Stateless.StateMachine.StateRepresentation.<ExitAsync>d__10<object,object>&)
		// Cysharp.Threading.Tasks.UniTask.Awaiter Cysharp.Threading.Tasks.EnumeratorAsyncExtensions.GetAwaiter<object>(object)
		// DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions> DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions>(DG.Tweening.Core.TweenerCore<UnityEngine.Color,UnityEngine.Color,DG.Tweening.Plugins.Options.ColorOptions>)
		// object DG.Tweening.Core.Extensions.SetSpecialStartupMode<object>(object,DG.Tweening.Core.Enums.SpecialStartupMode)
		// DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> DG.Tweening.Core.TweenManager.GetTweener<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>()
		// DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.Core.TweenManager.GetTweener<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>()
		// DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> DG.Tweening.DOTween.ApplyTo<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>(DG.Tweening.Core.DOGetter<UnityEngine.Vector2>,DG.Tweening.Core.DOSetter<UnityEngine.Vector2>,UnityEngine.Vector2,float,DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>)
		// DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.DOTween.ApplyTo<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>(DG.Tweening.Core.DOGetter<UnityEngine.Vector3>,DG.Tweening.Core.DOSetter<UnityEngine.Vector3>,object,float,DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>)
		// DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> DG.Tweening.DOTween.To<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>(DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>,DG.Tweening.Core.DOGetter<UnityEngine.Vector2>,DG.Tweening.Core.DOSetter<UnityEngine.Vector2>,UnityEngine.Vector2,float)
		// DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.DOTween.To<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>(DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>,DG.Tweening.Core.DOGetter<UnityEngine.Vector3>,DG.Tweening.Core.DOSetter<UnityEngine.Vector3>,object,float)
		// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions> DG.Tweening.Plugins.Core.PluginsManager.GetDefaultPlugin<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>()
		// DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions> DG.Tweening.Plugins.Core.PluginsManager.GetDefaultPlugin<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>()
		// object DG.Tweening.TweenSettingsExtensions.OnStart<object>(object,DG.Tweening.TweenCallback)
		// object DG.Tweening.TweenSettingsExtensions.OnStepComplete<object>(object,DG.Tweening.TweenCallback)
		// object DG.Tweening.TweenSettingsExtensions.OnUpdate<object>(object,DG.Tweening.TweenCallback)
		// object DG.Tweening.TweenSettingsExtensions.SetEase<object>(object,DG.Tweening.Ease)
		// object DG.Tweening.TweenSettingsExtensions.SetLoops<object>(object,int)
		// object DG.Tweening.TweenSettingsExtensions.SetLoops<object>(object,int,DG.Tweening.LoopType)
		// object DG.Tweening.TweenSettingsExtensions.SetRelative<object>(object)
		// object DG.Tweening.TweenSettingsExtensions.SetTarget<object>(object,object)
		// object DG.Tweening.TweenSettingsExtensions.SetUpdate<object>(object,DG.Tweening.UpdateType)
		// bool DG.Tweening.Tweener.Setup<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>,DG.Tweening.Core.DOGetter<UnityEngine.Vector2>,DG.Tweening.Core.DOSetter<UnityEngine.Vector2>,UnityEngine.Vector2,float,DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.CircleOptions>)
		// bool DG.Tweening.Tweener.Setup<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>,DG.Tweening.Core.DOGetter<UnityEngine.Vector3>,DG.Tweening.Core.DOSetter<UnityEngine.Vector3>,object,float,DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,object,DG.Tweening.Plugins.Options.PathOptions>)
		// object System.Activator.CreateInstance<object>()
		// object[] System.Array.Empty<object>()
		// bool System.Array.Exists<object>(object[],System.Predicate<object>)
		// int System.Array.FindIndex<object>(object[],System.Predicate<object>)
		// int System.Array.FindIndex<object>(object[],int,int,System.Predicate<object>)
		// float System.Linq.Enumerable.Aggregate<object,float>(System.Collections.Generic.IEnumerable<object>,float,System.Func<float,object,float>)
		// bool System.Linq.Enumerable.All<object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,bool>)
		// bool System.Linq.Enumerable.Any<object>(System.Collections.Generic.IEnumerable<object>)
		// bool System.Linq.Enumerable.Any<object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,bool>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Concat<object>(System.Collections.Generic.IEnumerable<object>,System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.ConcatIterator<object>(System.Collections.Generic.IEnumerable<object>,System.Collections.Generic.IEnumerable<object>)
		// int System.Linq.Enumerable.Count<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Distinct<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.DistinctIterator<object>(System.Collections.Generic.IEnumerable<object>,System.Collections.Generic.IEqualityComparer<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Except<object>(System.Collections.Generic.IEnumerable<object>,System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.ExceptIterator<object>(System.Collections.Generic.IEnumerable<object>,System.Collections.Generic.IEnumerable<object>,System.Collections.Generic.IEqualityComparer<object>)
		// object System.Linq.Enumerable.FirstOrDefault<object>(System.Collections.Generic.IEnumerable<object>)
		// object System.Linq.Enumerable.FirstOrDefault<object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,bool>)
		// System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int,object>> System.Linq.Enumerable.GroupBy<object,int>(System.Collections.Generic.IEnumerable<object>,System.Func<object,int>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.OfType<object>(System.Collections.IEnumerable)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.OfTypeIterator<object>(System.Collections.IEnumerable)
		// System.Linq.IOrderedEnumerable<object> System.Linq.Enumerable.OrderBy<object,System.Guid>(System.Collections.Generic.IEnumerable<object>,System.Func<object,System.Guid>)
		// System.Linq.IOrderedEnumerable<object> System.Linq.Enumerable.OrderByDescending<object,int>(System.Collections.Generic.IEnumerable<object>,System.Func<object,int>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<object,object>,object>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>,System.Func<System.Collections.Generic.KeyValuePair<object,object>,object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Select<object,object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<object,object>,object>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>,System.Func<System.Collections.Generic.KeyValuePair<object,object>,System.Collections.Generic.IEnumerable<object>>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.SelectMany<object,object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,System.Collections.Generic.IEnumerable<object>>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.SelectManyIterator<System.Collections.Generic.KeyValuePair<object,object>,object>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>,System.Func<System.Collections.Generic.KeyValuePair<object,object>,System.Collections.Generic.IEnumerable<object>>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.SelectManyIterator<object,object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,System.Collections.Generic.IEnumerable<object>>)
		// object System.Linq.Enumerable.SingleOrDefault<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Take<object>(System.Collections.Generic.IEnumerable<object>,int)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.TakeIterator<object>(System.Collections.Generic.IEnumerable<object>,int)
		// object[] System.Linq.Enumerable.ToArray<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.Dictionary<object,object> System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<object,object>,object,object>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>,System.Func<System.Collections.Generic.KeyValuePair<object,object>,object>,System.Func<System.Collections.Generic.KeyValuePair<object,object>,object>)
		// System.Collections.Generic.Dictionary<object,object> System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<object,object>,object,object>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>,System.Func<System.Collections.Generic.KeyValuePair<object,object>,object>,System.Func<System.Collections.Generic.KeyValuePair<object,object>,object>,System.Collections.Generic.IEqualityComparer<object>)
		// System.Collections.Generic.List<object> System.Linq.Enumerable.ToList<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Union<object>(System.Collections.Generic.IEnumerable<object>,System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.UnionIterator<object>(System.Collections.Generic.IEnumerable<object>,System.Collections.Generic.IEnumerable<object>,System.Collections.Generic.IEqualityComparer<object>)
		// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>> System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<object,object>>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>,System.Func<System.Collections.Generic.KeyValuePair<object,object>,bool>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Where<object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,bool>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Iterator<System.Collections.Generic.KeyValuePair<object,object>>.Select<object>(System.Func<System.Collections.Generic.KeyValuePair<object,object>,object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Iterator<object>.Select<object>(System.Func<object,object>)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.HttpWriter.<WriteAsync>d__5>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.HttpWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.LocalWriter.<WriteAsync>d__4>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.LocalWriter.<WriteAsync>d__4&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.LocalWriter.<WriteAsync>d__5>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.LocalWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HttpDeleter.<DeleteAsync>d__3>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HttpDeleter.<DeleteAsync>d__3&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HttpWriter.<WriteAsync>d__6>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HttpWriter.<WriteAsync>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForCompletion>d__10>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForCompletion>d__10&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForElapsedLoops>d__13>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForElapsedLoops>d__13&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForKill>d__12>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForKill>d__12&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForPosition>d__14>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForPosition>d__14&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForRewind>d__11>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForRewind>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForStart>d__15>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForStart>d__15&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.HttpWriter.<WriteAsync>d__5>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.HttpWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.LocalWriter.<WriteAsync>d__4>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.LocalWriter.<WriteAsync>d__4&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.LocalWriter.<WriteAsync>d__5>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.LocalWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HttpDeleter.<DeleteAsync>d__3>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HttpDeleter.<DeleteAsync>d__3&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HttpWriter.<WriteAsync>d__6>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HttpWriter.<WriteAsync>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForCompletion>d__10>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForCompletion>d__10&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForElapsedLoops>d__13>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForElapsedLoops>d__13&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForKill>d__12>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForKill>d__12&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForPosition>d__14>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForPosition>d__14&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForRewind>d__11>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForRewind>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForStart>d__15>(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter&,DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForStart>d__15&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Configuration.ConfigurationManager.<SaveAsync>d__29>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Configuration.ConfigurationManager.<SaveAsync>d__29&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<int>,JFrame.Common.LocalReader.<ReadAsync>d__3>(System.Runtime.CompilerServices.TaskAwaiter<int>&,JFrame.Common.LocalReader.<ReadAsync>d__3&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HiplayHttpRequest.<CommonHttpRequestAsync>d__11>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HiplayHttpRequest.<CommonHttpRequestAsync>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HiplayHttpRequest.<DeleteAsync>d__6>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HiplayHttpRequest.<DeleteAsync>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HiplayHttpRequest.<GetAsync>d__7>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HiplayHttpRequest.<GetAsync>d__7&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HiplayHttpRequest.<HttpRequestAsync>d__13>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HiplayHttpRequest.<HttpRequestAsync>d__13&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HiplayHttpRequest.<HttpRequestAsync>d__16>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HiplayHttpRequest.<HttpRequestAsync>d__16&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HiplayHttpRequest.<HttpsRequestAsync>d__17>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HiplayHttpRequest.<HttpsRequestAsync>d__17&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HiplayHttpRequest.<PostAsync>d__8>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HiplayHttpRequest.<PostAsync>d__8&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HiplayHttpRequest.<PostAsync>d__9>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HiplayHttpRequest.<PostAsync>d__9&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HttpReader.<ReadAsync>d__4>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HttpReader.<ReadAsync>d__4&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Configuration.ConfigurationManager.<SaveAllAsync>d__28>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Configuration.ConfigurationManager.<SaveAllAsync>d__28&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForCompletion>d__10>(DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForCompletion>d__10&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForElapsedLoops>d__13>(DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForElapsedLoops>d__13&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForKill>d__12>(DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForKill>d__12&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForPosition>d__14>(DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForPosition>d__14&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForRewind>d__11>(DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForRewind>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForStart>d__15>(DG.Tweening.DOTweenModuleUnityVersion.<AsyncWaitForStart>d__15&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<JFrame.Common.HttpDeleter.<DeleteAsync>d__3>(JFrame.Common.HttpDeleter.<DeleteAsync>d__3&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<JFrame.Common.HttpWriter.<WriteAsync>d__5>(JFrame.Common.HttpWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<JFrame.Common.HttpWriter.<WriteAsync>d__6>(JFrame.Common.HttpWriter.<WriteAsync>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<JFrame.Common.LocalWriter.<WriteAsync>d__4>(JFrame.Common.LocalWriter.<WriteAsync>d__4&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<JFrame.Common.LocalWriter.<WriteAsync>d__5>(JFrame.Common.LocalWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21>(JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start<JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22>(JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.HiplayHttpRequest.<CommonHttpRequestAsync>d__11>(JFrame.Common.HiplayHttpRequest.<CommonHttpRequestAsync>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.HiplayHttpRequest.<DeleteAsync>d__6>(JFrame.Common.HiplayHttpRequest.<DeleteAsync>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.HiplayHttpRequest.<GetAsync>d__7>(JFrame.Common.HiplayHttpRequest.<GetAsync>d__7&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.HiplayHttpRequest.<HttpRequestAsync>d__13>(JFrame.Common.HiplayHttpRequest.<HttpRequestAsync>d__13&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.HiplayHttpRequest.<HttpRequestAsync>d__16>(JFrame.Common.HiplayHttpRequest.<HttpRequestAsync>d__16&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.HiplayHttpRequest.<HttpsRequestAsync>d__17>(JFrame.Common.HiplayHttpRequest.<HttpsRequestAsync>d__17&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.HiplayHttpRequest.<PostAsync>d__8>(JFrame.Common.HiplayHttpRequest.<PostAsync>d__8&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.HiplayHttpRequest.<PostAsync>d__9>(JFrame.Common.HiplayHttpRequest.<PostAsync>d__9&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.HttpReader.<ReadAsync>d__4>(JFrame.Common.HttpReader.<ReadAsync>d__4&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Common.LocalReader.<ReadAsync>d__3>(JFrame.Common.LocalReader.<ReadAsync>d__3&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Configuration.ConfigurationManager.<SaveAllAsync>d__28>(JFrame.Configuration.ConfigurationManager.<SaveAllAsync>d__28&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<JFrame.Configuration.ConfigurationManager.<SaveAsync>d__29>(JFrame.Configuration.ConfigurationManager.<SaveAsync>d__29&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,GameCommands.CommandStartupGame.<Execute>d__5>(Cysharp.Threading.Tasks.UniTask.Awaiter&,GameCommands.CommandStartupGame.<Execute>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<GameCommands.CommandStartupGame.<Execute>d__5>(GameCommands.CommandStartupGame.<Execute>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Tiktok.TiktokSceneMenuState.<UiArg_onBtnEnterclick>d__8>(Tiktok.TiktokSceneMenuState.<UiArg_onBtnEnterclick>d__8&)
		// object& System.Runtime.CompilerServices.Unsafe.As<object,object>(object&)
		// System.Void* System.Runtime.CompilerServices.Unsafe.AsPointer<object>(object&)
		// object UnityEngine.Component.GetComponent<object>()
		// object UnityEngine.GameObject.AddComponent<object>()
		// object UnityEngine.GameObject.GetComponent<object>()
		// object UnityEngine.GameObject.GetComponentInChildren<object>(bool)
		// object UnityEngine.Object.Instantiate<object>(object)
		// YooAsset.AssetHandle YooAsset.ResourcePackage.LoadAssetAsync<object>(string,uint)
		// YooAsset.AssetHandle YooAsset.YooAssets.LoadAssetAsync<object>(string,uint)
	}
}