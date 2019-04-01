using System;
namespace org.jeasy.rules.annotation {
	public class AnnotatedRuleWithActionMethodHavingMoreThanOneArgumentOfTypeFacts {
		public bool When() {
			throw new System.Exception("Not implemented");
		}
		public void Then(ref org.jeasy.rules.api.Facts facts, ref org.jeasy.rules.api.Facts otherFacts) {
			throw new System.Exception("Not implemented");
		}

	}

}
