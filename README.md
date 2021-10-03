# Techmania
Master thesis 


Kratak opis koda:
Solution sadrži 3 aplikacije i 3 bazna projekta

Client app je blazor web assembly tip aplikacije
Server app je blazor server tip aplikacije
API se koristi za vlastite apije koje možete testirati


Prilikom startupa odaberite da vam se otvaraju točnim redom projekti (startup project) pod opcijama solutiona:
API
Client
Server

Client isključivo radi s bazom preko API-a.
Korišteni su Stripe payment API i Mailjet za slanje maila o potvrdi narudžbe na kijentu.

Cjelokupni proces narudžbe mobitela, upravljanje narudžbom mobitela, autorizacijom korisnika na klijentu i serveru radi, mijenjanje role registriranih korisnika.
Client registrirani korisnici ne mogu koristiti Server app i obratno. U bazi IdentityUser je za Server aplikaciju, ApplicationUser je za Client aplikaciju.

Ukoliko koristite pravi mail prilikom narudžbe, dolazi vam mail potvrde o narudžbi.
