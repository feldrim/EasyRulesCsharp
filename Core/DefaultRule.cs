using System;
using EasyRulesCsharp.Api;
using Action = EasyRulesCsharp.Api.Action;
namespace EasyRulesCsharp.Core {
	class DefaultRule : BasicRule  {
		private Condition condition = Condition.FALSE;
		private Action[] actions = new ArrayList<>();

		DefaultRule(ref String name, ref String description, ref int priority, ref Condition condition, ref java.util.List<Action> actions) {
			throw new System.Exception("Not implemented");
		}
		public override bool Evaluate(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public override void Execute(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}


	}

}
