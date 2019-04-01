using System;
using EasyRulesCsharp.Api;
namespace EasyRulesCsharp.MVEL {
	/// <summary>
	/// This class is an implementation of {@link Condition} that uses <a href="https://github.com/mvel/mvel">MVEL</a> to evaluate the condition.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class MVELCondition : Condition  {
		private const org.slf4j.Logger LOGGER = LoggerFactory.getLogger(MVELCondition.class);
		private String expression;
		private java.io.Serializable compiledExpression;
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

		/// <summary>
		/// Create a new {@link MVELCondition}.
		/// </summary>
		/// <param name="expression">the condition written in expression language</param>
		public MVELCondition(ref String expression) {
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
