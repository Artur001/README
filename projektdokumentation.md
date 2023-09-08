# Projekt-Dokumentation

Artur Bytyqi

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   18.08.23    | 1.0.0   | Programm begonnen und fertig gemacht |
|  01.09.23     | 1.0.1    |     Projekt-Dokumentation auf GitHub gewechselt    |

## 1 Informieren

### 1.1 Ihr Projekt

Mein Projekt ist ein normales Spiel, wo man Zahlen von 1-100 erraten soll. Es hat noch kleine andere Funktionen. 

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    Muss           |   Funktion   | Als ein Benutzer, soll das Programm funktionieren und benutzbar sein |
| 2  |          Muss       |  Funktion    |Als ein Benutzer, soll das Programm eine Zahl zwischen 1-100 generieren|
| 3  |              Muss   |  Funktion    |Als ein Benutzer soll ich eine Zahl erraten können|
| 5  |      Muss           |  Funktion    |Als ein Benutzer, soll ich benachrichtigt werden, wenn meine erratene Zahl kleiner ist|
| 6  |          Muss       |  Funktion    |  Als ein Benutzer, soll ich benachrichtigt werden, soll die Zahl die ich erraten habe, grösser ist|
| 7  |              Muss   |  Funktion    |  Als ein Benutzer, soll ich benachrichtigt werden, wenn die Zahl erraten habe|
| 8  |              Muss   |  Funktion    |  Als ein Benutzer, soll mir, wenn ich die Zahl erraten habe, angezeigt werden, wieviele Versuche ich gebraucht habe |
| 9  |              Kann   | Qualität    |  Als ein Benutzer, soll der Text "ausgeschrieben" werden und nicht plötzlich angezeigt werden|
| 10  |              Muss   |  Funktion    |  Als ein Benutzer, soll ich gefragt werden, ob ich nochmals spielen will|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |    Programm gestartet|   -     |    Es soll eine Zahl generiert werdem             |
| 2.1  |  Programm läuft            |   User ratet eine Zahl    |     Es soll dem User sagen, ob es richtig oder falsch ist.              |
| 3.1  |  Programm läuft            |    User ratet eine Zahl     |     Es soll dem User sagen, ob die Zahl grösser ist.      |
|4.1  |  Programm läuft            |    User ratet eine Zahl     |  Es soll dem User sagen, ob die Zahl kleiner ist.                       |
| 5.1  |  Programm läuft            |    Zahl richtig erraten     |     Programm soll dem Benutzer sagen, wieviel Versuche er gebraucht hat            |
| 5.2  |  Programm läuft            |    Zahl erraten     |     Programm soll den Benutzer loben.
| 6.1  |  Programm läuft            |    Buchstabe   |     Programm soll dem Benutzer sagem, er soll nur Zahlen benutzen und keine Buchstaben.           |
| 7.1  |  Programm läuft            |    -   |     Programm soll seinen Text "ausschreiben" und nicht plötzlich auftauchen lassen.           |
| 8.1  |  Programm läuft            |    -     |     Programm soll den Benutzer fragen, ob er nochmal spielen möchte  ( Y / N )       |
| 8.2  |  Programm läuft            |    Y     |     Programm soll das Spiel neustarten          |
| 8.3  |  Programm läuft            |    N     |     Programm soll beendet werden |


### Testprotokoll

 

| TC-№ | Datum | Resultat | Tester |Testumgebung|
| ---- | ----- | -------- | ------ | ------ |
| 1.1  |    01.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 2.1  |    01.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 3.1  |    01.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 4.1  |    01.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 5.1  |    01.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 5.2  |    01.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 6.1  |    08.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 7.1  |    08.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 8.1  |    08.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 8.2  |    08.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
| 8.3  |    08.09.2023   |     Funktioniert     |  Artur Bytyqi      |Windows 11|
