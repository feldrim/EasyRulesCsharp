namespace EasyRulesCsharp.EasyRulesCsharp.Api {
	public class RulesTest {
		private Rules rules = new Rules();

		public void Register() {
			throw new System.Exception("Not implemented");
		}
		public void RulesMustHaveUniqueName() {
			throw new System.Exception("Not implemented");
		}
		public void Unregister() {
			throw new System.Exception("Not implemented");
		}
		public void UnregisterByName() {
			throw new System.Exception("Not implemented");
		}
		public void UnregisterByNameNonExistingRule() {
			throw new System.Exception("Not implemented");
		}
		public void IsEmpty() {
			throw new System.Exception("Not implemented");
		}
		public void Clear() {
			throw new System.Exception("Not implemented");
		}
		public void Sort() {
			throw new System.Exception("Not implemented");
		}
		public void WhenRegisterNullRule_thenShouldThrowNullPointerException() {
			throw new System.Exception("Not implemented");
		}
		public void WhenUnregisterNullRule_thenShouldThrowNullPointerException() {
			throw new System.Exception("Not implemented");
		}


		class DummyRule {
			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then() {
				throw new System.Exception("Not implemented");
			}

		}
	}

}
