namespace EasyRulesCsharp.Attribute {
	public class RuleWithActionMethodThatReturnsNonVoidType {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		private int Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
