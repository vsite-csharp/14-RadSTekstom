RadSTekstom
===========

Unicode
-------
Ilustracija kako .NET Framework rukuje Unicode (UTF-16) znakovima.


NepromjenjivostStringa
----------------------
Ilustracija kako je String nepromjenjivi objekt.


Funkcije
--------
Primjer kako metode sa znakovnim nizovima ne mijenjaju originalni već vraćaju novi objekt.


LeksičkeUsporedbe
-----------------
Usporedbe tekstova vodeći računa o leksičkim pravilima za pojedine kulture.


PretvorbaStringaUObjekt
-----------------------
Primjer pretvorbe teksta u tip double: kako lokalizacijske postavke utječu na rezultat.


PretvorbaStringaUDatum
----------------------
Primjer metode ParseExact kojom se izbjegavaju neodređenosti u formatu.


KodiranjeTeksta
---------------
Primjer različitih kodiranja (ASCII, UTF-16, UTF-8) i base-64 kodiranja na tekstu. 
Uočiti da kodirani tekst zauzima više prostora od izvornog jer koristi manji skup znakova 
(64 znaka).


LokalizacijaDijaloga
--------------------
Kako se lokalizacija izvedodi na grafičkom sučelju:
1. Inicijalno se svi dijalozi kreiraju sa svjstvima Localizable = false i Language = SystemDefault
   (kliknuti na dijalog i pogledati Properties).
   Uz takve postavke Designer tekstove svih poruka upisuje izravno u kod (u datoteke xxx.Designer.cs)
   - otvoriti tu datoteku i pogledati kod metode InitializeComponents-
2. Kada se nekom dijalogu promijeni svojstvo Localizable u true (ili se svojstvo Language promijeni  
   u neki jezik), Visual Studio će automatski kreirati datoteke s lokaliziranim resursima 
   (nastavak .resx) u koje će pohranjivati lokalizirane tekstove. Designer će u kod metode 
   InitializeComponents dodati instancu klase ComponentResourceManager koja će se brinuti za
   učitavanje odgovarajućih resursa.
3. Promijenimo li jezik npr. u Croatian te prevedemo tekstove na kontrolama, Visual Studio će
   generirati datoteku xxx.hr.resx u koju će pohraniti hrvatske tekstove. Slično će napraviti
   i za druge jezike.
4. Prevođenjem koda, lokalizirani resursi se pohranjuju u satelitske DLL-ove u podkazalima
   koja nose naziv odgovarajuće jezične kratice ("hr", "de" i sl.)
5. Tijekom izvođenja ComponentResourceManager učitava resurse iz odgovarajućeg DLL-a


Lokalizacija teksta
-------------------
Ako treba lokalizirati samo tekstove, treba ručno generirati resx datoteku (Add item - Resource file)
te ručno kreirati ResourceManager klasu koja će se brinuti o učitavanju odgovarajućih resursa.