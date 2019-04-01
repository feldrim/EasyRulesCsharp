namespace EasyRulesCsharp.Annotation {
	public class AnnotatedRuleWithPriorityMethodHavingArguments {
		public bool Executed { get; }

		private bool When() {
			throw new System.Exception("Not implemented");
		}
		private void Then() {
			throw new System.Exception("Not implemented");
		}
		public int GetPriority(ref int i) {
			throw new System.Exception("Not implemented");
		}

	}

}
