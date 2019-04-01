using System;
namespace org.jeasy.rules.support {
	public class UnitRuleGroupTest {
		private org.jeasy.rules.api.Rule rule1;
		private org.jeasy.rules.api.Rule rule2;
		private org.jeasy.rules.api.Facts facts = new Facts();
		private org.jeasy.rules.api.Rules rules = new Rules();
		private org.jeasy.rules.core.DefaultRulesEngine rulesEngine = new DefaultRulesEngine();
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
