namespace EasyRulesCsharp.Attribute {
	public class RuleWithConditionMethodHavingNonBooleanReturnType {
		public bool Executed { get; }

		public int When() {
			throw new System.Exception("Not implemented");
		}
		public void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
