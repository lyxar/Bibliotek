# Krav til WPF-Program
Der skal udvikles en platform til et Bibliotek system, som skal følge disse krav:
### Generelle krav
 - [x] Projektet skal følge MVVM
 - [x] Projektet skal gøre brug af Entity Framework
 - [x] Bøger skal gemmes ved hjælp af en stregkode
 - [x] Bruger skal gemmes ved hjælp af en RFID kode
 - [x] Der skal være mulighed for CRUD af bøger
 - [x] Der skal være mulighed for CRUD af bruger
 - [x] Der skal kunne ses en liste over alle udlånte bøger
	- [ ] Udlånte bøger skal sorteres efter lånetid
	- [ ] Eventuelt paging

### Krav til udlåning/indlevering af bøger

- [x] Bruger skal kunne låne og aflevere bøger
- [x] Der skal ikke være behov for login/RFID ved aflevering af en bog
- [x] Ved aflevering af bøger skal der komme en besked frem
	- [x] Beskeden skal beskrive bogen
	- [ ] Beskeden skal beskrive låneren
- [x] Der kræves en RFID/Kode ved udlevering af en bog

## Der skal laves følgende vinduer
 - [x] Forside(Til navigation)
 - [x] CRUD til bøger
	 - [x] Opret bog
	 - [ ] Hent bog
	 - [ ] Opdater bog
	 - [x] Slet bog
 - [x] CRUD af bruger
	 - [x] Opret bruger
	 - [ ] Hent bruger
	 - [ ] Opdater bruger
	 - [x] Slet bruger
 - [x] Lån bog
 - [x] Aflever bog
 - [x] Liste over udlåntebøger

## Database diagram

<img src="https://i.imgur.com/VUmtGfi.png">

## Kode diagram

<img src="https://i.imgur.com/oih7UkQ.png">

