using System;
using EasyRulesCsharp.EasyRulesCsharp.Api;
namespace EasyRulesCsharp.EasyRulesCsharp.Core {
	public class DefaultRulesEngineTest : AbstractTest  {
		public org.junit.rules.ExpectedException ExpectedException = ExpectedException.none();
		private RuleListener ruleListener;
		private RulesEngineListener rulesEngineListener;
		private AnnotatedRule annotatedRule;

		public override void Setup() {
			throw new System.Exception("Not implemented");
		}
		public void WhenConditionIsTrue_thenActionShouldBeExecuted() {
			throw new System.Exception("Not implemented");
		}
		public void WhenConditionIsFalse_thenActionShouldNotBeExecuted() {
			throw new System.Exception("Not implemented");
		}
		public void RulesMustBeTriggeredInTheirNaturalOrder() {
			throw new System.Exception("Not implemented");
		}
		public void RulesMustBeCheckedInTheirNaturalOrder() {
			throw new System.Exception("Not implemented");
		}
		public void ActionsMustBeExecutedInTheDefinedOrder() {
			throw new System.Exception("Not implemented");
		}
		public void AnnotatedRulesAndNonAnnotatedRulesShouldBeUsableTogether() {
			throw new System.Exception("Not implemented");
		}
		public void WhenRuleNameIsNotSpecified_thenItShouldBeEqualToClassNameByDefault() {
			throw new System.Exception("Not implemented");
		}
		public void WhenRuleDescriptionIsNotSpecified_thenItShouldBeEqualToConditionNameFollowedByActionsNames() {
			throw new System.Exception("Not implemented");
		}
		public void TestCheckRules() {
			throw new System.Exception("Not implemented");
		}
		public void ListenerShouldBeInvokedBeforeCheckingRules() {
			throw new System.Exception("Not implemented");
		}
		public void NullFactsShouldNotCrashTheEngine() {
			throw new System.Exception("Not implemented");
		}
		public void TestGetRuleListeners() {
			throw new System.Exception("Not implemented");
		}
		public void GetRuleListenersShouldReturnAnUnmodifiableList() {
			throw new System.Exception("Not implemented");
		}
		public void TestGetRulesEngineListeners() {
			throw new System.Exception("Not implemented");
		}
		public void GetRulesEngineListenersShouldReturnAnUnmodifiableList() {
			throw new System.Exception("Not implemented");
		}
		public void ClearRules() {
			throw new System.Exception("Not implemented");
		}


		public class DummyRule {
			public bool Condition() {
				throw new System.Exception("Not implemented");
			}
			public void Action1() {
				throw new System.Exception("Not implemented");
			}
			public void Action2() {
				throw new System.Exception("Not implemented");
			}

		}
		public class AnnotatedRule {
			public bool Executed { get; }
			public String ActionSequence { get; }

			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then0() {
				throw new System.Exception("Not implemented");
			}
			public void Then1() {
				throw new System.Exception("Not implemented");
			}
			public void Then2() {
				throw new System.Exception("Not implemented");
			}
			public int GetPriority() {
				throw new System.Exception("Not implemented");
			}


		}
	}

}
