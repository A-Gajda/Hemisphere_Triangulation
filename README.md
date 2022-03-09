Grafika Komputerowa 1, projekt 2 - Aleksandra Gajda

Projekt dotyczy triangulacji półkuli oraz wypełniania jej za pomocą odpowiednio zmodyfikowanego koloru lub tekstury, tak aby symulować padające na nią z różnych punktów światło. Na światło widoczne na kuli wpływa umiejscowienie światła, umiejscowienie punktu na kuli oraz (opcjonalnie) mapa wektorów normalnych symulująca powierzchnię.

W celu optymalizacji renderowania obrazu w czasie poruszania się punktów, część operacji i obliczeń wykonywana jest w pre-processingu. Może to powodować niewielkie spowolnienia programu w momencie zmiany ustawień w menu po prawej stronie.

Punkt oświetlający półkulę przemieszcza się po spirali. Na początku znajduje się na środku ekranu i stopniowo zatacza coraz większe kręgi. Sprawia to, że na początku ruchu może on być słabo widoczny, w szczególności przy niektórych teksturach.

W folderze "textures" (znajdującym się w tym samym miejscu, co project solution) znajdują się przykładowe tekstury oraz mapy normalne, a także domyślna tekstura oraz mapa normalna. Modyfikacja lub zmiana miejsca tego katalogu może spowodować błędy w działaniu programu.



Sekcja "Triangulacja" służy do modyfikacji parametrów triangulacji półkuli. Można w niej ustawić dokładność triangulacji oraz zdecydować, czy linie siatki mają się wyświetlać. Ma to wpływ na możliwość przesuwania wierzchołków trójkątów przybliżających półkulę - można to robić jedynie wtedy, kiedy linie siatki są widoczne. W celu przesunięcia wierzchołka należy kliknąć na niego dwukrotnie (double click).

Sekcja "Współczynniki odbicia" pozwala ustawić współczynniki równania oświetlenia.

Sekcja "Tekstura" daje możliwość wyboru tekstury wyświetlanej na kuli. Może to być kolor (wybierany z okna dialogowego wyboru koloru) lub obraz z pliku znajdującego się na komputerze. Aby wybrać kolor lub plik, należy najpierw zaznaczyć odpowiadający mu radiobutton.

Sekcja "Mapa wektorów normalnych" pozwala zdecydować o użyciu mapy wektorów normalnych do symulowania powierzchni na kuli. Po zaznaczeniu tej opcji można wybrać nową mapę z pliku na komputerze. Sekcja umożliwia również modyfikację współczynnika "k", decydującego jak bardzo na wygląd powierzchni kuli wpływa mapa wektorów normalnych (im mniejsze "k" tym większy wpływ).

Sekcja "Kolor wypełnienia" zawiera wybór między dokładnym wyznaczaniem koloru każdego z punktów na kuli, a interpolacją koloru z wierzchołków trójkątów z triangulacji.

Sekcja "Źródło światła" dotyczy wszelkich ustawień dotyczących źródła światła i jego ruchu. Pozwala wybrać wysokość "z" światła nad powierzchnią, na której leży półkula, zmienić kolor światła (domyślnie biały), a także rozpocząć lub przerwać ruch świecącego punktu po spirali (przerwanie ruchu nie resetuje pozycji punktu) lub zresetować ruch (zresetowanie nie zatrzymuje ruchu). Po przebyciu przez punkt określonej drogi ruch automatycznie się zatrzymuje i resetuje.
