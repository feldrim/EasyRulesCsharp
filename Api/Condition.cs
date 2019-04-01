namespace EasyRulesCsharp.Api {
	/// <summary>
	/// This interface represents a rule's condition.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public interface Condition {

		/// <summary>
		/// Evaluate the condition according to the known facts.
		/// </summary>
		/// <param name="facts">known when evaluating the rule.</param>
		/// <returns>true if the rule should be triggered, false otherwise</returns>
		bool Evaluate(ref Facts facts);

	}

}
