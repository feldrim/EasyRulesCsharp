using System;
namespace org.jeasy.rules.core {
	/// <summary>
	/// Null value in facts must be accepted, this is not same thing that fact missing
	/// </summary>
	public class NullFactAnnotationParameterTest : AbstractTest  {
		public void TestNullFact() {
			throw new System.Exception("Not implemented");
		}
		public void TestMissingFact() {
			throw new System.Exception("Not implemented");
		}

		public class AnnotatedParametersRule {
			public bool When(ref Object fact1, ref Object fact2) {
				throw new System.Exception("Not implemented");
			}
			public void Then(ref Object fact1, ref Object fact2) {
				throw new System.Exception("Not implemented");
			}

		}
	}

}
