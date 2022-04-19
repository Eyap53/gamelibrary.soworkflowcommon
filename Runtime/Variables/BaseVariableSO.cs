namespace GameLibrary.SOWorkflowCommon.Variables
{
	using UnityEngine;
	using UnityEngine.Events;

	public abstract class BaseVariableSO<Tstruct> : DescriptionBaseSO, ISerializationCallbackReceiver where Tstruct : struct
	{
		[SerializeField]
		private Tstruct _initialValue;

		private Tstruct _runtimeValue;

		public Tstruct runtimeValue
		{
			get => _runtimeValue;
		}

		public void SetValue(Tstruct value)
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

		public UnityAction<Tstruct> OnValueChanged;

		public void OnAfterDeserialize()
		{
			SetValue(_initialValue);
		}

		public void OnBeforeSerialize() { }
	}
}
