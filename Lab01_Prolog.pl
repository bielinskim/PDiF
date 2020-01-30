%Pradziadkowie
rodzic(szymon,aleksander).
rodzic(zofia,aleksander).

rodzic(franciszek,alicja).
rodzic(oliwia,alicja).

rodzic(antoni,jan).
rodzic(lena,jan).

rodzic(jakub,amelia).
rodzic(julia,amelia).

%Dziadkowie, rodzice i ich rodzeństwo
rodzic(aleksander,mikolaj).
rodzic(alicja,mikolaj).
rodzic(aleksander,filip).
rodzic(alicja,filip).

rodzic(jan,natalia).
rodzic(amelia,natalia).
rodzic(jan,hanna).
rodzic(amelia,hanna).

%Rodzice i rodzeństwo
rodzic(mikolaj,wojciech).
rodzic(natalia,wojciech).

rodzic(mikolaj,aleksandra).
rodzic(natalia,aleksandra).

rodzic(mikolaj,kacper).
rodzic(natalia,kacper).


mezczyzna(szymon).
mezczyzna(franciszek).
mezczyzna(antoni).
mezczyzna(jakub).
mezczyzna(aleksander).
mezczyzna(filip).
mezczyzna(jan).
mezczyzna(mikolaj).
mezczyzna(wojciech).
mezczyzna(kacper).

kobieta(zofia).
kobieta(oliwia).
kobieta(lena).
kobieta(julia).
kobieta(alicja).
kobieta(amelia).
kobieta(natalia).
kobieta(hanna).
kobieta(aleksandra).

urodzony(szymon,1930).
urodzony(zofia,1933).
urodzony(franciszek,1925).
urodzony(oliwia,1931).
urodzony(antoni,1928).
urodzony(lena,1931).
urodzony(jakub,1936).
urodzony(julia,1940).

urodzony(aleksander,1955).
urodzony(alicja,1956).
urodzony(jan,1958).
urodzony(amelia,1965).

urodzony(mikolaj,1981).
urodzony(filip,1984).
urodzony(natalia,1988).
urodzony(hanna,1990).

urodzony(wojciech,2012).
urodzony(aleksandra,2015).
urodzony(kacper,2017).

zmarl(szymon,2004).
zmarl(zofia,2013).
zmarl(franciszek,1970).
zmarl(oliwia,2000).
zmarl(antoni,2009).
zmarl(lena,2003).

zyje(jakub).
zyje(julia).
zyje(aleksander).
zyje(alicja).
zyje(jan).
zyje(amelia).
zyje(mikolaj).
zyje(filip).
zyje(natalia).
zyje(hanna).
zyje(wojciech).
zyje(aleksandra).
zyje(kacper).

zawod(jakub,emeryt).
zawod(julia,emeryt).
zawod(aleksander,mechanik).
zawod(alicja,brak).
zawod(jan,elektryk).
zawod(amelia,nauczyciel).
zawod(mikolaj,hydraulik).
zawod(filip,rolnik).
zawod(natalia,ksiegowa).
zawod(hanna,nauczyciel).

uczen(wojciech).

lubi(wedkarstwo, aleksander).
lubi(szydelkowanie, amelia).
lubi(czytac_gazete, jan).
lubi(ogladac_tv, mikolaj).
lubi(czytac_ksiazki, natalia).
lubi(gry_komputerowe, wojciech).


matka(X,Y) :-
    rodzic(X,Y),
    kobieta(X).

ojciec(X,Y) :-
    rodzic(X,Y),
    mezczyzna(X).

dziadek(X,Y) :-
    rodzic(Z,Y),
    rodzic(X,Z),
    mezczyzna(X).

babcia(X,Y) :-
    rodzic(Z,Y),
    rodzic(X,Z),
    kobieta(X).

brat(X,Y) :-
    ojciec(Z,Y),
    ojciec(Z,X),
    X\=Y,
    mezczyzna(X).

siostra(X,Y) :-
    ojciec(Z,Y),
    ojciec(Z,X),
    X\=Y,
    kobieta(X).

wujek(X,Y) :-
    rodzic(Z,Y),
    brat(X,Z).

ciocia(X,Y) :-
    rodzic(Z,Y),
    siostra(X,Z).

pradziadek(X,Y) :-
    rodzic(Z,Y),
    rodzic(W,Z),
    rodzic(X,W),
    mezczyzna(X).

prababcia(X,Y) :-
    rodzic(Z,Y),
    rodzic(W,Z),
    rodzic(X,W),
    kobieta(X).

syn(Y, X) :-
    rodzic(Y,X),
    mezczyzna(X).

corka(Y,X) :-
    rodzic(Y,X),
    kobieta(X).

zylwczasie(wojny, X) :-
    urodzony(X, Y),
    Y<1945,
    zmarl(X, Z),
    Z>1939.

zylwczasie(wojny, X) :-
    urodzony(X, Y),
    Y<1945,
    zyje(X).

zylwczasie(socjalizmu, X) :-
    urodzony(X, Y),
    Y<1989,
    zmarl(X,Z),
    Z>1945.

zylwczasie(socjalizmu, X) :-
    urodzony(X, Y),
    Y<1989,
    zyje(X).
