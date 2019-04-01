using EasyRulesCsharp.Api;
using EasyRulesCsharp.Core;
namespace EasyRulesCsharp.Support {
	public class UnitRuleGroupTest {
		private Rule rule1;
		private Rule rule2;
		private Facts facts = new Facts();
		private Rules rules = new Rules();
		private DefaultRulesEngine rulesEngine = new DefaultRulesEngine();
		private UnitRuleGroup unitRuleGroup;

		public void SetUp() {
			throw new System.Exception("Not implemented");
		}
		public void WhenNoComposingRulesAreRegistered_thenUnitRuleGroupShouldEvaluateToFalse() {
			throw new System.Exception("Not implemented");
		}
		public void CompositeRuleAndComposingRulesMustBeExecuted() {
			throw new System.Exception("Not implemented");
		}
		public void CompositeRuleMustNotBeExecutedIfAComposingRuleEvaluatesToFalse() {
			throw new System.Exception("Not implemented");
		}
		public void WhenARuleIsRemoved_thenItShouldNotBeEvaluated() {
			throw new System.Exception("Not implemented");
		}
		public void TestCompositeRuleWithAnnotatedComposingRules() {
			throw new System.Exception("Not implemented");
		}
		public void WhenAnnotatedRuleIsRemoved_thenItsProxyShouldBeRetrieved() {
			throw new System.Exception("Not implemented");
		}


		public static class MyAnnotatedRule {
			public bool Executed { get; }

			public bool Evaluate() {
				throw new System.Exception("Not implemented");
			}
			public void Execute() {
				throw new System.Exception("Not implemented");
			}

		}
		public class MyRule {
			public bool Executed { get; }

			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then() {
				throw new System.Exception("Not implemented");
			}

		}
	}

}
