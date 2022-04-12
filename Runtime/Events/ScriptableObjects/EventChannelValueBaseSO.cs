namespace GameLibrary.SOWorkflowCommon.Events
{
	using UnityEngine.Events;

	public abstract class EventChannelValueBaseSO<T> : EventChannelBaseSO
	{
		public UnityAction<T> OnEventRaised;
		public void RaiseEvent(T value)
		{
			if (OnEventRaised != null)
				OnEventRaised.Invoke(value);
		}
	}
}
