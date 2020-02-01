pisac:-
   write('Autor programu Mateusz Bieliñski'),nl,
   write('Czasownik "pisaæ"'),nl,
   write('Wpisz w dowolnym momencie "end" aby zakonczyc'),nl,
   write('Witaj. Jak masz na imiê?'),nl,
   read(Imie),
   czy_piszesz(Imie).

czy_piszesz(Imie) :-
    write('Czy piszesz? tak/nie'),nl,
    read(Czypiszesz),
    pytanie(Czypiszesz, Imie).

pytanie(tak,Imie) :-
    write('Co piszesz? ksiazke/program/wypracowanie/wiadomosci/notatki'),
    nl,read(Copiszesz),
    wybor(Copiszesz,Imie).
pytanie(nie,Imie) :-
    write('Przeciez piszesz wlasnie na klawiaturze. '),
    write('A poza tym? ksiazke/program/wypracowanie/wiadomosci/notatki'),
    nl,read(Copiszesz),
    wybor(Copiszesz,Imie).
pytanie(end,_) :- koniec.
pytanie(_,Imie) :- niepoprawna,read(Nexttry),pytanie(Nexttry,Imie).


wybor(ksiazke,Imie):- write('Jaka? historyczna/fantastyczna/podroznicza'),nl,
    read(Jakaksiazka),ksiazka(Jakaksiazka,Imie).
wybor(program,Imie):- write('Jaki? mobilny/webowy/desktopowy'),nl,read(Jakiprogram),
    program(Jakiprogram,Imie).
wybor(wypracowanie,Imie):- write('Z jakiego przedmiotu? polskiego/angielskiego/historii'),
    nl,read(Zjakiegoprzedmiotu),
    wypracowanie(Zjakiegoprzedmiotu,Imie).
wybor(wiadomosci,Imie):- write('Z kim? mama/dziewczyna/kolega?'),nl,
    read(Zkim),wiadomosci(Zkim,Imie).
wybor(notatki,Imie):- write('Jakie? wyklad/mysli/plany'),nl,
    read(Jakienotatki),notatki(Jakienotatki,Imie).
wybor(end,_) :- koniec.
wybor(_,Imie) :- niepoprawna,read(Wybor),wybor(Wybor,Imie).


ksiazka(historyczna,Imie):- write('O czym?'),nl, read(Oczym), wniosek1(Imie,Oczym).
ksiazka(fantastyczna,Imie):- write('O czym?'),nl, read(Oczym), wniosek2(Imie,Oczym).
ksiazka(podroznicza,Imie):- write('O czym?'),nl, read(Oczym), wniosek3(Imie,Oczym).
ksiazka(end,_):- koniec.
ksiazka(_,Imie) :- niepoprawna,read(Ksiazka),ksiazka(Ksiazka,Imie).


program(mobilny,Imie):- write('Do czego?'),nl, read(Doczego), wniosek4(Imie,Doczego).
program(webowy,Imie):- write('Do czego?'),nl, read(Doczego), wniosek5(Imie,Doczego).
program(desktopowy,Imie):- write('Do czego?'),nl, read(Doczego), wniosek6(Imie,Doczego).
program(end,_):- koniec.
program(_,Imie) :- niepoprawna,read(Program),program(Program,Imie).



wypracowanie(polskiego,Imie):- write('Na jaki temat?'),nl, read(Najakitemat),
    wniosek7(Imie,Najakitemat).
wypracowanie(angielskiego,Imie):- write('Na jaki temat?'),nl, read(Najakitemat),
    wniosek8(Imie,Najakitemat).
wypracowanie(historii,Imie):- write('Na jaki temat?'),nl, read(Najakitemat),
    wniosek9(Imie,Najakitemat).
wypracowanie(end,_):- koniec.
wypracowanie(_,Imie) :- niepoprawna,read(Wypracowanie),wypracowanie(Wypracowanie,Imie).



