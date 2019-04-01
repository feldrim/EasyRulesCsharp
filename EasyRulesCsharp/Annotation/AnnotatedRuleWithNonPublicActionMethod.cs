namespace EasyRulesCsharp.EasyRulesCsharp.Annotation {
	public class AnnotatedRuleWithNonPublicActionMethod {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		private void Then() {
			throw new System.Exception("Not implemented");
		}

	}

}
