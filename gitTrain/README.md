C# and git practise

Ten merge nie był fast-forward, ponieważ po utworzeniu gałęzi feature-max został dodany nowy commit na main. W efekcie obie gałęzie miały różną historię i Git musiał utworzyć merge commit, zamiast tylko przesunąć wskaźnik maina.

Added min calculation feature

1. Fast forward jest możliwy, gdy po utworzeniu nowej gałęzi na main nie pojawiły się żadne nowe commity. Wtedy Git tylko przesuwa wskaźnik main do przodu.
   Merge commit powstaje, gdy obie gałęzie mają nowe commity i Git musi połączyć różne historie.
2. merge łączy dwie gałęzie i zachowuje historię rozgałęzień, tworząc merge commit.
   rebase przenosi commity jednej gałęzi na koniec drugiej, dzięki czemu historia jest liniowa.
3. Konflikt pojawił się, ponieważ na gałęzi feature-conflict i na main został zmieniony ten sam fragment kodu. Konflikt został rozwiązany ręcznie przez wybranie końcowej wersji kodu i usunięcie markerów konfliktu.