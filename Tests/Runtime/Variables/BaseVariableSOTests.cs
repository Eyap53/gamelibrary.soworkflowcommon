namespace GameLibrary.SOWorkflowCommon.Variables.Tests
{
	using NUnit.Framework;
	using UnityEngine;

	[TestFixture(typeof(IntVariableSO), typeof(int), 53)] // test for IntVariableSO
	[TestFixture(typeof(BoolVariableSO), typeof(bool), true)]
	[TestFixture(typeof(FloatVariableSO), typeof(float), 53.136f)]
	public class VariableSOTests<TVariableSO, Tstruct>
		where TVariableSO : BaseVariableSO<Tstruct>
		where Tstruct : struct
	{
		TVariableSO _so;
		Tstruct _nextValue;

		public VariableSOTests(Tstruct nextValue)
		{
			this._nextValue = nextValue;
		}

		[SetUp]
		public void Initialize()
		{
			_so = ScriptableObject.CreateInstance<TVariableSO>();
		}

		[Test]
		public void UpdateRuntimeValue()
		{
			_so.SetValue(_nextValue);
			Assert.AreEqual(_so.runtimeValue, _nextValue);
		}

		[Test]
		public void UpdateRaiseCallback()
		{
			Tstruct valueModifiedOnCallback = default(Tstruct);
			_so.OnValueChanged += (v) => valueModifiedOnCallback = v;

			_so.SetValue(_nextValue);

			Assert.AreEqual(_nextValue, valueModifiedOnCallback);
			Assert.True(true);
		}

		[Test]
		public void NoChangeRaiseNoCallback()
		{
			_so.SetValue(_nextValue);

			bool callbackCalled = false;
			_so.OnValueChanged += (v) => callbackCalled = true;
			_so.SetValue(_nextValue);

			Assert.False(callbackCalled);
		}
	}
}
