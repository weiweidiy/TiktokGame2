using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"System.Core.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// System.Action<JFrame.HandlerWrapper>
	// System.Action<byte>
	// System.Action<float>
	// System.Action<object,object>
	// System.Action<object>
	// System.Collections.Generic.ArraySortHelper<JFrame.HandlerWrapper>
	// System.Collections.Generic.ArraySortHelper<object>
	// System.Collections.Generic.Comparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.Comparer<System.Guid>
	// System.Collections.Generic.Comparer<object>
	// System.Collections.Generic.Dictionary.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.Enumerator<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.KeyCollection<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary.ValueCollection<object,object>
	// System.Collections.Generic.Dictionary<int,object>
	// System.Collections.Generic.Dictionary<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.Dictionary<object,object>
	// System.Collections.Generic.EqualityComparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.EqualityComparer<int>
	// System.Collections.Generic.EqualityComparer<object>
	// System.Collections.Generic.ICollection<JFrame.HandlerWrapper>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,JFrame.HandlerWrapper>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.ICollection<object>
	// System.Collections.Generic.IComparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.IComparer<System.Guid>
	// System.Collections.Generic.IComparer<object>
	// System.Collections.Generic.IEnumerable<JFrame.HandlerWrapper>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,JFrame.HandlerWrapper>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<object>
	// System.Collections.Generic.IEnumerator<JFrame.HandlerWrapper>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,JFrame.HandlerWrapper>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<object>
	// System.Collections.Generic.IEqualityComparer<int>
	// System.Collections.Generic.IEqualityComparer<object>
	// System.Collections.Generic.IList<JFrame.HandlerWrapper>
	// System.Collections.Generic.IList<object>
	// System.Collections.Generic.KeyValuePair<int,object>
	// System.Collections.Generic.KeyValuePair<object,JFrame.HandlerWrapper>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.List.Enumerator<JFrame.HandlerWrapper>
	// System.Collections.Generic.List.Enumerator<object>
	// System.Collections.Generic.List<JFrame.HandlerWrapper>
	// System.Collections.Generic.List<object>
	// System.Collections.Generic.ObjectComparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.ObjectComparer<System.Guid>
	// System.Collections.Generic.ObjectComparer<object>
	// System.Collections.Generic.ObjectEqualityComparer<JFrame.HandlerWrapper>
	// System.Collections.Generic.ObjectEqualityComparer<int>
	// System.Collections.Generic.ObjectEqualityComparer<object>
	// System.Collections.ObjectModel.ReadOnlyCollection<JFrame.HandlerWrapper>
	// System.Collections.ObjectModel.ReadOnlyCollection<object>
	// System.Comparison<JFrame.HandlerWrapper>
	// System.Comparison<object>
	// System.Func<System.Threading.Tasks.VoidTaskResult>
	// System.Func<float,object,float>
	// System.Func<int>
	// System.Func<object,System.Guid>
	// System.Func<object,System.Threading.Tasks.VoidTaskResult>
	// System.Func<object,byte>
	// System.Func<object,int>
	// System.Func<object,object,object>
	// System.Func<object,object>
	// System.Func<object>
	// System.Linq.Buffer<object>
	// System.Linq.Enumerable.<TakeIterator>d__25<object>
	// System.Linq.Enumerable.Iterator<object>
	// System.Linq.Enumerable.WhereArrayIterator<object>
	// System.Linq.Enumerable.WhereEnumerableIterator<object>
	// System.Linq.Enumerable.WhereListIterator<object>
	// System.Linq.EnumerableSorter<object,System.Guid>
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
	// System.Linq.OrderedEnumerable<object>
	// System.Predicate<JFrame.HandlerWrapper>
	// System.Predicate<object>
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
	// }}

	public void RefMethods()
	{
		// object System.Activator.CreateInstance<object>()
		// float System.Linq.Enumerable.Aggregate<object,float>(System.Collections.Generic.IEnumerable<object>,float,System.Func<float,object,float>)
		// int System.Linq.Enumerable.Count<object>(System.Collections.Generic.IEnumerable<object>)
		// object System.Linq.Enumerable.FirstOrDefault<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int,object>> System.Linq.Enumerable.GroupBy<object,int>(System.Collections.Generic.IEnumerable<object>,System.Func<object,int>)
		// System.Linq.IOrderedEnumerable<object> System.Linq.Enumerable.OrderBy<object,System.Guid>(System.Collections.Generic.IEnumerable<object>,System.Func<object,System.Guid>)
		// object System.Linq.Enumerable.SingleOrDefault<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Take<object>(System.Collections.Generic.IEnumerable<object>,int)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.TakeIterator<object>(System.Collections.Generic.IEnumerable<object>,int)
		// System.Collections.Generic.List<object> System.Linq.Enumerable.ToList<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Where<object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,bool>)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.HttpWriter.<WriteAsync>d__5>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.HttpWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.LocalWriter.<WriteAsync>d__4>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.LocalWriter.<WriteAsync>d__4&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.LocalWriter.<WriteAsync>d__5>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.LocalWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HttpDeleter.<DeleteAsync>d__3>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HttpDeleter.<DeleteAsync>d__3&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HttpWriter.<WriteAsync>d__6>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HttpWriter.<WriteAsync>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.HttpWriter.<WriteAsync>d__5>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.HttpWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.LocalWriter.<WriteAsync>d__4>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.LocalWriter.<WriteAsync>d__4&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Common.LocalWriter.<WriteAsync>d__5>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Common.LocalWriter.<WriteAsync>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21>(System.Runtime.CompilerServices.TaskAwaiter&,JFrame.Configuration.ConfigurationManager.<LoadAllAsync>d__21&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HttpDeleter.<DeleteAsync>d__3>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HttpDeleter.<DeleteAsync>d__3&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Common.HttpWriter.<WriteAsync>d__6>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Common.HttpWriter.<WriteAsync>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JFrame.Configuration.ConfigurationManager.<LoadAsync>d__22&)
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
		// object& System.Runtime.CompilerServices.Unsafe.As<object,object>(object&)
		// System.Void* System.Runtime.CompilerServices.Unsafe.AsPointer<object>(object&)
	}
}