namespace GameLibrary.SOWorkflowCommon.Events.Tests
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture(typeof(BoolEventChannelSO), typeof(bool), true)]
	[TestFixture(typeof(IntEventChannelSO), typeof(int), 53)]
	public class EventChannelValueBaseSOTests<TEvent, T>
		where TEvent : EventChannelValueBaseSO<T>
	{
		TEvent _event;
		T _nextEventValue;

		public EventChannelValueBaseSOTests(T nextEventValue)
		{
			this._nextEventValue = nextEventValue;
		}

		[SetUp]
		public void Initialize()
		{
			_event = ScriptableObject.CreateInstance<TEvent>();
		}

		[Test]
		public void NoEventNoExceptionTest()
		{
			_event.RaiseEvent(default(T));
		}

		[Test]
		public void RaisingEventWithValueTest()
		{
			T valueModifiedOnCallback = default(T);
			_event.OnEventRaised += (eventValue) => valueModifiedOnCallback = eventValue;

			_event.RaiseEvent(_nextEventValue);

			Assert.AreEqual(_nextEventValue, valueModifiedOnCallback);
		}
	}
}
