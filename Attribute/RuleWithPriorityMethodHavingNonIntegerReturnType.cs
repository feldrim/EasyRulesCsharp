using System;
namespace EasyRulesCsharp.Attribute {
	public class RuleWithPriorityMethodHavingNonIntegerReturnType {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		private void Then() {
			throw new System.Exception("Not implemented");
		}
		public String GetPriority() {
			throw new System.Exception("Not implemented");
		}

	}

}
