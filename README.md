# Zbw.PF2.ContactManager

Semesterprojekt im Modul **Programming Foundation II**
Dipl. Techniker/in HF Informatik – ZbW Zentrum für berufliche Weiterbildung

## Beschreibung

Windows-Forms-Anwendung (C# .NET) zur Verwaltung von Mitarbeiter- und Kundendaten eines Schweizer Unternehmens. Die Anwendung deckt die üblichen CRUD-Operationen ab und ermöglicht zusätzlich die Protokollierung von Kundenkontakten inkl. Historie.

## Team

| Name | Rolle |
|---|---|
| Danijel Malinovic | Teamleiter/in |
| Marko Celikic | Entwickler/in |
| Nikola Arbutina | Entwickler/in |

## Funktionen

### Pflicht
- Erfassen, Mutieren, Aktivieren/Deaktivieren und Löschen von Mitarbeitern und Kunden - Funktioniert
- Automatische Vergabe von Mitarbeiternummern - Funktioniert
- Protokollierung von Kontaktnotizen mit Historie (Kunden) - Funktioniert
- Suche nach Name, Vorname, Geburtsdatum, Mitarbeiter/Kunde - Funktioniert
- Automatisches Speichern und Laden des Datenstamms auf der Festplatte - Funktioniert

### Optional
- [x] Dashboard
- [x] CSV-/VCard-Import
- [x] Login

## Datenmodell

Die Anwendung basiert auf einer Vererbungshierarchie:

```
Person (abstrakt)
├── Kunde
└── Mitarbeiter
```

**Person** (Basisklasse)
- Anrede, Vorname, Nachname, Geburtsdatum, Geschlecht, Titel, Telefonnummer Geschäft, Mobiltelefonnummer, E-Mail-Adresse

**Kunde**
- Status (aktiv/passiv)
- Kontaktprotokoll (Notizen inkl. Historie)

**Mitarbeiter**
- Mitarbeiternummer, Abteilung, AHV-Nummer, Wohnort, Nationalität, Adresse, Postleitzahl, Eintrittsdatum, Austrittsdatum, Beschäftigungsgrad, Rolle, Kaderstufe (0-5), Lehrjahre, aktuelles Lehrjahr, Geschäftsadresse

## Technologie-Stack

- **Sprache:** C#
- **Framework:** .NET 10 / Windows Forms
- **Persistenz:** Serialisierung in Dateien (CSV)
## Projektstruktur

```
Zbw.PF2.ContactManager/
├── ContactManager.sln
├── ContactManager/
│   ├── Core/          # Kerndaten und -funktionen, keine Businesslogik
│   ├── Models/        # Person, Kunde, Mitarbeiter, Kontaktnotiz
│   ├── Data/          # Datenzugriff, Speichern/Laden
│   ├── Services/      # Business Logik
│   ├── UI/            # Windows-Forms (UI)
│   └── Program.cs
└── README.md
```

## Installation & Ausführung

### Voraussetzungen
- Visual Studio 2026 (oder neuer) oder Rider von Jetbrains
- .NET SDK 10

### Schritte
1. Repository klonen
   ```bash
   git clone https://github.com/malinovic/Zbw.PF2.ContactManager.git
   ```
2. Lösung `ZBW.PF2.ContactManager.sln` in Visual Studio öffnen
3. NuGet-Pakete werden beim Build automatisch wiederhergestellt
4. Projekt starten (F5)
5. Einloggen mit Standardbenutzer: `admin` / `admin`

Der leere Datenstamm wird beim ersten Start automatisch im Roaming Ordner (C:\Users\<benutzer>\AppData\Roaming\.contact_manager) erstellt. Die Anwendung speichert die Daten in CSV-Dateien im Anwendungsverzeichnis.

Folgende Dateien werden automatisch erstellt:
- `customers.csv` – Kundendaten
- `employees.csv` – Mitarbeiterdaten
- `contact_notes.csv` – Kontaktnotizen
- `users.csv` – Benutzerkonten

Wenn am Ende das Verzeichnis bereinigt werden soll, können sie dass Skript [./Clear_Roaming.ps1](./Clear_Roaming.ps1) ausführen, welches dass Verzeichnis leert.

## Status

Aktueller Bearbeitungsstand und offene Punkte: siehe GitHub Projects Board.

## Abgabe

- **Frist:** 20.09.2026, 23:00 Uhr
- Pro angefangener Stunde Verzögerung: -1.0 auf die Gesamtnote
- Commits nach der Frist führen zur Bewertung mit Note 1
