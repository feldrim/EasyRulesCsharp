using System;
namespace org.jeasy.rules.core {
	public class RuleListenerTest : AbstractTest  {
		private org.jeasy.rules.api.RuleListener ruleListener1;
		private org.jeasy.rules.api.RuleListener ruleListener2;

		public override void Setup() {
			throw new System.Exception("Not implemented");
		}
		public void WhenTheRuleExecutesSuccessfully_thenOnSuccessShouldBeExecuted() {
			throw new System.Exception("Not implemented");
		}
		public void WhenTheRuleFails_thenOnFailureShouldBeExecuted() {
			throw new System.Exception("Not implemented");
		}
		public void WhenListenerBeforeEvaluateReturnsFalse_thenTheRuleShouldBeSkippedBeforeBeingEvaluated() {
			throw new System.Exception("Not implemented");
		}
		public void WhenListenerBeforeEvaluateReturnsTrue_thenTheRuleShouldBeEvaluated() {
			throw new System.Exception("Not implemented");
		}
		public void WhenTheRuleEvaluatesToTrue_thenTheListenerShouldBeInvoked() {
			throw new System.Exception("Not implemented");
		}
		public void WhenTheRuleEvaluatesToFalse_thenTheListenerShouldBeInvoked() {
			throw new System.Exception("Not implemented");
		}


	}

}
