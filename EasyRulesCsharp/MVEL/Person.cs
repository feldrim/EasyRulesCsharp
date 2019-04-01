using System;
namespace org.jeasy.rules.mvel {
	public class Person {
		public String Name { get; set; }
		public int Age { get; set; }
		private bool isAdult;

		public Person(ref String name, ref int age) {
			throw new System.Exception("Not implemented");
		}
		public bool IsAdult() {
			throw new System.Exception("Not implemented");
		}
		public void SetAdult(ref bool adult) {
			throw new System.Exception("Not implemented");
		}

	}

}
