# Katalon test web aplikacije

Katalon Studio je rješenje za automatizirano testiranje web stranica. Katalon Studio nudi dvostruko sučelje za stvaranje testnih slučajeva, takozvani manualni prikaz za korisnike koji nisu toliko iskusni i drugi prikaz, prikaz skripte za iskusnije korisnike koji su upoznati s testiranjem te samom sintaksom. Možemo napomenuti da Katalon prati Page Model Object te omogućava snimanje komandi, elementa itd. te njihovo daljnje korištenje. Preteća ovog alata je Selenium IDE Firefox extension. 


Glavne značajke alata:
* Dostupan je kao Firefox/Chrome browser extension ili kao desktop aplikacija Katalon Studio
* Snimanje testova putem record&play funkcionalnosti
* Snimanje UI testova koji simuliraju rad krajnjeg korisnika
* Koristan za brze korake i učenje automatizacije
* Spremanje i izvoz testa kao skripte u XML, WebDriver (C#, Java, Ruby, Python 2)
* Omogućava samostalno pisanje skripti bez korištenja snimalice ručnim unosom naredbi (sadrži
izbornik s objašnjenjima najčešće korištenih Selenium naredbi)
* Jednostavnije regresijsko testiranje prilikom implementacije nove funkcionalnost
* Dodatna dokumentacija o alatu dostupna na Katalon [stranici] (https://docs.katalon.com/katalon-recorder/docs/samples.html#sample-project), uključujući primjer projekta


Svaki zapis sadrži:
* **Command** – naredba koja će se izvršiti (npr. “open”, “type”, “click”, “verifyText”)
* **Target** – na koji HTML element se odnosi naredba (textbox, header, table)
* **Value** – koristi se za naredbe koje trebaju imati definirane vrijednosti (npr. Ispisati nešto u
textbox)
### Selenium WebDriver
Selenium WebDriver koristi naredbe snimljene putem Katalon alata i šalje ih pregledniku. Navedeni
proces je implementiran putem drivera za određeni preglednik, koji šalje naredbe preglednika, a
browser vraća rezultate. WebDriver izravno pokreće instancu preglednika i upravlja njime.

### NUnit framework
NUnit je unit testing framework za Microsoft .NET. Samostalno ne kreira skripte za testiranje, ali
omogućava pokretanje Unit testova unutar Visual Studia
Značajke
* Testovi se mogu pokretati kroz konzolu ili putem Test Adaptera kroz Visual Studio
* Testovi se mogu paralelno izvršavati
* Svaki test se može dodati za jednu ili više kategorija, za selektivno pokretanje

Ključne riječi koje se definiraju unutar testa u Visual Studiu:
* **[SetUp]** – pokretanje preglednika (Firefox, Chrome, Intern Explorer, Edge, Opera, Safari)
* **[TearDown]** – otvaranje web stranice
* **[Test]** – zatvaranje preglednika


U svrhu ovog testiranja korištena je ekstenzija na browseru.
Praćenjem navedenih koraka možete pratiti postupak testiranja web stranice pomoću Katalon testa.

## 1.Instalacija Katalon Recordera
> 1. Kliknite na proširenja u svom browseru
>
> 2. Dodajte Katalon Recorder proširenje

## 2.Stvaranje test slučajeva 
> 1. Pokrenite Katalon Recorder
>
> 2. Dodamo novi Test Suite
> 
> 3. Za svoj Test Suite dodamo novi Test Case te ga nazovemo kako želimo odnosno što testirati
>
> 4. Kliknemo crveni gumn "Record"
>
> 5. Odlazimo na stranicu koju testiramo te radimo akcije koje želimo na toj stranici
> 
> 6. Zaustavimo snimanje klikom na gumb "Record"

## 3.Dohvaćanje koda za testiranje
>1. Kliknite na gumb Export
>
>2. Odaberemo u kojem formatu želimo izvesti skriptu

U ovom primjeru korišten je format C# (WebDriver+Nunit)

## 4.Postavljanje okruženja za automatsko testiranje
>1. Stvaranje novog projekta (Visual Studio)
>
>2. Odaberemo Unit Test projekt
>
>3. Potrebno je dodati navedene pakete:
• NUnit framework (3.13.0)
• Selenium WebDriver (3.141.0)
• Selenium Support(3.141.0)
• Nunit3 Test Adapter (3.17.0)
• Selenium WebDriver – Gecko Driver (0.28.0) – izvođenje testa u Firefox-u
>4. Uključiti Test Explorer
>
>5. Testovi vidlji su nakon pokretanja Build->Build Solution
>
>6. Testovi se pokreću iz Test Explorera

## Opis testiranja demo web aplikacije JPet Store
Aplikacija omogućuje korisniku kupovinu kućnih ljubimaca. Također omogućuje prijavu korisnika te dodavanje ljubimaca u košaricu.
Testiranje se sastoji od 6 testnih slučajeva:
>* Dodavanje kućnog ljubimca u košaricu za kupovinu
>* Dodavanje kućnog ljubimca u košaricu za kupovinu te micanje jednog ljubimca iz košarice
>* Prijava postojećeg korisnika u sustav za kupovinu
>* Pretraživanje kućnih ljubimaca pomoću "Search" opcije
>* Ažuriranje stanja košarice za kupovinu (mjenjanje broja pojedinih ljubimaca u košarici)
>* Narudžba i kupovina kućnog ljubimca
