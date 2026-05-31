# Text Umwandler & Korrektur

Dieses Programm ist eine kleine Windows Forms Anwendung in C#, die als Gedächtnisspiel oder Tipp-Trainer dient. Es wandelt normalen Text in eine kompakte, großgeschriebene Form um und fordert den Nutzer heraus, das Original exakt wiederherzustellen.

## Funktionen

- **Text-Umwandlung**: Entfernt Leerzeichen, Kommas, Punkte, Bindestriche, Unterstriche und Semikolons. Wandelt alle Buchstaben in Großbuchstaben um (inkl. Ersetzung von `ß` durch `SS`).
- **Historie**: Speichert die eingegebenen Originaltexte intern in einer Liste (`text1`), um Vergleiche zu ermöglichen.
- **Validierung**: Der "Korrektur"-Button vergleicht die aktuelle Benutzereingabe mit dem zuletzt umgewandelten Originaltext (unabhängig von Groß-/Kleinschreibung am Anfang/Ende durch `Trim`).
- **Feedback**: Nutzt interaktive `MessageBoxes` und farbigen Text (Grün für Erfolg, Rot für Fehler), um dem Nutzer das Ergebnis mitzuteilen.

## Bedienung

1. **Eingabe**: Schreibe einen Satz in das untere (blaue) Eingabefeld.
2. **Umwandeln**: Klicke auf **"umwandeln"**. Dein Text wird oben "zerstört" (zusammengeschrieben) angezeigt. Das Originalfeld wird geleert.
3. **Erinnerung**: Versuche nun, den ursprünglichen Satz (inkl. aller Satzzeichen) in das mittlere Korrekturfeld einzugeben.
4. **Prüfung**: Klicke auf den Button **"Korrektur"**. Das Programm gibt dir sofort Rückmeldung, ob du den Text perfekt wiederhergestellt hast.

## Technische Voraussetzungen

- **Sprache**: C#
- **Plattform**: .NET Framework (Windows Forms)
- **IDE**: Visual Studio

## Projektstruktur

- `Form1.cs`: Enthält die Hauptlogik für die Textmanipulation und den String-Vergleich.
- `Form1.Designer.cs`: Definiert das visuelle Layout und die Verknüpfung der Event-Handler.
- `Program.cs`: Der Haupteinstiegspunkt für den Start der Applikation.

## Zukünftige Erweiterungen

- [ ] Hinzufügen eines Schwierigkeitsgrades.
- [ ] Implementierung einer Zeitmessung pro Korrekturversuch.
- [ ] Speichern von Statistiken (richtige vs. falsche Versuche).
