namespace GameLibrary.SOWorkflowCommon.Events
{
	using UnityEngine;

    public abstract class EventChannelBaseSO : ScriptableObject
	{
		[TextArea] public string description;
	}
}
