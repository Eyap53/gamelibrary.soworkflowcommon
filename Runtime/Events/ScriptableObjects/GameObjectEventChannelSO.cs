namespace GameLibrary.SOWorkflowCommon.Events
{
	using UnityEngine;

	/// <summary>
	/// This class is used for Events that have one gameobject argument.
	/// Example: A game object pick up event event, where the GameObject is the object we are interacting with.
	/// </summary>
	[CreateAssetMenu(menuName = "GameLibrary/SO Workflow Common/Events/GameObject Event Channel", fileName = "GameObjectEvent_Channel")]
	public class GameObjectEventChannelSO : EventChannelValueBaseSO<GameObject>
	{
	}
}
