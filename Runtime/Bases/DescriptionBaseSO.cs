namespace GameLibrary.SOWorkflowCommon
{
	using UnityEngine;

    /// <summary>
    /// Base class for ScriptableObjects that need a description field.
    /// </summary>
    public class DescriptionBaseSO : SerializableScriptableObject
	{
		[TextArea]
		[SerializeField]
		private string _description;
	}
}
