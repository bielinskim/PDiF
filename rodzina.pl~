%Pradziadkowie
rodzic(szymon,aleksander).
rodzic(zofia,aleksander).

rodzic(franciszek,alicja).
rodzic(oliwia,alicja).

rodzic(antoni,jan).
rodzic(lena,jan).

rodzic(jakub,amelia).
rodzic(julia,amelia).

%Dziadkowie, rodzice i ich rodzeñstwo
rodzic(aleksander,mikolaj).
rodzic(alicja,mikolaj).
rodzic(aleksander,filip).
rodzic(alicja,filip).

rodzic(jan,natalia).
rodzic(amelia,natalia).
rodzic(jan,hanna).
rodzic(amelia,hanna).

%Rodzice i rodzeñstwo
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
