# Portás szimulátor

Csoportos feladat C# programozási nyelven.

## Csoporttagok:
- Piri Nóra
- Kárpáti Liliána

## A program célja:
A program egy egyszerű beléptető rendszer működését mutatja be.
Személyek és járművek belépését, távozását és keresését lehet vele rögzíteni.

## Program működése:

### Főmenü:
A program elindítása után négy lehetőség közül lehet választani:

1. Belépés
2. Távozás
3. Keresés
4. Kilépés a programból

A kívánt opciót a hozzá tartozó szám beírásával lehet kiválasztani.

### 1. Belépés:
A program először bekéri az érkező típusát.
A megadható típusok: autó, motor, roller, kerékpár vagy gyalog (esetleg egyéb, de akkor az nem számít).

- Autó esetén a program bekéri a rendszámot.
- Motor esetén a program szintén a rendszámot kéri.
- Más típus esetén a belépő nevét és igazolványszámát kell megadni.
- Sikeres belépéskor a program rögzíti az adatokat és a belépés időpontját.
- Ha a rendszám vagy egy igazolványszám már szerepel a bent lévők között, a program nem veszi fel újra.

### 2. Távozás:
A távozás rögzítéséhez a bent lévő személy nevét vagy a jármű rendszámát kell megadni.

- Ha az azonosító megtalálható a bent lévők között, a program rögzíti a távozás időpontját.
- A távozó személy vagy jármű ezután kikerül a bent lévők nyilvántartásából.
- Ha az azonosító nem található, a program erről üzenetet jelenít meg.

### 3. Keresés:
- A kereséshez a személy nevét vagy a jármű rendszámát kell megadni.
- A program az `adatok.txt` fájlban keresi meg a megadott adatot.
- A találatként megtalált belépési adatokat megjeleníti a képernyőn.
- Ha nem talál megfelelő adatot, a program jelzi, hogy ilyen adat nincs.

### 4. Kilépés:
- A negyedik lehetőség kiválasztásával a program leáll.
- A program bezárása után a főmenübe már nem lehet visszatérni.

## Adatok mentése:
- A program a belépési és távozási adatokat az `adatok.txt` nevű fájlba menti.
- A fájlba kerülnek az azonosítók, valamint a rögzített időpontok.
- A program a fájlba új adatokat ír, így a korábbi bejegyzések is megmaradnak.
- Az `adatok.txt` fájl a program futtatási mappájában jön létre.

> [!NOTE]
> Bármelyik adatbekérésnél, ha üresen hagyja a helyet felhasználó, a program figyelmeztető üzenetet ad, és automatikusan megy a főmenübe.

> [!WARNING]
> Ha a menüben 1 és 4 közöttitől eltérő gombot vagy értéket adsz meg, a program figyelmeztet, hogy nincs ilyen opció, és újra megjeleníti a menüt.
