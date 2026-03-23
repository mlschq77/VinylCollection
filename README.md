# Baza danych Kolekcji Winyli

## Relacje

- **1..N**: Artist → Vinyls
- **1..N**: Vinyl → Tracks
- **N..M**: Vinyls ↔ Genres (GenreVinyl)

## Migracje

```
Add-Migration InitialSchema
Update-Database
```

## Schemat

- **Artists** (ArtistId PK, Name*, Bio, Country)
- **Vinyls** (VinylId PK, Title*, ReleaseYear*, Price, ArtistId FK*)
- **Tracks** (TrackId PK, Title*, SideAndNumber, DurationSeconds, VinylId FK*)
- **Genres** (GenreId PK, Name*)
- **GenreVinyl** (VinylId FK + GenreId FK — tabela pośrednia N:M)

## Technologie

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core 8
- SQL Server LocalDB
