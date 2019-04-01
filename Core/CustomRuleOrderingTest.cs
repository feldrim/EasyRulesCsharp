using EasyRulesCsharp.Api;
namespace EasyRulesCsharp.Core {
	public class CustomRuleOrderingTest : AbstractTest  {
		private MyRule rule1;
		private MyRule rule2;

		public void WhenCompareToIsOverridden_thenShouldExecuteRulesInTheCustomOrder() {
			throw new System.Exception("Not implemented");
		}


		class MyRule : BasicRule  {
			public override int CompareTo(ref Rule rule) {
				throw new System.Exception("Not implemented");
			}


		}
	}

}