wiadomosci(mama,Imie):- write('O czym?'),nl, read(Oczym),
    wniosek10(Imie,Oczym).
wiadomosci(dziewczyna,Imie):- write('O czym?'),nl, read(Oczym),
    wniosek11(Imie,Oczym).
wiadomosci(kolega,Imie):-  write('O czym?'),nl, read(Oczym),
    wniosek12(Imie,Oczym).
wiadomosci(end,_):- koniec.
wiadomosci(_,Imie) :- niepoprawna,read(Wiadomosci),wiadomosci(Wiadomosci,Imie).



notatki(wyklad,Imie):- write('O czym?'),nl, read(Oczym),
    wniosek13(Imie,Oczym).
notatki(mysli,Imie):- write('O czym?'),nl, read(Oczym),
    wniosek14(Imie,Oczym).
notatki(plany,Imie):- write('O czym?'),nl, read(Oczym),
    wniosek15(Imie,Oczym).
notatki(end,_):- koniec.
notatki(_,Imie) :- niepoprawna,read(Notatki),notatki(Notatki,Imie).


wniosek1(Imie,Oczym):- write(Imie),
    write(' jest autorem ksiazek. Pisze ksiazkê historyczna o '),
    write(Oczym),
    koniec.
wniosek2(Imie,Oczym):- write(Imie),
    write(' jest autorem ksiazek. Pisze ksiazkê fantasy o '),
    write(Oczym),
    koniec.
wniosek3(Imie,Oczym):- write(Imie),
    write(' jest autorem ksiazek. Pisze ksiazkê podró¿nicz¹ o '),
    write(Oczym),
    koniec.


wniosek4(Imie,Doczego):- write(Imie),
    write(' jest programist¹. Pisze aplikacjê mobiln¹ do '),
    write(Doczego),
    koniec.
wniosek5(Imie,Doczego):- write(Imie),
    write(' jest programist¹. Pisze aplikacjê webow¹ do '),
    write(Doczego),
    koniec.
wniosek6(Imie,Doczego):- write(Imie),
    write(' jest programist¹. Pisze aplikacjê desktopow¹ do '),
    write(Doczego),
    koniec.


wniosek7(Imie,Najakitemat):- write(Imie),
    write(' jest uczniem. Pisze wypracowanie z jezyka polskiego na temat '),
    write(Najakitemat),
    koniec.
wniosek8(Imie,Najakitemat):- write(Imie),
    write(' jest uczniem. Pisze wypracowanie z jezyka angielskiego na temat '),
    write(Najakitemat),
    koniec.
wniosek9(Imie,Najakitemat):- write(Imie),
    write(' jest uczniem. Pisze wypracowanie z historii na temat '),
    write(Najakitemat),
    koniec.


wniosek10(Imie,Oczym):- write(Imie),
    write(' pisze wiadomoœci do mamy. Rozmawiaj¹ o '),
    write(Oczym),
    koniec.
wniosek11(Imie,Oczym):- write(Imie),
    write(' pisze wiadomoœci do dziewczyny. Rozmawiaj¹ o '),
    write(Oczym),
    koniec.
wniosek12(Imie,Oczym):- write(Imie),
    write(' pisze wiadomoœci do kolegi. Rozmawiaj¹ o '),
    write(Oczym),
    koniec.

wniosek13(Imie,Oczym):- write(Imie),
    write(' zapisuje notatki z wyk³adu o '),
    write(Oczym),
    koniec.
wniosek14(Imie,Oczym):- write(Imie),
    write(' notuje swoje mysli. Pisze o'),
    write(Oczym),
    koniec.
wniosek15(Imie,Oczym):- write(Imie),
    write(' notuje swoje plany. Pisze o'),
    write(Oczym),
    koniec.


niepoprawna:- write('Niepoprawna odpowiedz'),nl,write('Sprobuj ponownie lub wpisz "end"').

koniec:- nl,write('Koniec'),nl,!,abort.
