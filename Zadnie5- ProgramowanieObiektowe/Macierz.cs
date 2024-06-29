namespace Zadnie5__ProgramowanieObiektowe;

 public class Macierz<T> : IEquatable<Macierz<T>>
    {
        private T[,] tablica;

        public int WymiarWierszy { get; private set; }
        public int WymiarKolumn { get; private set; }

        public Macierz(int wymiarWierszy, int wymiarKolumn)
        {
            if (wymiarWierszy <= 0 || wymiarKolumn <= 0)
            {
                throw new ArgumentException("Wymiary macierzy muszą być dodatnie.");
            }

            WymiarWierszy = wymiarWierszy;
            WymiarKolumn = wymiarKolumn;
            tablica = new T[wymiarWierszy, wymiarKolumn];
        }

        public T this[int wiersz, int kolumna]
        {
            get
            {
                if (wiersz < 0 || wiersz >= WymiarWierszy || kolumna < 0 || kolumna >= WymiarKolumn)
                {
                    throw new IndexOutOfRangeException("Indeks poza zakresem macierzy.");
                }

                return tablica[wiersz, kolumna];
            }
            set
            {
                if (wiersz < 0 || wiersz >= WymiarWierszy || kolumna < 0 || kolumna >= WymiarKolumn)
                {
                    throw new IndexOutOfRangeException("Indeks poza zakresem macierzy.");
                }

                tablica[wiersz, kolumna] = value;
            }
        }

        public static bool operator ==(Macierz<T> m1, Macierz<T> m2)
        {
            if (ReferenceEquals(m1, m2)) return true;
            if (m1 is null || m2 is null) return false;

            if (m1.WymiarWierszy != m2.WymiarWierszy || m1.WymiarKolumn != m2.WymiarKolumn)
                return false;

            for (int i = 0; i < m1.WymiarWierszy; i++)
            {
                for (int j = 0; j < m1.WymiarKolumn; j++)
                {
                    if (!Equals(m1[i, j], m2[i, j]))
                        return false;
                }
            }

            return true;
        }

        public static bool operator !=(Macierz<T> m1, Macierz<T> m2)
        {
            return !(m1 == m2);
        }

        public bool Equals(Macierz<T> other)
        {
            return this == other;
        }

        public override bool Equals(object obj)
        {
            if (obj is Macierz<T> other)
            {
                return Equals(other);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return tablica.GetHashCode(); // Prosty sposób na zwrócenie hasha dla macierzy
        }
    }