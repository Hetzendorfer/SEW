Quelle: "C# mit Visual Studio 2015: Das umfassende Handbuch" von Andreas Kühnel, 7. aktualisierte und erweiterte Ausgabe, Rheinwerk Computing;
		Kapitel 8 Auflistungsklassen (Collections) und
		Kapitel 9 Generics - generische Datentypen

Generische Datentypen = weniger Programmieraufwand und einfacher zu lesen (bessere Wartung)

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

Bsp von Nichtgenerischer Klasse und generische Klasse Program.cs Zeile 25 - 35

Vorteile von Generics:
	offensichtliche Vorteil -> Typsicherheit
	bessere Leistung als bei Nichtgenerischen Collections zB ArrayList (Boxing und Unboxing = sehr aufwändige Operationen)


Constraints bei Generics mit where und dann welche Klasse und/oder Schnittstellen implementiert werden sollen
Verwendung: wenn zB eine Methode einer Schnittstelle/Klasse aufgerufen wird wie Dispose von IDisposable

	class Constraint<T> where T : IDisposable
    {
		public Constraint(T value)
        {
            T param = value;
            param.Dispose();
        }
    }

	class Constraint<T> where T : IDisposable
						where A : ICloneable, IDisposable
						where C : new()                     //wenn Typ einen öffentlichen, parameterlosen Konstruktor haben soll
	{
	}


Generics -> man weiß nicht ob der generische Datentyp T ein Wertdatentyp oder Referenzdatentyp ist
	bei einem Wertdatentyp würde ein Rückgabewert null eine Exception auslösen
	Lösung -> return default(T) -> bei Wertdatentyp wird 0 und bei Referenzdatentypen null zurückgegeben


Es gibt auch Generische Methoden

static class GenerischeMethode
{
    static public T DoSomething<T>(T value)
    {
        return default(T);
    }
}

Aufruf in Program.cs Zeile 37 - 39 (Langschreibweise und vom Compiler automatisch erkannter Datentyp Kurzschreibweise)

Hinweis: Klassen und Methoden generischer Datentyp dürfen nicht gleich heißen also nicht 2 mal T sondern zB A und T

Bsp: generische Methode mit Constraint

static public T DoSomething<T>(T value) where T : new()
{
    return default(T);
}


Vererbung von Generics: Bsp im Inheritance Folder


Kovarianz bei Generics: 
public void DoSomething(Interface<BaseClass> item)
{
	...
}

damit Aufruf: DoSomething(b) -> b ist vom Typ Interface<ChildClass> geht muss bei der Interface definition ein out vor dem T stehen

interface Interface<out T>{}

Kontravarianz: statt "out T" "in T" schreiben
