namespace EasyRulesCsharp.Core {
	public class AnnotationInheritanceTest : AbstractTest  {
		public void AnnotationsShouldBeInherited() {
			throw new System.Exception("Not implemented");
		}

		class MyChildRule : MyBaseRule  {
		}
		class MyBaseRule {
			public bool Executed { get; }

			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then() {
				throw new System.Exception("Not implemented");
			}

		}
	}

}
