using EasyRulesCsharp.EasyRulesCsharp.Api;
using Action = EasyRulesCsharp.EasyRulesCsharp.Api.Action;
namespace EasyRulesCsharp.EasyRulesCsharp.Core {
	public class DefaultRuleTest : AbstractTest  {
		private Condition condition;
		private Action action1;
		private Action action2;

		public void WhenConditionIsTrue_ThenActionsShouldBeExecutedInOrder() {
			throw new System.Exception("Not implemented");
		}
		public void WhenConditionIsFalse_ThenActionsShouldNotBeExecuted() {
			throw new System.Exception("Not implemented");
		}


	}

}
