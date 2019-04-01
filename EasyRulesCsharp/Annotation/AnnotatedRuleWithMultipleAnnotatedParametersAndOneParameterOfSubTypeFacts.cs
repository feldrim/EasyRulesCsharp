using System;
using EasyRulesCsharp.EasyRulesCsharp.Api;
namespace EasyRulesCsharp.EasyRulesCsharp.Annotation {
	public class AnnotatedRuleWithMultipleAnnotatedParametersAndOneParameterOfSubTypeFacts {
		public bool When(ref Object fact1, ref Object fact2, ref SubFacts facts) {
			throw new System.Exception("Not implemented");
		}
		public void Then(ref Object fact1, ref Object fact2, ref SubFacts facts) {
			throw new System.Exception("Not implemented");
		}

		public static class SubFacts : Facts  {
		}
	}

}
