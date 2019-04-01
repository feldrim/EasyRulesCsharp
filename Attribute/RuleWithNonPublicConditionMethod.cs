namespace EasyRulesCsharp.Attribute {
	public class RuleWithNonPublicConditionMethod {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		public void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
