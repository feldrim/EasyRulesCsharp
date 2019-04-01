using System;
namespace org.jeasy.rules.core {
	class NoSuchFactException {
		public String MissingFact { get; }

		public NoSuchFactException(ref String message, ref String missingFact) {
			throw new System.Exception("Not implemented");
		}

	}

}
