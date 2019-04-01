namespace EasyRulesCsharp.Annotation {
	public class AnnotatedRuleWithNonPublicConditionMethod {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		public void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
