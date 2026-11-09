##### Azonositasduofeladat
Csoportos feladat C# programozási nyelv
## Csoport tagok: 
  - Piri Nóra
  - Kárpáti Liliána 

#### Programm működése:

### Bemenet:
## A felhasználónak három lehetősége van a menüben:
1. gomb: Ha ezt választja az user, akkor a programm azt várja el, hogy beírjuk a típusát az érkező járműnek.
  - Ha autó a bemenet -> A programm kéri fogja az Autó rendszámát, és autómatikusan elmenti a külön fáljba.
  - Ha olyan rendszámot ad meg a felhasználó, ami már bent van, akkor autómatikusan kiírja, hogy ez a jármű már szerepel és előrről indul a programm.
  - Ha bármi más a bemenet, akkor a belépőnek a nevét és igazolványszámát kell megadni. A fáljba az is el lesz mentve, hogy milyen járművel lépett be.
  - Ugyanúgy fennál az, hogy ha már bent lévő azonosítót adunk meg, akkor nem fogja mégegyszer elmenteni.
   
2. gomb: Ha ezt választja az user, akkor a programnak azokat az azonosítókat kell megadni, amik távoztak.
  - Ha olyan azonosítót ad meg az ember, amelyik nincs bent a adatok között, akkor nem fog megtörténni a mentés és ki fogyja írni, hogy ilyen azonosító nincs.
  - Azon kívűl az azonosító helyes begadása után a gyűjtőfáljba autómatikusan el lesz mentve a távozás időpontja.
    
3. gomb: Ha ezt a gombot választja az user, akkor itt lehet keresgélni az adatok között.
  - Be kell írni azt az azonosítót, amelyiket keresed és a programm kiírja.
  - Elírás esetén vagy hogy ha olyat ír be, ami nincs bent, akkor a programm kiírja, hogy ilyen adat nincs.
  
4. gomb: A programm leállítása.

> [!WARNING]
> Ha bármilyen más számot ad meg, a programm nem fog működni

