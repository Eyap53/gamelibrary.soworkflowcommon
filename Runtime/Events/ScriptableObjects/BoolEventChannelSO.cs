namespace GameLibrary.SOWorkflowCommon.Events
{
	using UnityEngine;

	/// <summary>
	/// This class is used for Events that have a bool argument.
	/// Example: An event to toggle a UI interface
	/// </summary>
	[CreateAssetMenu(menuName = "GameLibrary/SO Workflow Common/Events/Bool Event Channel", fileName = "BoolEvent_Channel")]
	public class BoolEventChannelSO : EventChannelValueBaseSO<bool>
	{
	}
}
