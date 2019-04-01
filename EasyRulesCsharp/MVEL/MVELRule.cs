using System;
namespace org.jeasy.rules.mvel {
	/// <summary>
	/// A {@link org.jeasy.rules.api.Rule} implementation that uses <a href="https://github.com/mvel/mvel">MVEL</a> to evaluate and execute the rule.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class MVELRule : org.jeasy.rules.core.BasicRule  {
		private org.jeasy.rules.api.Condition condition = org.jeasy.rules.api.Condition.FALSE;
		private org.jeasy.rules.api.Action[] actions = new ArrayList<>();

		/// <summary>
		/// Create a new MVEL rule.
		/// </summary>
		public MVELRule() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Set rule name.
		/// </summary>
		/// <param name="name">of the rule</param>
		/// <returns>this rule</returns>
		public MVELRule Name(ref String name) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Set rule description.
		/// </summary>
		/// <param name="description">of the rule</param>
		/// <returns>this rule</returns>
		public MVELRule Description(ref String description) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Set rule priority.
		/// </summary>
		/// <param name="priority">of the rule</param>
		/// <returns>this rule</returns>
		public MVELRule Priority(ref int priority) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Specify the rule's condition as MVEL expression.
		/// </summary>
		/// <param name="condition">of the rule</param>
		/// <returns>this rule</returns>
		public MVELRule When(ref String condition) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Add an action specified as an MVEL expression to the rule.
		/// </summary>
		/// <param name="action">to add to the rule</param>
		/// <returns>this rule</returns>
		public MVELRule Then(ref String action) {
			throw new System.Exception("Not implemented");
		}
		public override bool Evaluate(ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public override void Execute(ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}



	}

}
