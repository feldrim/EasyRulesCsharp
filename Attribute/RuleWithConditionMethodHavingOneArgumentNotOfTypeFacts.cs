namespace EasyRulesCsharp.Attribute {
	public class RuleWithConditionMethodHavingOneArgumentNotOfTypeFacts {
		public bool Executed { get; }

		public bool When(ref int i) {
			throw new System.Exception("Not implemented");
		}
		public void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
