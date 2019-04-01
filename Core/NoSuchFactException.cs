using System;
namespace EasyRulesCsharp.Core {
	class NoSuchFactException {
		public String MissingFact { get; }

		public NoSuchFactException(ref String message, ref String missingFact) {
			throw new System.Exception("Not implemented");
		}

	}

}
