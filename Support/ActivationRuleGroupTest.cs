using EasyRulesCsharp.Api;
using EasyRulesCsharp.Core;
namespace EasyRulesCsharp.Support {
	public class ActivationRuleGroupTest {
		private Facts facts = new Facts();
		private Rules rules = new Rules();
		private DefaultRulesEngine rulesEngine = new DefaultRulesEngine();

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
