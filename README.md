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
- [ ] Mutationshistorie von Kontaktdaten
- [ ] Login
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
- **UI:** [MaterialSkin.2](https://www.nuget.org/packages/MaterialSkin.2)
- **Persistenz:** Serialisierung in Datei (z. B. JSON/Binär)

## Projektstruktur

```
Zbw.PF2.ContactManager/
├── ContactManager.sln
├── ContactManager/
│   ├── Models/          # Person, Kunde, Mitarbeiter, Kontaktnotiz
│   ├── Services/         # Datenzugriff, Speichern/Laden, Suche
│   ├── Forms/             # Windows-Forms (UI)
│   └── Program.cs
├── docs/                  # Konzept, Klassendiagramm
└── README.md
```

## Installation & Ausführung

### Voraussetzungen
- Visual Studio 2022 (oder neuer)
- .NET SDK (Version siehe `global.json` / Projektdatei)

### Schritte
1. Repository klonen
   ```bash
   git clone https://github.com/<org>/Zbw.PF2.ContactManager.git
   ```
2. Lösung `ContactManager.sln` in Visual Studio öffnen
3. NuGet-Pakete werden beim Build automatisch wiederhergestellt
4. Projekt starten (F5)

Beim ersten Start wird der Datenstamm automatisch angelegt; bei jedem weiteren Start automatisch geladen.

## Status

Aktueller Bearbeitungsstand und offene Punkte: siehe `STATUS.md` bzw. GitHub Projects Board.

## Abgabe

- **Frist:** 20.09.2026, 23:00 Uhr
- Pro angefangener Stunde Verzögerung: -1.0 auf die Gesamtnote
- Commits nach der Frist führen zur Bewertung mit Note 1
