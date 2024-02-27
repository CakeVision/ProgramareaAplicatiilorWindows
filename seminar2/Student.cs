namespace Seminar2;


// am definit clasa student ca o clasa derivata din clasa Persoana
public class Student:Persoana
{	
	
	// definim noi fielduri pentru clasa student
	private static int nrStudenti = 0;
	private const string bazaMatricol = "ASE";
	private string matricol;
	private double medie;


	// Din motive "foarte importante" nu mai folosim :ClassName cand apelam constructorul clasei de baza
	// se foloseste in loc termenul :base
	public Student(string nume, int varsta, bool areOchelari, double medie)
		//apel constructor clasa de baza(Persoana)
		:base(nume, varsta, areOchelari)
	{
		this.medie = medie;
		matricol = bazaMatricol + nrStudenti++;
	}
	//avem nevoie de destructor pentru a scadea nrStudenti dc stergem un student
	// altfel ar merge la infinit (indiferent dc noi avem doar cate 3 studenti in orice moment)
	// si noi fiind programatori eficienti nu vrem asta
	~Student(){
		nrStudenti--;
	}

}
