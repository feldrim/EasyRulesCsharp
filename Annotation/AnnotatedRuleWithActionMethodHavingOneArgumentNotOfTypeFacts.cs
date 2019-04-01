namespace EasyRulesCsharp.Annotation {
	public class AnnotatedRuleWithActionMethodHavingOneArgumentNotOfTypeFacts {
		public bool Executed { get; }

		public bool When() {
			throw new System.Exception("Not implemented");
		}
		public void Then(ref int i) {
			throw new System.Exception("Not implemented");
		}

	}

}
