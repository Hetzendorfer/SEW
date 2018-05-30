

async und await sind Schlüsselwörter, die die TPL (Task Parallel Library) erweitert. 
Durch die TPL wurde die Klasse Task und Task<TResult> in C# hinzugefügt, die ein paralleles Ausführen der Anwendung
auf mehreren Prozessorkernen ermöglicht. Threads nutzen nur einen Prozessorkern.

using System.Threading.Tasks;

Liefert ein Task einen Wert zurück wird Task<TResult> verwendet.
Mit Threads kann keine Methode mit Rückgabewert ausgeführt werden -> Vorteil für Tasks


Um auf den Wert einer asynchronen Methode zu warten, muss await vor dem Aufruf der Methode geschrieben werden
und die Methode, die die asynchrone Methode aufruft, muss mit async ergänzt werden.

	static async void Start()
    {
        await DoSomethingAsync(1);
        Console.WriteLine("Nach Aufruf von SoSomethingAsync(1) ...");
    }

	static Task DoSomethingAsync(int id)
    {
        Task task = Task.Run(() =>
        {
            Console.WriteLine("Operation {0} startet ...", id);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Operation {0} ist beendet ...", id);
        });
        return task;
    }

Methode mit Rückgabewert müssen immer mit await erwartet werden, um den Rückgabewert in eine Variable zu speichern.
Jedoch kann zuerst die Task<T> Referenz entgegengenommen werden und der Rückgabewert zu einen späteren Zeitpunkt
mit await gespeichert werden.


Web-Server Kommunikation
4 Möglichkeiten:
	Client zu Server (Request und Response)
	Server zu Client (Solicit-Response)
	Client zu Server (One-Way)
	Server zu Client (Notification)

HTTP-METHODEN:
	GET
	POST
	PUT
	DELETE
	OPTIONS