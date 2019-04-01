using System;
namespace org.jeasy.rules.support {
	public class ActivationRuleGroupTest {
		private org.jeasy.rules.api.Facts facts = new Facts();
		private org.jeasy.rules.api.Rules rules = new Rules();
		private org.jeasy.rules.core.DefaultRulesEngine rulesEngine = new DefaultRulesEngine();

		public void OnlySelectedRuleShouldBeExecuted_whenComposingRulesHaveDifferentPriorities() {
			throw new System.Exception("Not implemented");
		}
		public void OnlySelectedRuleShouldBeExecuted_whenComposingRulesHaveSamePriority() {
			throw new System.Exception("Not implemented");
		}
		public void WhenNoSelectedRule_thenNothingShouldHappen() {
			throw new System.Exception("Not implemented");
		}


		public class Rule4 {
			public bool Executed { get; }

			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then() {
				throw new System.Exception("Not implemented");
			}

		}
		public class Rule3 {
			public bool Executed { get; }

			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then() {
				throw new System.Exception("Not implemented");
			}

		}
		public class Rule2 {
			public bool Executed { get; }

			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then() {
				throw new System.Exception("Not implemented");
			}

		}
		public class Rule1 {
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
