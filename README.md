# Grupa11-TimAltTab

# Opis teme

BeFit aplikacija nudi planiranje i pravljenje detaljnih programa za trening(tjelovježbu). Korisnik ima mogućnost pravljenja planova(programa) ili kupovanja planova od licenciranih trenera. Korisnik ima mogućnost da vidi izradu vježbe i mišićnu grupu koju vježba najviše pogađa. Aplikacija nudi i ocjenjivanje trenera. Omogućeno je da korisnik pogleda lokacije obližnjih teretana i protein shop-ova.

# Članovi tima

Emin Skopljak, Fatih Zukorlić, Haris Šoljić

# Proces

Pravljenje programa: 

Korisnik se logira i odabira opciju pravljanje programa.
Programi se sastoje od mnogih vježbi raspoređenih po danima.
Korisnik može podešavati intenzitet vježbi(odrediti broj setova i ponavljanja).
Ukoliko korisnik odabere nepoželjnu kombinaciju vježbi i dana, aplikacija upozorava korisnika.
Ako korisnik ne zna ili ne želi praviti program, može odabrati neki od predefinisanih ili unajmiti trenera da to uradi za njeg.

# Funkcionalnosti

- Kreiranje accounta
	- Svaki korisnik aplikacije mora imati svoj account. 
	- Postoje tri tipa accounta(klijent, trener i admin).
	- Sa login stranice je moguće kreirati račun kao klijent ili kao trener.
- Pregled vježbi
	- Aplikacija nudi pregled vježbe grupisane po mišićnim grupama aktiviranim
		prilikom rada istih.
- Pravljenje programa
	- Korisnik kreira sopstveni programa sastavljen od vježbi raspoređenih po danima.
- Preuzimanje programa
	- Korisnik preuzima(kupuje) predefinisani program od certificiranih trenera.	
- Ocjenjivanje trenera
	- Program svakog trenera može biti ocijenjen od klijenata koji su preuzeli njegov program.
	- Korisnik pri preuzimanju programa vidi ocjenu tog programa i trenera.
- Komentarisanje trenera
	- Uključeno u ocjenjivanje trenera.
	- Također pomaže korisnicima pri odlučivanju koji program preuzeti.
- Ocjenjivanje programa
	- Uključeno u ocjenjivanje trenera.
- Pregled obližnjih teretana i protein shop-ova
- Podešavanje intenziteta vježbi
	- Prije dodavanja vježbe u programa potrebno je podesiti intenzitet vježbe.
	- Ukoliko je vježba isometrična korisnik podešava vrijeme izrade vježbi ili podešava broj setova/ponavljanja.
# Akteri

- Klijent
	- Klijent ima mogućnost pravljenja accounta, pregleda vježbi, planova, unajmljivanje trenera i pregled obližnjih objekata.
- Admin
	- Odobrava trenere
	- Cenzuriše komentare
	- ...
- Trener
	- Pravi planove
	- Iznajmljuje planove
