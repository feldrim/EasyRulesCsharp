using System;
namespace org.jeasy.rules.core {
	public class FactInjectionTest {
		public void DeclaredFactsShouldBeCorrectlyInjectedByNameOrType() {
			throw new System.Exception("Not implemented");
		}
		public void RulesShouldBeExecutedWhenFactsAreCorrectlyInjected() {
			throw new System.Exception("Not implemented");
		}
		public void WhenFactTypeDoesNotMatchParameterType_thenShouldThrowRuntimeException() {
			throw new System.Exception("Not implemented");
		}
		public void WhenADeclaredFactIsMissingInEvaluateMethod_thenTheRuleShouldNotBeExecuted() {
			throw new System.Exception("Not implemented");
		}
		public void WhenADeclaredFactIsMissingInExecuteMethod_thenTheRuleShouldNotBeExecuted() {
			throw new System.Exception("Not implemented");
		}

		class WeatherRule {
			private bool isExecuted;

			public bool ItRains(ref bool rain) {
				throw new System.Exception("Not implemented");
			}
			public void TakeAnUmbrella(ref org.jeasy.rules.api.Facts facts) {
				throw new System.Exception("Not implemented");
			}
			public bool IsExecuted() {
				throw new System.Exception("Not implemented");
			}

		}
		class AgeRule {
			private bool isExecuted;

			public bool IsAdult(ref int age) {
				throw new System.Exception("Not implemented");
			}
			public void PrintYourAreAdult() {
				throw new System.Exception("Not implemented");
			}
			public bool IsExecuted() {
				throw new System.Exception("Not implemented");
			}

		}
		class AnotherDummyRule {
			private bool isExecuted;

			public bool When() {
				throw new System.Exception("Not implemented");
			}
			public void Then(ref Object fact) {
				throw new System.Exception("Not implemented");
			}
			public bool IsExecuted() {
				throw new System.Exception("Not implemented");
			}

		}
		class DummyRule {
			public Object Fact1 { get; }
			public Object Fact2 { get; }
			public org.jeasy.rules.api.Facts Facts { get; }

			public bool When(ref Object fact1, ref Object fact2) {
				throw new System.Exception("Not implemented");
			}
			public void Then(ref org.jeasy.rules.api.Facts facts) {
				throw new System.Exception("Not implemented");
			}


		}
	}

}
