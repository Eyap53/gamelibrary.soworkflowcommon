namespace GameLibrary.SOWorkflowCommon.Variables
{
	using UnityEngine;
	using UnityEngine.Events;

	public abstract class BaseVariableSO<Tstruct> : DescriptionBaseSO, ISerializationCallbackReceiver where Tstruct : struct
	{
		[SerializeField]
		private Tstruct initialValue;

		private Tstruct _runtimeValue;

		public Tstruct runtimeValue
		{
			get => _runtimeValue;
			set
			{
				if (!_runtimeValue.Equals(value))
				{
					_runtimeValue = value;
					if (OnValueChanged != null)
					{
						OnValueChanged(value);
					}
				}
			}
		}

		public UnityAction<Tstruct> OnValueChanged;

		public void OnAfterDeserialize()
		{
			runtimeValue = initialValue;
		}

		public void OnBeforeSerialize() { }
	}
}
