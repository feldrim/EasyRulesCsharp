using System;
namespace org.jeasy.rules.core {
	public class BasicRuleTest : AbstractTest  {
		public void BasicRuleEvaluateShouldReturnFalse() {
			throw new System.Exception("Not implemented");
		}
		public void TestCompareTo() {
			throw new System.Exception("Not implemented");
		}
		public void TestSortSequence() {
			throw new System.Exception("Not implemented");
		}

		class ThirdRule : BasicRule  {
			public int GetPriority() {
				throw new System.Exception("Not implemented");
			}
			public override bool Evaluate(ref org.jeasy.rules.api.Facts facts) {
				throw new System.Exception("Not implemented");
			}
			public String GetName() {
				throw new System.Exception("Not implemented");
			}

		}
		class SecondRule : BasicRule  {
			public int GetPriority() {
				throw new System.Exception("Not implemented");
			}
			public override bool Evaluate(ref org.jeasy.rules.api.Facts facts) {
				throw new System.Exception("Not implemented");
			}
			public String GetName() {
				throw new System.Exception("Not implemented");
			}

		}
		class FirstRule : BasicRule  {
			public int GetPriority() {
				throw new System.Exception("Not implemented");
			}
			public override bool Evaluate(ref org.jeasy.rules.api.Facts facts) {
				throw new System.Exception("Not implemented");
			}
			public String GetName() {
				throw new System.Exception("Not implemented");
			}

		}
	}

}
