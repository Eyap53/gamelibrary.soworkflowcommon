namespace GameLibrary.SOWorkflowCommon.Events
{
	using UnityEngine;

	/// <summary>
	/// This class is used for Events that have one Vector3 argument.
	/// Example: An Achievement unlock event, where the Vector3 is the Achievement ID.
	/// </summary>
	[CreateAssetMenu(menuName = "GameLibrary/SO Workflow Common/Events/Vector3 Event Channel", fileName = "Vector3Event_Channel")]
	public class Vector3EventChannelSO : EventChannelValueBaseSO<Vector3>
	{
	}
}
