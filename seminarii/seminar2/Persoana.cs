namespace Seminar2{
	

	//start clasa persoana
	public class Persoana
	{
		// toate variabilele au nevoie de modificator de access
		// default este private
		private string name;
		private int varsta;
		// underscore elimina nevoia de a utiliza this. 
		private bool _areOchelari;
		
		public Persoana(string nume, int varsta, bool  areOchelari){
			//initializare membri clasei
			this.name = nume;
			this.varsta = varsta;
			_areOchelari = areOchelari;


		}
		public Persoana(){
			//initializam varialbilele cu valori default
			
			//string gol
			name = string.Empty;

			//self-explanatory
			varsta = 0;
			_areOchelari = false;
		}
		//in setteri se poate adauga logica pentru a evalua valorile primite
		public string Nume{
			//getter pentru valoarea numelui
			get{ return name;}
			//setter pentru valoarea numelui
			set{ name = value;}
		}

		public int Varsta{
			//getter pentru valoarea varstei
			get{ return varsta;}
			//setter pentru valoarea varstei
			set{
				//exemplu test de validitate date in setter
				if(value < 0){
					varsta = 0;
				}else{
					varsta = value;
				}
			}
		}
		public bool AreOchelari{
			//getter pentru valoarea numelui
			get{ return _areOchelari;}
			//setter pentru valoarea numeluo
			set{ _areOchelari = value;}
		}

	}
}


