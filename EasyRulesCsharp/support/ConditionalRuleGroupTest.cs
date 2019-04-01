using EasyRulesCsharp.EasyRulesCsharp.Api;
using EasyRulesCsharp.EasyRulesCsharp.Core;
namespace EasyRulesCsharp.EasyRulesCsharp.Support {
	public class ConditionalRuleGroupTest {
		private Rule rule1;
		private Rule rule2;
		private Rule conditionalRule;
		private Facts facts = new Facts();
		private Rules rules = new Rules();
		private DefaultRulesEngine rulesEngine = new DefaultRulesEngine();
		private ConditionalRuleGroup conditionalRuleGroup;

		public void SetUp() {
			throw new System.Exception("Not implemented");
		}
		public void RulesMustNotBeExecutedIfConditionalRuleEvaluatesToFalse() {
			throw new System.Exception("Not implemented");
		}
		public void RulesMustBeExecutedForThoseThatEvaluateToTrueIfConditionalRuleEvaluatesToTrue() {
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
		public void TwoRulesWithSameHighestPriorityIsNotAllowed() {
			throw new System.Exception("Not implemented");
		}
		public void TwoRulesWithSamePriorityIsAllowedIfAnotherRuleHasHigherPriority() {
			throw new System.Exception("Not implemented");
		}
		public void ARuleWithoutPriorityHasAHighPriororty() {
			throw new System.Exception("Not implemented");
		}


		public class UnprioritizedRule {
			public bool Executed { get; }

			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then() {
				throw new System.Exception("Not implemented");
			}

		}
		public class MyOtherRule {
			public bool Executed { get; }
			private int priority;

			public MyOtherRule(ref int priority) {
				throw new System.Exception("Not implemented");
			}
			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then() {
				throw new System.Exception("Not implemented");
			}
			public int Priority() {
				throw new System.Exception("Not implemented");
			}

		}
		public static class MyAnnotatedRule {
			public bool Executed { get; }

			public bool Evaluate() {
				throw new System.Exception("Not implemented");
			}
			public void Execute() {
				throw new System.Exception("Not implemented");
			}
			public int Priority() {
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
			public int Priority() {
				throw new System.Exception("Not implemented");
			}

		}
	}

}
