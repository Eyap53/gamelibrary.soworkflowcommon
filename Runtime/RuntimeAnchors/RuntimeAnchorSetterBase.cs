namespace GameLibrary.SOWorkflowCommon.RuntimeAnchors
{
	using UnityEngine;

	public abstract class RuntimeAnchorSetterBase<TAnchor, TComponent> : MonoBehaviour
		where TAnchor : RuntimeAnchorBase<TComponent>
		where TComponent : Component
	{
		[SerializeField]
		private TAnchor _runtimeAnchor;

		void Awake()
		{
			TComponent component = GetComponent<TComponent>();
			_runtimeAnchor.Provide(component);
		}
	}
}
