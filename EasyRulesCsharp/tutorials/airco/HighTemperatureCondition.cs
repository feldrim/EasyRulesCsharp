using EasyRulesCsharp.EasyRulesCsharp.Api;
namespace EasyRulesCsharp.EasyRulesCsharp.Tutorials.airco {
	public class HighTemperatureCondition : Condition  {
		/// <summary>
		/// A NoOp {@link Condition} that always returns true.
		/// </summary>
		public Condition TRUE = new Condition() {
        @Override
        public boolean evaluate(Facts facts) {
            return true;
        }
    };
		/// <summary>
		/// A NoOp {@link Condition} that always returns false.
		/// </summary>
		public Condition FALSE = new Condition() {
        @Override
        public boolean evaluate(Facts facts) {
            return false;
        }
    };

		static HighTemperatureCondition ItIsHot() {
			throw new System.Exception("Not implemented");
		}
		public bool Evaluate(ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Evaluate the condition according to the known facts.
		/// </summary>
		/// <param name="facts">known when evaluating the rule.</param>
		/// <returns>true if the rule should be triggered, false otherwise</returns>
		public bool Evaluate(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}

	}

}
