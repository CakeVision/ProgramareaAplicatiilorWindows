namespace Seminar2{

	internal class Program{
		static void Main(string[] Args){
			
			//=======================================================
			// Sectiune sintaxa vector si matrice
			//=======================================================

			//declarare vector cu valori
			int[] vectorStatic = {1,2,3};

			// declarare vector nou
			int[] vector = new int[3];

			Console.WriteLine("Afisare cu for simplu");
			//for loop
			for(int i = 0; i < vector.Length; i++){
				vector[i] = i;
				Console.WriteLine(vector[i]);
			}

			//For each loop
			Console.WriteLine("Foreach");
			foreach(int i in vector){
				// i is iterator, it's read only
				Console.WriteLine(i);
			}

			Console.WriteLine("Matrice");
			//declarare matrice

			//matrice cu 3 linii si 0 coloane
			//coloanele pot fi adaugate dupa
			int[][] matrice = new int[3][];
			
			//metoda muncitoreasca
			matrice[0] = new int[3];
			matrice[1] = new int[2];
			matrice[2] = new int[5];

			//afisare matrice
			for(int i = 0; i < matrice.Length; i++){
				for(int j = 0 ;  j < matrice[i].Length; j++){
					Console.WriteLine(matrice[i][j]);
				}
			}

			//=======================================================
			//SECTIUNE PERSOANA
			//=======================================================


			//initializam o persoana default
			Persoana p1 = new Persoana();
			//initializam persoana cu parametrii
			Persoana p2 = new Persoana("Persoana1", 20, true);
			//initializam persoana prin setteri
			Persoana p3 = new Persoana(){
				Nume = "Persoana3",
				Varsta = 19,
				AreOchelari = true
			};
			//afisam valorile lui p1
			Console.WriteLine("Sectiune Persoane");
			Console.WriteLine($"P2.Nume: {p2.Nume} , P2.Varsta: {p2.Varsta},P2.AreOchelari: {p2.AreOchelari}");
			//afiseaza numele lowercase
			//
			Console.WriteLine($"P2.Nume.ToLower: {p2.Nume.ToLower()}");
			//afiseaza numele uppercase
			Console.WriteLine($"P2.Nume.ToUpper: {p2.Nume.ToUpper()}");
			//extrage de la al doilea caracter din nume 2 caractere
			Console.WriteLine($"P2.Nume.Substring: {p2.Nume.Substring(2,2)}");
			// .Split
			// returneaza un array de string-uri
			//
			// .Split('what you want to split by')
			// Ex: String.Split(' ') separa stringul in bucati delimitate de aparitia la ' '
			// .Split(' ')[0] returneaza primul cuvant reiesit din delimitare
			// .Split(' ')[0][0] returneaza primul caracter al primului cuvant reiesit din split
			Console.WriteLine($"P2.Nume.Split: {p2.Nume.Split(' ')[0]}");
			
			//=======================================================
			//Sectiune Student
			//=======================================================
			Student s1 = new Student("Persoana1", 20, true, 9.5);
			Console.WriteLine($"S1.Nume: {s1.Nume}, S1.Varsta: {s1.Varsta}");
		}
	}
}

