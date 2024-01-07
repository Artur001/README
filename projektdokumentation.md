# Projekt-Dokumentation

Artur Bytyqi

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   18.08.23    | 1.0.0   | Programm begonnen und fertig gemacht |
|  01.09.23     | 1.0.1    |     Projekt-Dokumentation auf GitHub gewechselt    |
|  07.01.24     | 1.1.0    |     Update der Dokumentation    |

## 1 Informieren

### 1.1 Ihr Projekt

**Ziel des Projekts:** Entwicklung eines Spiels, bei dem der Benutzer eine zufällig generierte Zahl zwischen 1 und 100 erraten muss. Der Fokus liegt auf der Anwendung von OOP.

**Produktbeschreibung:** Das Programm bietet ein Zahlenratenspiel mit Benutzerfeedback. Der Spieler wird informiert, ob die erratene Zahl zu hoch oder zu niedrig ist. Nach dem Erraten der Zahl zeigt das Spiel die Anzahl der benötigten Versuche an und gibt die Möglichkeit, das Spiel neu zu starten.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |          Muss       |  Funktion    |Als Benutzer möchte ich, dass das Programm automatisch eine Zahl zwischen 1-100 generiert.|
| 2  |              Muss   |  Funktion    |Als ein Benutzer soll ich Feedback bekommen, ob die Zahl richtig oder falsch ist.|
| 3  |      Muss           |  Funktion    |Als ein Benutzer, soll ich benachrichtigt werden, wenn mein versuchter Rat kleiner ist|
| 4  |          Muss       |  Funktion    |  Als ein Benutzer, soll ich benachrichtigt werden, soll die mein versuchter Rat habe, grösser ist|
| 5  |              Muss   |  Funktion    |  Als ein Benutzer, soll ich benachrichtigt werden, wenn die Zahl erraten habe|
| 6  |              Muss   |  Funktion    |  Als ein Benutzer, soll mir, wenn ich die Zahl erraten habe, angezeigt werden, wieviele Versuche ich gebraucht habe |
|  7 |              Kann   | Qualität    |  Als ein Benutzer, soll der Text "ausgeschrieben" werden und nicht plötzlich angezeigt werden|
| 8  |              Muss   |  Funktion    |  Als ein Benutzer, soll ich gefragt werden, ob ich nochmals spielen will|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |    Programm gestartet|   (Keine Eingabe)    |    Es soll eine Zahl generiert werdem             |
| 2.1  |  Programm läuft            |   User ratet eine Zahl    |     Es soll dem User sagen, ob es richtig oder falsch ist.              |
| 3.1  |  Programm läuft            |    User ratet eine Zahl     |     Es soll dem User sagen, ob die Zahl grösser ist.      |
|4.1  |  Programm läuft            |    User ratet eine Zahl     |  Es soll dem User sagen, ob die Zahl kleiner ist.                       |
| 5.1  |  Programm läuft            |    Zahl richtig erraten     |     Programm soll dem Benutzer sagen, wieviel Versuche er gebraucht hat            |
| 5.2  |  Programm läuft            |    Zahl erraten     |     Programm soll den Benutzer loben.
| 6.1  |  Programm läuft            |    Buchstabe   |     Programm soll dem Benutzer sagem, er soll nur Zahlen benutzen und keine Buchstaben.           |
| 7.1  |  Programm läuft            |    (Keine Eingabe)   |     Programm soll seinen Text "ausschreiben" und nicht plötzlich auftauchen lassen.           |
| 8.1  |  Programm läuft            |    (Keine Eingabe)     |     Programm soll den Benutzer fragen, ob er nochmal spielen möchte  ( Y / N )       |
| 8.2  |  Programm läuft            |    Y     |     Programm soll das Spiel neustarten          |
| 8.3  |  Programm läuft            |    N     |     Programm soll beendet werden |


### Testprotokoll

 
| TC-№ | Datum | Resultat | Tester |Testumgebung|
| ---- | ----- | -------- | ------ | ------ |
| 1.1  |    01.09.2023   |     Funktioniert. Zahl wird zufällig generiert.	|  Artur Bytyqi      |Windows 11|
| 2.1  |    01.09.2023   |     Funktioniert. Programm gibt richtiges Feedback.	|  Artur Bytyqi      |Windows 11|
| 3.1  |    01.09.2023   |     Funktioniert. Spiel sagt, ob die Zahl größer ist.	|  Artur Bytyqi      |Windows 11|
| 4.1  |    01.09.2023   |     Funktioniert. Zeigt an, wenn die Zahl kleiner ist.	|  Artur Bytyqi      |Windows 11|
| 5.1  |    01.09.2023   |     Funktioniert. Spiel teilt Anzahl der Versuche mit.	 |  Artur Bytyqi      |Windows 11|
| 5.2  |    01.09.2023   |     Funktioniert. Programm lobt bei richtiger Zahl.	 |  Artur Bytyqi      |Windows 11|
| 6.1  |    08.09.2023   |     Funktioniert. Warnt bei Eingabe von Buchstaben.	 |  Artur Bytyqi      |Windows 11|
| 7.1  |    08.09.2023   |     Funktioniert. Text wird langsam angezeigt.	 |  Artur Bytyqi      |Windows 11|
| 8.1  |    08.09.2023   |     Funktioniert. Fragt, ob nochmal gespielt werden will.	 |  Artur Bytyqi      |Windows 11|
| 8.2  |    08.09.2023   |     Funktioniert. Spiel startet neu bei 'Y'.	 |  Artur Bytyqi      |Windows 11|
| 8.3  |    08.09.2023   |     Funktioniert. Spiel endet bei 'N'. |  Artur Bytyqi      |Windows 11|

