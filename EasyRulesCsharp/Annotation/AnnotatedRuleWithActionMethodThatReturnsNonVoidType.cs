using System;
namespace org.jeasy.rules.annotation {
	public class AnnotatedRuleWithActionMethodThatReturnsNonVoidType {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		private int Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
