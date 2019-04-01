namespace EasyRulesCsharp.Annotation {
	public class AnnotatedRuleWithConditionMethodHavingNonBooleanReturnType {
		public bool Executed { get; }

		public int When() {
			throw new System.Exception("Not implemented");
		}
		public void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
