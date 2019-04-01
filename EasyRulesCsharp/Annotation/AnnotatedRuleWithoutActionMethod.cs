using System;
namespace org.jeasy.rules.annotation {
	public class AnnotatedRuleWithoutActionMethod {
		public bool Executed { get; }

		public bool When() {
			throw new System.Exception("Not implemented");
		}
		public void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
