Quelle: "C# mit Visual Studio 2015: Das umfassende Handbuch" von Andreas Kühnel, 7. aktualisierte und erweiterte Ausgabe, Rheinwerk Computing;
		Kapitel 8 Auflistungsklassen (Collections) und
		Kapitel 9 Generics - generische Datentypen

Generische Datentypen = weniger Programmieraufwand und einfacher zu lesen (besserne Wartung)
Variablen = Platzhalter für Daten

nun einen Schritt abstrakter -> Generics
Generics = Platzhalter für Datentypen

von C# vorgebene generische Collections im Namespace "System.Collections.Generic":
	Dictionary<T, M>:      Dictionary<int, string> dictionary = new Dictionary<int, string>();
	HashSet<T>:            HashSet<int> hashSet = new HashSet<int>();
	List<T>:               List<int> list = new List<int>();
	Queue<T>:			   Queue<string> queue = new Queue<string>();
	Stack<T>:			   Stack<int> stack = new Stack<int>();

Alle haben die Schnittstelle IEnumerable<T>, IEnumerable, ICollection implementiert (HashSet und List auch ICollection<T>)

yield bei Collections (Bsp siehe Klassen  EigeneCollection<T> & Test)
