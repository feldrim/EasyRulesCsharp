namespace EasyRulesCsharp.Annotation {
	public class AnnotatedRuleWithMoreThanOnePriorityMethod {
		public bool Executed { get; }

		public bool When() {
			throw new System.Exception("Not implemented");
		}
		public void Then() {
			throw new System.Exception("Not implemented");
		}
		public int GetPriority() {
			throw new System.Exception("Not implemented");
		}
		public int GetRulePriority() {
			throw new System.Exception("Not implemented");
		}

	}

}
