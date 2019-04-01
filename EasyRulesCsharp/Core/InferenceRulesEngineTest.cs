using EasyRulesCsharp.EasyRulesCsharp.Api;
namespace EasyRulesCsharp.EasyRulesCsharp.Core {
	public class InferenceRulesEngineTest {
		public void TestCandidateSelection() {
			throw new System.Exception("Not implemented");
		}
		public void TestCandidateOrdering() {
			throw new System.Exception("Not implemented");
		}

		class AnotherDummyRule {
			private bool isExecuted;
			public long Timestamp { get; }

			public bool When(ref bool bar) {
				throw new System.Exception("Not implemented");
			}
			public void Then(ref Facts facts) {
				throw new System.Exception("Not implemented");
			}
			public int Priority() {
				throw new System.Exception("Not implemented");
			}
			public bool IsExecuted() {
				throw new System.Exception("Not implemented");
			}

		}
		class DummyRule {
			private bool isExecuted;
			public long Timestamp { get; }

			public bool When(ref bool foo) {
				throw new System.Exception("Not implemented");
			}
			public void Then(ref Facts facts) {
				throw new System.Exception("Not implemented");
			}
			public int Priority() {
				throw new System.Exception("Not implemented");
			}
			public bool IsExecuted() {
				throw new System.Exception("Not implemented");
			}

		}
	}

}
