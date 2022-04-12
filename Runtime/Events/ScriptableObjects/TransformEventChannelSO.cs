namespace GameLibrary.SOWorkflowCommon.Events
{
	using UnityEngine;

	/// <summary>
	/// This class is used for Events that have one transform argument.
	/// Example: Spawn system initializes player and fire event, where the transform is the position of player.
	/// </summary>
	[CreateAssetMenu(menuName = "GameLibrary/SO Workflow Common/Events/Transform Event Channel", fileName = "TransformEvent_Channel")]
	public class TransformEventChannelSO : EventChannelValueBaseSO<Transform>
	{
	}
}
