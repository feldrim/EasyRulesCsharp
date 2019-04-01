namespace EasyRulesCsharp.Attribute {
	public class RuleWithoutConditionMethod {
		public bool Executed { get; }

		public bool When() {
			throw new System.Exception("Not implemented");
		}
		public void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
