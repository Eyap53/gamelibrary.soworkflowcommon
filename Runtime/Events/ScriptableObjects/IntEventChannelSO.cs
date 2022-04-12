namespace GameLibrary.SOWorkflowCommon.Events
{
	using UnityEngine;

	/// <summary>
	/// This class is used for Events that have one int argument.
	/// Example: An Achievement unlock event, where the int is the Achievement ID.
	/// </summary>
	[CreateAssetMenu(menuName = "GameLibrary/SO Workflow Common/Events/Int Event Channel", fileName = "IntEvent_Channel")]
	public class IntEventChannelSO : EventChannelValueBaseSO<int>
	{
	}
}
