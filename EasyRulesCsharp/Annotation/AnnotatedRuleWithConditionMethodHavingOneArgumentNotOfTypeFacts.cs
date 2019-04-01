using System;
namespace org.jeasy.rules.annotation {
	public class AnnotatedRuleWithConditionMethodHavingOneArgumentNotOfTypeFacts {
		public bool Executed { get; }

		public bool When(ref int i) {
			throw new System.Exception("Not implemented");
		}
		public void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
