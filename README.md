##### Azonositasduofeladat
Csoportos feladat C# programozási nyelv
## Csoport tagok: 
  - Piri Nóra
  - Kárpáti Liliána 

#### Programm működése:

### Bemenet:
## A felhasználónak három lehetősége van a menüben:
1. gomb: Ha ezt választja az user, akkor a programm azt várja el, hogy beírjuk a típusát az érkező járműnek.
  - Ha AUTÓ a bemenet -> A programm kéri fogja az Autó rendszámát, és autómatikusan elmenti a külön fáljba.
  - Ha olyan rendszmát ad meg a felhasználó, ami már bent van, akkor autómatikusan kiírja, hogy ez a jármű már szerepel és előrről indul a programm.
  - Ha bármi más a bemenet, akkor a belépőnek a nevét és igazolványszámát kell megadni. A fáljba az is el lesz mentve, hogy milyen járművel lépett be.
  - Ugyanúgy fennál az, hogy ha már bent lévő azonosítót adunk meg, akkor nem fogja mégegyszer elmenteni.
   
2. gomb: Ha ezt választja az user, akkor a programnak azokat az azonosítókat kell megadni, amik távoztak.
  - Ha olyan azonosítót ad meg az ember, amelyik nincs bent a adatok között, akkor nem fog megtörténni a mentés és ki fogyja írni, hogy ilyen azonosító nincs.
  - AZon kívűl az azonosító helyes begadása után a gyűjtőfáljba autómatikusan el lesz mentve a távozás ideje.

3. gomb: A programm leállítása.

> [!WARNING]
> Ha bármilyen más számot ad meg, a programm nem fog működni

