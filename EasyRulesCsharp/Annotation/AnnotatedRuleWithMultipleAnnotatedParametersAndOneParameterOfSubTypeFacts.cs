using System;
namespace org.jeasy.rules.annotation {
	public class AnnotatedRuleWithMultipleAnnotatedParametersAndOneParameterOfSubTypeFacts {
		public bool When(ref Object fact1, ref Object fact2, ref SubFacts facts) {
			throw new System.Exception("Not implemented");
		}
		public void Then(ref Object fact1, ref Object fact2, ref SubFacts facts) {
			throw new System.Exception("Not implemented");
		}

		public static class SubFacts : org.jeasy.rules.api.Facts  {
		}
	}

}
