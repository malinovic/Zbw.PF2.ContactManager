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
- Erfassen, Mutieren, Aktivieren/Deaktivieren und Löschen von Mitarbeitern und Kunden
- Automatische Vergabe von Mitarbeiternummern
- Protokollierung von Kontaktnotizen mit Historie (Kunden)
- Suche nach Name, Vorname, Geburtsdatum, Mitarbeiter/Kunde
- Automatisches Speichern und Laden des Datenstamms auf der Festplatte

### Optional
- [ ] Dashboard
- [ ] CSV-/VCard-Import

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
- **Framework:** .NET / Windows Forms
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
- Visual Studio 2026 (oder neuer)
- .NET SDK 10

### Schritte
1. Repository klonen
   ```bash
   git clone https://github.com/malinovic/Zbw.PF2.ContactManager.git
   ```
2. Lösung `ZBW.PF2.ContactManager.sln` in Visual Studio öffnen
3. NuGet-Pakete werden beim Build automatisch wiederhergestellt
4. Projekt starten (F5)

## Status

Aktueller Bearbeitungsstand und offene Punkte: siehe GitHub Projects Board.

## Abgabe

- **Frist:** 20.09.2026, 23:00 Uhr
- Pro angefangener Stunde Verzögerung: -1.0 auf die Gesamtnote
- Commits nach der Frist führen zur Bewertung mit Note 1
