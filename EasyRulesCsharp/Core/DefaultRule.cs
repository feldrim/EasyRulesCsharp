using System;
namespace org.jeasy.rules.core {
	class DefaultRule : BasicRule  {
		private org.jeasy.rules.api.Condition condition = org.jeasy.rules.api.Condition.FALSE;
		private org.jeasy.rules.api.Action[] actions = new ArrayList<>();

		DefaultRule(ref String name, ref String description, ref int priority, ref org.jeasy.rules.api.Condition condition, ref java.util.List<org.jeasy.rules.api.Action> actions) {
			throw new System.Exception("Not implemented");
		}
		public override bool Evaluate(ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public override void Execute(ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}


	}

}
