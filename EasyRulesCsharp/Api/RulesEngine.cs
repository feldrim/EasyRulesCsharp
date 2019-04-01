using System;
using EasyRulesCsharp.EasyRulesCsharp.Core;
namespace EasyRulesCsharp.EasyRulesCsharp.Api {
	/// <summary>
	/// Rules engine interface.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public interface RulesEngine {
		/// <summary>
		/// Return the rules engine parameters.
		/// 
		/// @return The rules engine parameters
		/// </summary>
		RulesEngineParameters Parameters { get; }
		/// <summary>
		/// Return the list of registered rule listeners.
		/// 
		/// @return the list of registered rule listeners
		/// </summary>
		RuleListener[] RuleListeners { get; }
		/// <summary>
		/// Return the list of registered rules engine listeners.
		/// 
		/// @return the list of registered rules engine listeners
		/// </summary>
		RulesEngineListener[] RulesEngineListeners { get; }

		/// <summary>
		/// Fire all registered rules on given facts.
		/// </summary>
		void Fire(ref Rules rules, ref Facts facts);
		/// <summary>
		/// Check rules without firing them.
		/// </summary>
		/// <returns>a map with the result of evaluation of each rule</returns>
		java.util.Map<Rule, Boolean> Check(ref Rules rules, ref Facts facts);

	}

}
