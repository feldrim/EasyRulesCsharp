using System;
namespace org.jeasy.rules.annotation {
	public class AnnotatedRuleWithNonPublicActionMethod {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		private void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
