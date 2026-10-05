# Racing League Tools — Flex Renderer API

Reference for the data objects that Racing League Tools provides to Flex Renderer themes: object names, field names and field types, as used in layout expressions.


## Documentation

- [Flex Renderer manual](https://vlad-men.github.io/RacingLeagueTools_Docs/flex-renderer/manual/)
- [Data objects](https://vlad-men.github.io/RacingLeagueTools_Docs/flex-renderer/manual/data-objects/) — which object a layout receives
- [Discord](https://discord.gg/faE4bmnJmz) — questions and feedback

## Structure

Each folder contains one group of data objects. A file is named after the object it describes.

| Folder | Contents |
| --- | --- |
| `Base` | Shared objects (drivers, teams, tracks and similar) |
| `League`, `Championship`, `Season` | League, championship and season data |
| `Session` | Session and race results |
| `Standings` | Driver and team standings |
| `Statistics` | Statistics |
| `PenaltySystem` | Penalties |
| `DeepRatingsSeason` | Deep ratings for a season |
| `Teammates` | Teammate comparisons |
| `DriverStatisticsMultiseason`, `TeamStatisticsMultiseason`, `TeamStandingsMultiseason`, `TrackStatisticsMultiseason` | Multi-season data |
| `Enums` | Allowed values for fields with a fixed set of options |

## Usage

1. Find the object for your layout in the Data objects page of the manual.
2. Open the file with the same name in this repository.
3. Use the field names from that file in expressions.

The files are written as code declarations. Only the field names and types are relevant: `public string Name { get; set; }` is a text field named `Name`. The files are not a package and are not meant to be built.

