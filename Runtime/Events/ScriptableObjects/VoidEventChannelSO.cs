namespace GameLibrary.SOWorkflowCommon.Events
{
	using UnityEngine;
	using UnityEngine.Events;

	/// <summary>
	/// This class is used for Events that have no arguments (Example: Exit game event)
	/// </summary>
	[CreateAssetMenu(menuName = "GameLibrary/SO Workflow Common/Events/Void Event Channel", fileName = "VoidEvent_Channel")]
	public class VoidEventChannelSO : EventChannelBaseSO
	{
		public UnityAction OnEventRaised;

		public void RaiseEvent()
		{
			if (OnEventRaised != null)
				OnEventRaised.Invoke();
		}
	}
}
