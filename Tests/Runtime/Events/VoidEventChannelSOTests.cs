namespace GameLibrary.SOWorkflowCommon.Events.Tests
{
	using NUnit.Framework;
	using UnityEngine;

	public class VoidEventChannelSOTests
	{
		VoidEventChannelSO _so;

		[SetUp]
		public void Initialize()
		{
			_so = ScriptableObject.CreateInstance<VoidEventChannelSO>();
		}

		[Test]
		public void NoEventNoExceptionTest()
		{
			_so.RaiseEvent();
		}

		[Test]
		public void RaisingEventTest()
		{
			bool eventRaised = false;
			_so.OnEventRaised += () => eventRaised = true;

			_so.RaiseEvent();

			Assert.True(eventRaised);
		}
	}
}
