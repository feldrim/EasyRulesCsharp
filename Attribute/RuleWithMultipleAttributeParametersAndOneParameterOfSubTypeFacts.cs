using System;
using EasyRulesCsharp.Api;
namespace EasyRulesCsharp.Attribute {
	public class RuleWithMultipleAttributeParametersAndOneParameterOfSubTypeFacts {
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
