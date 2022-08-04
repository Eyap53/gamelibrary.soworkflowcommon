namespace GameLibrary.SOWorkflowCommon.Events
{
	using UnityEngine;

	/// <summary>
	/// This class is used for Events that have one float argument.
	/// </summary>
	[CreateAssetMenu(menuName = "GameLibrary/SO Workflow Common/Events/Float Event Channel", fileName = "FloatEvent_Channel")]
	public class FloatEventChannelSO : EventChannelValueBaseSO<float>
	{
	}
}
