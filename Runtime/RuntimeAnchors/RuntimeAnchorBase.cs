namespace GameLibrary.SOWorkflowCommon.RuntimeAnchors
{
	using UnityEngine;
	using UnityEngine.Events;

	public abstract class RuntimeAnchorBase<T> : DescriptionBaseSO
	{
		public UnityAction OnAnchorProvided;

		private bool _isSet = false;

		[SerializeField]
		private T _value;

		/// <summary>
		/// Is the Anchor already set ?
		/// </summary>
		/// <remarks>
		/// Any script can check if the transform is null before using it, by just checking this bool.
		/// To set the object, see <see cref="Provide"/>Provide(T value)</see>.
		/// </remarks>
		public bool isSet
		{
			get => _isSet;
		}

		public T value
		{
			get => _value;
		}


		public void Provide(T value)
		{
			if (value == null)
			{
				Debug.LogError("A null value was provided to the " + this.name + " runtime anchor.");
				return;
			}

			_value = value;
			_isSet = true;

			if (OnAnchorProvided != null)
				OnAnchorProvided.Invoke();
		}

		public void Unset()
		{
			_value = default(T);
			_isSet = false;
		}

		private void OnDisable()
		{
			Unset();
		}
	}
}
