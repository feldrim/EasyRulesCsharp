namespace EasyRulesCsharp.Annotation {
	public class AnnotatedRuleWithNonPublicPriorityMethod {
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
