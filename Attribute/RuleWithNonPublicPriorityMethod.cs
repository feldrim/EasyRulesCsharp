namespace EasyRulesCsharp.Attribute {
	public class RuleWithNonPublicPriorityMethod {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		private void Then() {
			throw new System.Exception("Not implemented");
		}
		private int GetPriority() {
			throw new System.Exception("Not implemented");
		}

	}

}
