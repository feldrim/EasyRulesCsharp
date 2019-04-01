using EasyRulesCsharp.EasyRulesCsharp.Api;
namespace EasyRulesCsharp.EasyRulesCsharp.Annotation {
	public class AnnotatedRuleWithActionMethodHavingMoreThanOneArgumentOfTypeFacts {
		public bool When() {
			throw new System.Exception("Not implemented");
		}
		public void Then(ref Facts facts, ref Facts otherFacts) {
			throw new System.Exception("Not implemented");
		}

	}

}
