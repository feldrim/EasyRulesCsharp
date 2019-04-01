namespace EasyRulesCsharp.Attribute {
	public class RuleWithNonPublicActionMethod {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		private void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
